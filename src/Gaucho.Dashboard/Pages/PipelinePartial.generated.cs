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





WriteLiteral("\r\n<div class=\"pipeline-item\">\r\n    <div class=\"pipeline-item-container\">\r\n       " +
" <div class=\"pipeline-item-header\">\r\n            <h3>");


            
            #line 10 "..\..\Pages\PipelinePartial.cshtml"
           Write(Pipeline.PipelineId);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"pipeline-item-content\">\r\n");


            
            #line 13 "..\..\Pages\PipelinePartial.cshtml"
             foreach (var m in Pipeline.Metrics)
            {
                var id = Pipeline.PipelineId + "-" + m.Key;
                var labelId = id + "-label";


            
            #line default
            #line hidden
WriteLiteral("                <div>\r\n                    <div class=\"label\" id=\"");


            
            #line 19 "..\..\Pages\PipelinePartial.cshtml"
                                      Write(labelId);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 19 "..\..\Pages\PipelinePartial.cshtml"
                                                Write(m.Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div id=\"");


            
            #line 20 "..\..\Pages\PipelinePartial.cshtml"
                        Write(id);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 20 "..\..\Pages\PipelinePartial.cshtml"
                             Write(m.Value);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n");


            
            #line 22 "..\..\Pages\PipelinePartial.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");



WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div> \r\n ");


        }
    }
}
#pragma warning restore 1591