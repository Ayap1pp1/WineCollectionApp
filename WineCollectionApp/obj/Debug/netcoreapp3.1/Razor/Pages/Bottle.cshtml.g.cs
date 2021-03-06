#pragma checksum "C:\Users\ayaka\source\repos\WineCollectionApp\WineCollectionApp\Pages\Bottle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20f12e9f5a4ce638e56e5dec6f306d06b539f92d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WineCollectionApp.Pages.Pages_Bottle), @"mvc.1.0.razor-page", @"/Pages/Bottle.cshtml")]
namespace WineCollectionApp.Pages
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
#line 1 "C:\Users\ayaka\source\repos\WineCollectionApp\WineCollectionApp\Pages\_ViewImports.cshtml"
using WineCollectionApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20f12e9f5a4ce638e56e5dec6f306d06b539f92d", @"/Pages/Bottle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"255158d03bf91117789a4ab8d448bbcf3982ee88", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Bottle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bottleForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ayaka\source\repos\WineCollectionApp\WineCollectionApp\Pages\Bottle.cshtml"
  
    ViewData["Title"] = "Add Bottle";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\ayaka\source\repos\WineCollectionApp\WineCollectionApp\Pages\Bottle.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <p>Use this page to add a new bottle.</p>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20f12e9f5a4ce638e56e5dec6f306d06b539f92d3937", async() => {
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""form-group col-md-2"">
                <label for=""inputProdId"">Producer Id</label>
                <input type=""number"" class=""form-control"" id=""inputProdId"" aria-describedby=""prodIdHelp"" placeholder=""Enter Producer Id"">
                <small id=""prodIdHelp"" class=""form-text text-muted"">For instance: ""1""</small>
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputName"">Name</label>
                <input type=""text"" class=""form-control"" id=""inputName"" aria-describedby=""nameHelp"" placeholder=""Enter name"">
                <small id=""nameHelp"" class=""form-text text-muted"">For instance: ""Camp""</small>
            </div>
            <div class=""form-group col-md-4"">
                <label for=""inputYear"">Year</label>
                <input type=""number"" class=""form-control"" id=""inputYear"" aria-describedby=""yearHelp"" placeholder=""Enter year"">
                <small id=""yearHelp"" class=""form-text tex");
                WriteLiteral(@"t-muted"">For instance: ""2018""</small>
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputSize"">Size</label>
                <input type=""number"" class=""form-control"" id=""inputSize"" aria-describedby=""sizeHelp"" placeholder=""Enter size"">
                <small id=""sizeHelp"" class=""form-text text-muted"">Size in ml. For instance: ""750""</small>
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputStyle"">Style</label>
                <input type=""text"" class=""form-control"" id=""inputStyle"" aria-describedby=""styleHelp"" placeholder=""Enter style"">
                <small id=""styleHelp"" class=""form-text text-muted"">For instance: ""Syrah""</small>
            </div>
        </div>

        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputTaste"">Taste</label>
                <input type=""text"" class=""form-control"" id=""i");
                WriteLiteral(@"nputTaste"" aria-describedby=""tasteHelp"" placeholder=""Enter taste"">
                <small id=""tasteHelp"" class=""form-text text-muted"">For instance: ""Fruktig smak med inslag av fat, björnbär, kryddor, plommon och choklad.""</small>
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputDesc"">Description</label>
                <input type=""text"" class=""form-control"" id=""inputDesc"" aria-describedby=""descHelp"" placeholder=""Enter description"">
                <small id=""descHelp"" class=""form-text text-muted"">For instance: ""Mörk, blåröd färg.""</small>
            </div>
        </div>

        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputFood"">Food pairing</label>
                <input type=""text"" class=""form-control"" id=""inputFood"" aria-describedby=""foodHelp"" placeholder=""Enter food pairing"">
                <small id=""foodHelp"" class=""form-text text-muted"">For instance: ""Serveras vid 16-18°C till gri");
                WriteLiteral(@"llade rätter av lamm- eller nötkött.""</small>
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputUrl"">Link</label>
                <input type=""url"" class=""form-control"" id=""inputUrl"" aria-describedby=""urlHelp"" placeholder=""Enter URL"">
                <small id=""urlHelp"" class=""form-text text-muted"">For instance: ""https://www.systembolaget.se/produkt/vin/camp-214001/""</small>
            </div>
        </div>
        <button type=""button"" onclick=""addBottle()"" class=""btn btn-primary"">Add Bottle</button>
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
            WriteLiteral(@"

    <div aria-live=""polite"" aria-atomic=""true"" class=""d-flex justify-content-center align-items-center"" style=""min-height: 200px;"">
        <div class=""toast"" id=""bottleToast"" role=""alert"" aria-live=""assertive"" aria-atomic=""true"" data-delay=""5000"">
            <div class=""toast-header"">
                <strong class=""mr-auto"">Success!</strong>
                <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""toast-body"">
                Bottle added succesfully!
            </div>
        </div>
    </div>
</div>

<script>
    function addBottle() {
        var bottle = {
            ""producerId"": document.getElementById(""inputProdId"").value,
            ""name"": document.getElementById(""inputName"").value,
            ""year"": document.getElementById(""inputYear"").value,
            ""size"": document.getElementById(""inputSize");
            WriteLiteral(@""").value,
            ""style"": document.getElementById(""inputStyle"").value,
            ""taste"": document.getElementById(""inputTaste"").value,
            ""description"": document.getElementById(""inputDesc"").value,
            ""foodPairing"": document.getElementById(""inputFood"").value,
            ""link"": document.getElementById(""inputUrl"").value
        }

        $.ajax({
            type: ""POST"",
            url: 'api/producer/AddBottle',
            contentType: ""application/json"",
            data: JSON.stringify(bottle),
            success: function (data) {
                console.log(data);
                document.getElementById(""bottleForm"").reset();
                $('#bottleToast').toast('show');
            },
            error: function (data) {
                console.log('Error:', data);
            }
        });
    };
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WineCollectionApp.Pages.BottleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WineCollectionApp.Pages.BottleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WineCollectionApp.Pages.BottleModel>)PageContext?.ViewData;
        public WineCollectionApp.Pages.BottleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
