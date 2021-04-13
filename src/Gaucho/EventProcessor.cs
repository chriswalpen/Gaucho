﻿using Gaucho.Diagnostics;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Gaucho
{
	/// <summary>
	/// EventProcessor
	/// </summary>
	public class EventProcessor : IDisposable
	{
		private readonly string _id = Guid.NewGuid().ToString();
		private readonly object _syncRoot = new object();
		private readonly Action _continuation;
		private readonly ILogger _logger;
		private readonly IWorker<IEventPipeline> _worker;

		private bool _isWorking;
		private readonly Lazy<IEventPipeline> _pipeline;

		/// <summary>
		/// Creates a new instance of EventProcessor
		/// </summary>
		/// <param name="factory"></param>
		/// <param name="worker"></param>
		/// <param name="continuation"></param>
		/// <param name="logger"></param>
		public EventProcessor(Func<IEventPipeline> factory, IWorker<IEventPipeline> worker, Action continuation, ILogger logger)
		{
			logger.Write($"Created new WorkerThread with Id {_id}", Category.Log, LogLevel.Debug, "EventBus");

			_worker = worker ?? throw new ArgumentNullException(nameof(worker));
			_continuation = continuation ?? throw new ArgumentNullException(nameof(continuation));
			_logger = logger;
			_pipeline = new Lazy<IEventPipeline>(factory);
		}

		/// <summary>
		/// The Task that the processor runs in
		/// </summary>
		public Task Task { get; private set; }

		/// <summary>
		/// Gets if the processor is working
		/// </summary>
		public bool IsWorking
		{
			get
			{
				lock (_syncRoot)
				{
					return _isWorking;
				}
			}
		}

		/// <summary>
		/// Dispose the processor
		/// </summary>
		public void Dispose()
		{
			lock (_syncRoot)
			{
				_isWorking = false;
				_logger.Write($"Disposed WorkerThread with Id {_id}", Category.Log, LogLevel.Debug, "EventBus");
			}
		}

		/// <summary>
		/// Start processing events
		/// </summary>
		public void Start()
		{
			lock (_syncRoot)
			{
				if (_isWorking)
				{
					return;
				}

				_isWorking = true;
			}

			_logger.Write($"Start working on Thread {_id}", Category.Log, LogLevel.Debug, "EventBus");

			Task = Task.Factory.StartNew(() =>
			{
				try
				{
					_worker.Execute(_pipeline.Value);
				}
				catch (Exception e)
				{
					_logger.Write(e.Message, Category.Log, LogLevel.Error, "EventProcessor");
				}
				finally
				{
					lock (_syncRoot)
					{
						_isWorking = false;
					}

					_continuation();
				}
			}, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
		}
	}
}
