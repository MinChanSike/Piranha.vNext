﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.PostTypeMgr
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/PostTypeMgr/List.cshtml")]
    public partial class List : System.Web.Mvc.WebViewPage<Piranha.Manager.Models.PostType.ListModel>
    {
        public List()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
  
	ViewBag.Title = Piranha.Manager.Resources.PostType.ListTitle;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("script", () => {

WriteLiteral("\r\n\t<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n\t\tvar options = {\r\n\t\t\tvalueNames: [\'type-name\', \'type-updated\', \'type-created\'" +
"]\r\n\t\t};\r\n\t\tvar typeList = new List(\'type-list\', options);\r\n\t</script>\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container-fluid\"");

WriteLiteral(">\r\n\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"col-sm-12 buttons\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 448), Tuple.Create("\"", 492)
            
            #line 18 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
, Tuple.Create(Tuple.Create("", 455), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", new { @id = "" })
            
            #line default
            #line hidden
, 455), false)
);

WriteLiteral(" class=\"btn btn-primary btn-labeled\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"btn-label\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<i");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></i>\r\n\t\t\t\t\t</span>");

            
            #line 21 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
                      Write(Piranha.Manager.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<table");

WriteLiteral(" id=\"type-list\"");

WriteLiteral(" class=\"table table-striped table-main\"");

WriteLiteral(">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th><span");

WriteLiteral(" class=\"sort desc\"");

WriteLiteral(" data-sort=\"type-name\"");

WriteLiteral(">");

            
            #line 30 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
                                                             Write(Piranha.Manager.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n\t\t\t\t<th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"type-updated\"");

WriteLiteral(">");

            
            #line 31 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
                                                                        Write(Piranha.Manager.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n\t\t\t\t<th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"type-created\"");

WriteLiteral(">");

            
            #line 32 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
                                                                        Write(Piranha.Manager.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n\t\t\t\t<th");

WriteLiteral(" class=\"actions one\"");

WriteLiteral("></th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n");

            
            #line 37 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
			
            
            #line default
            #line hidden
            
            #line 37 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
             foreach (var type in Model.Items) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td");

WriteLiteral(" class=\"type-name\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1295), Tuple.Create("\"", 1344)
            
            #line 39 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
, Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", new { @id = type.Id })
            
            #line default
            #line hidden
, 1302), false)
);

WriteLiteral(">");

            
            #line 39 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
                                                                                          Write(type.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n\t\t\t\t\t<td");

WriteLiteral(" class=\"type-updated\"");

WriteLiteral(">");

            
            #line 40 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
                                        Write(type.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n\t\t\t\t\t<td");

WriteLiteral(" class=\"type-created\"");

WriteLiteral(">");

            
            #line 41 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
                                        Write(type.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n\t\t\t\t\t<td");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<a");

WriteLiteral(" class=\"delete\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1563), Tuple.Create("\"", 1614)
            
            #line 43 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
, Tuple.Create(Tuple.Create("", 1570), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", new { @id = type.Id })
            
            #line default
            #line hidden
, 1570), false)
);

WriteLiteral("></a>\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");

            
            #line 46 "..\..\Areas\Manager\Views\PostTypeMgr\List.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
