﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gaucho.Dashboard.Pages
{
    using System;
    
    #line 3 "..\..\Pages\PipelinePartial.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\PipelinePartial.cshtml"
    using Gaucho.Dashboard;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\PipelinePartial.cshtml"
    using Gaucho.Dashboard.Monitoring;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Pages\PipelinePartial.cshtml"
    using Gaucho.Dashboard.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class PipelinePartial : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






WriteLiteral("\r\n");


            
            #line 8 "..\..\Pages\PipelinePartial.cshtml"
  
	var pId = Pipeline.ServerName + "-" + Pipeline.PipelineId;


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"pipeline-item\" id=\"");


            
            #line 12 "..\..\Pages\PipelinePartial.cshtml"
                          Write(pId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t<div class=\"pipeline-item-container\">\r\n");


            
            #line 14 "..\..\Pages\PipelinePartial.cshtml"
  		
			var cls = Pipeline.IsActive ? "is-open" : string.Empty;
		

            
            #line default
            #line hidden
WriteLiteral("\t\t<div class=\"toggler-section pipeline-item-header ");


            
            #line 17 "..\..\Pages\PipelinePartial.cshtml"
                                              Write(cls);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t<div class=\"pipeline-title-button\">\r\n\t\t\t\t<h3>");


            
            #line 19 "..\..\Pages\PipelinePartial.cshtml"
   Write(Pipeline.PipelineId);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\t\t\t</div>\r\n\t\t\t<i class=\"trash-button\" title=\"Clear logs and metrics\" data-" +
"pipeline=\"");


            
            #line 21 "..\..\Pages\PipelinePartial.cshtml"
                                                                    Write(Pipeline.PipelineId);

            
            #line default
            #line hidden
WriteLiteral("\" data-server=\"");


            
            #line 21 "..\..\Pages\PipelinePartial.cshtml"
                                                                                                       Write(Pipeline.ServerName);

            
            #line default
            #line hidden
WriteLiteral("\"></i>\r\n\t\t</div>\r\n\t\t<div class=\"toggle-wrapper pipeline-item-content\">\r\n\t\t\t<div c" +
"lass=\"pipeline-metric-content\">\r\n");


            
            #line 25 "..\..\Pages\PipelinePartial.cshtml"
 				foreach (var m in Pipeline.Metrics)
				{
					var id = Pipeline.ServerName + "-" + Pipeline.PipelineId + "-" + m.Key;
					var labelId = id + "-label";


            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<div class=\"pipeline-metric-item\">\r\n\t\t\t\t\t\t<div class=\"label\" id=\"");


            
            #line 31 "..\..\Pages\PipelinePartial.cshtml"
                        Write(labelId);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 31 "..\..\Pages\PipelinePartial.cshtml"
                                  Write(m.Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\t\t\t\t\t\t<div id=\"");


            
            #line 32 "..\..\Pages\PipelinePartial.cshtml"
          Write(id);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 32 "..\..\Pages\PipelinePartial.cshtml"
               Write(m.Value);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\t\t\t\t\t</div>\r\n");


            
            #line 34 "..\..\Pages\PipelinePartial.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"pipeline-item-log-container\">\r\n");


            
            #line 39 "..\..\Pages\PipelinePartial.cshtml"
 				if (Pipeline.Elements.ContainsKey("WorkersLog"))
				{
					var element = Pipeline.Elements["WorkersLog"];
					var id = Pipeline.ServerName + "-" + Pipeline.PipelineId + "-" + element.Key.ToLower();

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<div class=\"toggler-section\">\r\n\t\t\t\t\t\t<span class=\"toggler-button\"></span>\r\n\t" +
"\t\t\t\t\t<div class=\"label\" id=\"logs-label\">Workers Timeline</div>\r\n\t\t\t\t\t</div>\r\n");


            
            #line 47 "..\..\Pages\PipelinePartial.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<div id=\"");


            
            #line 48 "..\..\Pages\PipelinePartial.cshtml"
         Write(id);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"pipeline-item-log-list toggle-wrapper\">\r\n");


            
            #line 49 "..\..\Pages\PipelinePartial.cshtml"
 						foreach (TimelineLog<int> e in element.Elements)
						{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t<div class=\"pipeline-item-log-item\">\r\n\t\t\t\t\t\t\t\t<span class=\"pipeline-item-l" +
"og-element pipeline-log-debug\">");


            
            #line 52 "..\..\Pages\PipelinePartial.cshtml"
                                                              Write(e.Timestamp.ToString("o"));

            
            #line default
            #line hidden
WriteLiteral("</span><span class=\"pipeline-item-log-element\">");


            
            #line 52 "..\..\Pages\PipelinePartial.cshtml"
                                                                                                                                       Write(e.Value);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t\t\t\t</div>\r\n");


            
            #line 54 "..\..\Pages\PipelinePartial.cshtml"
						}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t</div>\r\n");


            
            #line 56 "..\..\Pages\PipelinePartial.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t</div>\r\n\t\t\t<div class=\"pipeline-item-log-container\">\r\n");


            
            #line 59 "..\..\Pages\PipelinePartial.cshtml"
 				if (Pipeline.Elements.ContainsKey("EventLog"))
				{
					var element = Pipeline.Elements["EventLog"];
					var id = Pipeline.ServerName + "-" + Pipeline.PipelineId + "-" + element.Key.ToLower();

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<div class=\"toggler-section\">\r\n\t\t\t\t\t\t<span class=\"toggler-button\"></span>\r\n\t" +
"\t\t\t\t\t<div class=\"label\" id=\"logs-label\">Events</div>\r\n\t\t\t\t\t</div>\r\n");


            
            #line 67 "..\..\Pages\PipelinePartial.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<div id=\"");


            
            #line 68 "..\..\Pages\PipelinePartial.cshtml"
         Write(id);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"pipeline-item-log-list toggle-wrapper\">\r\n");


            
            #line 69 "..\..\Pages\PipelinePartial.cshtml"
 						foreach (DashboardLog e in element.Elements)
						{
							var levelClass = $"pipeline-log-{e.Level.ToLower()}";

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t<div class=\"pipeline-item-log-item\">\r\n\t\t\t\t\t\t\t\t<span class=\"pipeline-item-l" +
"og-element ");


            
            #line 73 "..\..\Pages\PipelinePartial.cshtml"
                                          Write(levelClass);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 73 "..\..\Pages\PipelinePartial.cshtml"
                                                       Write(e.Timestamp.ToString("o"));

            
            #line default
            #line hidden
WriteLiteral("</span><span class=\"pipeline-item-log-element\">[");


            
            #line 73 "..\..\Pages\PipelinePartial.cshtml"
                                                                                                                                 Write(e.Source);

            
            #line default
            #line hidden
WriteLiteral("]</span><span class=\"pipeline-item-log-element\">[");


            
            #line 73 "..\..\Pages\PipelinePartial.cshtml"
                                                                                                                                                                                           Write(e.Level);

            
            #line default
            #line hidden
WriteLiteral("]</span><span class=\"pipeline-item-log-element\">");


            
            #line 73 "..\..\Pages\PipelinePartial.cshtml"
                                                                                                                                                                                                                                                   Write(e.Message);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t\t\t\t</div>\r\n");


            
            #line 75 "..\..\Pages\PipelinePartial.cshtml"
						}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t</div>\r\n");


            
            #line 77 "..\..\Pages\PipelinePartial.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div> \r\n ");


        }
    }
}
#pragma warning restore 1591
