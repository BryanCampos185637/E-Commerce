#pragma checksum "C:\Users\Bryan J. Campos\Documents\GitHub\Ecommerce\TiendaOnline\UserInterface\Views\Producto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5112a39e8f08a551d9eba3960d9f90ae5d880b8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Index), @"mvc.1.0.view", @"/Views/Producto/Index.cshtml")]
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
#line 1 "C:\Users\Bryan J. Campos\Documents\GitHub\Ecommerce\TiendaOnline\UserInterface\Views\_ViewImports.cshtml"
using UserInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bryan J. Campos\Documents\GitHub\Ecommerce\TiendaOnline\UserInterface\Views\_ViewImports.cshtml"
using UserInterface.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5112a39e8f08a551d9eba3960d9f90ae5d880b8c", @"/Views/Producto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f481da0a7c0591915091e19c9e27a8273b0c001", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmRegister"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Home/_Tabla.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/generic.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/peticionHttp.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Bryan J. Campos\Documents\GitHub\Ecommerce\TiendaOnline\UserInterface\Views\Producto\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Producto</h1>
<div class=""row"">
    <div class=""col-12 mb-3"">
        <div class=""card"">
            <div class=""card-body"">
                <button type=""button"" class=""btn btn-sm btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
                    Nuevo
                </button>
            </div>
        </div>
        <!-- Modal -->
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Formulario De Registro</h5>
                        <button type=""button"" id=""btnCloseModal"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5112a39e8f08a551d9eba3960d9f90ae5d880b8c6195", async() => {
                WriteLiteral(@"
                        <input type=""hidden"" class=""dataFrmCategory"" id=""ProductId"" name=""ProductId"" value=""0"" />
                        <div class=""modal-body"">
                            <label>Nombre:</label>
                            <div class=""input-group mb-3"">
                                <span class=""input-group-text""><i class=""fas fa-edit""></i></span>
                                <input type=""text"" id=""Name"" name=""Name"" class=""form-control"" placeholder=""Escribe el nombre..."">
                            </div>
                            <label>Categoria:</label>
                            <div class=""input-group mb-3"">
                                <span class=""input-group-text""><i class=""fas fa-table""></i></span>
                                <select class=""form-control dataFrmCategory"" id=""CategoryId"" name=""CategoryId""></select>
                            </div>
                            <label>Proveedor:</label>
                            <div class=""input-group");
                WriteLiteral(@" mb-3"">
                                <span class=""input-group-text""><i class=""fas fa-dolly-flatbed""></i></span>
                                <select class=""form-control dataFrmCategory"" id=""SupplierId"" name=""SupplierId""></select>
                            </div>
                            <label>Descripción:</label>
                            <div class=""input-group mb-3"">
                                <span class=""input-group-text""><i class=""fas fa-edit""></i></span>
                                <input type=""text"" id=""Description"" name=""Description"" class=""form-control dataFrmCategory"" placeholder=""Escribe la descripción..."">
                            </div>
                            <label>Precio:</label>
                            <div class=""input-group mb-3"">
                                <span class=""input-group-text""><i class=""fas fa-dollar-sign""></i></span>
                                <input type=""text"" id=""Price"" name=""Price"" class=""form-control dataFrmCategory"" p");
                WriteLiteral(@"laceholder=""Escribe el precio..."">
                            </div>
                            <label>Cantidad:</label>
                            <div class=""input-group mb-3"">
                                <span class=""input-group-text""><i class=""fas fa-box-open""></i></span>
                                <input type=""text"" id=""Quantity"" name=""Quantity"" class=""form-control dataFrmCategory"" placeholder=""Escribe la cantidad..."">
                            </div>

                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-sm btn-danger"" data-bs-dismiss=""modal"">Cerrar</button>
                            <button type=""submit"" class=""btn btn-sm btn-primary"">Guardar</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5112a39e8f08a551d9eba3960d9f90ae5d880b8c10777", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5112a39e8f08a551d9eba3960d9f90ae5d880b8c11958", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5112a39e8f08a551d9eba3960d9f90ae5d880b8c12998", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    window.onload = function () {
        GetAll(1);
        peticion.get('api/categoryApi/', (data) => {
            dom.select(data['data'], 'CategoryId', 'categoryId', 'name');
        })
        peticion.get('api/supplierApi/', (data) => {
            dom.select(data['data'], 'SupplierId', 'supplierId', 'name');
        })
    }
    function GetAll(page) {
        peticion.get('api/ProductAPI/' + page, function (result) {
            let data = result['data'];
            dom.table(data['items'], ['ID', 'NOMBRE', 'DESCRIPCION', 'PROVEEDOR', 'CATEGORIA'],
                ['productId', 'name', 'description', 'supplierName', 'categoryName'], 'productId', true, true, 'exampleModal');
            dom.panelPagination(data);
        })
    }
    function BackPage(page) {
        if (page > 0)
            GetAll(page);
    }
    function NextPage(page) {
        GetAll(page);
    }
    form.submit('frmRegister', function () {
        let product = {
            'ProductId': f");
            WriteLiteral(@"orm.getTextInputValue('ProductId'),
            'Name': form.getTextInputValue('Name'),
            'CategoryId': form.getTextInputValue('CategoryId'),
            'SupplierId': form.getTextInputValue('SupplierId'),
            'Description': form.getTextInputValue('Description'),
            'Price': form.getTextInputValue('Price'),
            'Quantity': form.getTextInputValue('Quantity'),
        }
        if (form.validateEmpty('form-control')) {
            if (document.getElementById('ProductId').value > 0) {
                peticion.put('api/ProductAPI/modificar', product, function (data) {
                    if (Number.parseInt(data['data']) > 0) {
                        document.getElementById('btnCloseModal').click();
                        message.success('Se guardo el producto');
                        GetAll(1);
                    } else {
                        message.warning(data['message'])
                    }
                });
            } else {
             ");
            WriteLiteral(@"   peticion.post('api/ProductAPI/insertar', product, function (data) {
                    if (Number.parseInt(data['data']) > 0) {
                        document.getElementById('btnCloseModal').click();
                        message.success('Se guardo el producto');
                        GetAll(1);
                    } else {
                        message.warning(data['message'])
                    }
                });
            }
        }
    })
    function GetRegister(id) {
        peticion.get('api/ProductAPI/obtenerPorId?id=' + id, function (result) {
            if (result['data'] != null) {
                form.setDataForm(result['data'], ['ProductId', 'Name', 'CategoryId', 'SupplierId', 'Description', 'Price','Quantity'])
            } else {
                message.warning(result['message']);
            }
        })
    }
</script>");
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