#pragma checksum "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5f5d9d54340331d15674db63a3df8649591a73e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\_ViewImports.cshtml"
using NWEB.Practice.HieuCM3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\_ViewImports.cshtml"
using NWEB.Practice.HieuCM3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5f5d9d54340331d15674db63a3df8649591a73e", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edca715cf5669a1bb8a117c83798de6f384a643b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/app.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Category";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5f5d9d54340331d15674db63a3df8649591a73e4318", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""content"">
    <!-- Begin Page Content -->
    <div class=""container-fluid"">

        <!-- Page Heading -->
        <h1 class=""h3 mb-2 text-gray-800"">Danh sách danh mục</h1>
        <div class=""h3 mb-2 row"">
            <div class=""col-md-12 col-lg-12"">
                <a");
            BeginWriteAttribute("href", " href=\"", 443, "\"", 491, 1);
#nullable restore
#line 16 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 450, Url.Action("CreateCategory", "Category"), 450, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success btn-icon-split"">
                    <span class=""icon text-white-50"">
                        <i class=""fas fa-plus""></i>
                    </span>
                    <span class=""text"">Thêm mới</span>
                </a>
            </div>
        </div>

        <!-- DataTales Example -->
        <div class=""card shadow mb-4"">
            <div class=""card-body"">
                <div class=""form-group row"" style=""justify-content: flex-end"">
                    <div class=""col-md-12 col-lg-3 pr-0"">
                        <input id=""searchValue"" class=""form-control searchValue"" type=""text"" placeholder=""Tìm kiếm"" />
                    </div>
                    <a class=""btn btn-success btn-icon-split"" onclick=""reloadWithPageOne()"">
                        <span class=""icon text-white-50"">
                            <i class=""fas fa-search""></i>
                        </span>
                    </a>
                </div>
                <table class=""tabl");
            WriteLiteral(@"e table-bordered"" id=""monthPlanningTbl"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th data-orderable=""false"">Id</th>
                            <th data-orderable=""false"">Oder</th>
                            <th data-orderable=""false"">Category Name</th>
                            <th data-orderable=""false"">Text</th>
                            <th data-orderable=""false"">Action</th>
                        </tr>
                    </thead>
                    <tfoot>
                    </tfoot>
                </table>
            </div>
        </div>
    </div>
    <!-- /.container-fluid -->
</div>
<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Thông b");
            WriteLiteral(@"áo</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">Bạn muốn xóa bản ghi này không?</div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Hủy</button>
                <a class=""btn btn-danger"" onclick=""DeleteCategory()"">Xóa</a>
            </div>
        </div>
    </div>
</div>
<script>
    var table = undefined;
    $(document).ready(function () {
        loadTable();
        $('#searchValue').keypress(function (e) {
            if (e.which == 13) {
                reloadWithPageOne();
            }
        });
    });
    function reloadWithPageOne() {
        if (table != undefined && table.api().ajax != undefined)
            table.api().ajax.reload(null, true);
    }
    function reload() {
        if (table != undefined");
            WriteLiteral(@" && table.api().ajax != undefined)
            table.api().ajax.reload(null,false);
    }
    function loadTable() {
        table = $('#monthPlanningTbl').dataTable({
            ""oLanguage"": {
                ""sEmptyTable"": ""Không có danh mục""
            },
            ""language"": {
                ""paginate"": {
                    ""previous"": ""Trước"",
                    ""next"": ""Tiếp theo""
                }
            },
            searching: false,
            paging: true,
            lengthChange: false,
            ordering: true,
            filter: false,
            destroy: true,
            orderMulti: false,
            serverSide: true,
            processing: true,
            lengthChange: false,
            ""bSort"": false,
            ajax: function (data, callback, settings) {
                data.searchValue = $('#searchValue').val();
                postTable(""");
#nullable restore
#line 115 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Category\Index.cshtml"
                      Write(Url.Action("GetListCategory", "Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", data, callback);
            },
            ""columns"": [
                { ""data"": ""id"", ""name"": ""Id"", ""class"": ""id"" },
                { ""data"": ""oder"", ""name"": ""Oder"", ""class"": ""oder"" },
                { ""data"": ""categoryName"", ""name"": ""CategoryName"", ""class"": ""categoryName"" },
                { ""data"": ""text"", ""name"": ""Text"", ""class"": ""text"" },
                {
                    ""class"": ""action"",
                    ""render"": function (data, row, full) {
                        return ""<a class='fas fa-fw fa-edit' title='Sửa' onclick=UpdateCategory('"" + full.id + ""'); ></a> <a href='#' class='fas fa-fw fa-trash' style='color:red' title='Xóa' data-toggle='modal' data-target='#deleteModal' onclick=openConfirmDelete('"" + full.id + ""');></a>"";
                    }
                }
            ]
        });
    }

    function openConfirmDelete(id) {
        deleteId = id;
    }

    function DeleteCategory() {
        var formData = new FormData();
        formData.append(""Id"",");
            WriteLiteral(" deleteId);\r\n        formData.append(\"__RequestVerificationToken\", _token);\r\n        postAjax(\'");
#nullable restore
#line 140 "C:\Users\MuwnHius\source\repos\NWEB.Practice.HieuCM3\NWEB.Practice.HieuCM3\Areas\Admin\Views\Category\Index.cshtml"
             Write(Url.Action("DeleteCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', formData, function (data) {\r\n            $(\'#deleteModal\').modal(\"hide\");\r\n            reload();\r\n        });\r\n    }\r\n\r\n    function UpdateCategory(id) {\r\n        location.href = \'/sua-danh-muc\' + \"/\" + id;\r\n    }\r\n</script>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
