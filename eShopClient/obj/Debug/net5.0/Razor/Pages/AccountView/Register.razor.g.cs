#pragma checksum "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9c2120e6514a57a63310c2036728623a6804e99"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopClient.Pages.AccountView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using eShopShare.Models.ApiModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "signup_area section--padding2");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, @"<div class=""quangcao""><div class=""d-none d-md-block""><div class=""optad_728x90_0""><div id=""oa-360-1659637915146_w7bnjkia0"" style=""visibility: hidden;""><div id=""oa-360-1659637915146_qfj5fjbez"" style=""position: relative; display: inline-block;""><div id=""oa-360-1659637915147_uyweezo38"" style=""display: none;""></div><div id=""oa-360-1659637915148_2mor0dqg1"" style=""display: none;""></div></div></div></div></div>
            <div class=""d-block d-md-none""><div class=""optad_300x250_0""><div id=""oa-360-1659637915152_xpmzffvan"" style=""visibility: hidden;""><div id=""oa-360-1659637915152_aspsfobjg"" style=""position: relative; display: inline-block;""><div id=""oa-360-1659637915153_ihsf1l4pn"" style=""display: none;""></div><div id=""oa-360-1659637915153_naako8utj"" style=""display: none;""></div></div></div></div></div></div>
        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-6 offset-lg-3");
            __builder.AddAttribute(9, "style", "margin-bottom: 30px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "id", "formdangky");
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 36 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                         DangKy

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                                        model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "<input name=\"__RequestVerificationToken\" type=\"hidden\" value=\"qz6umO-dQ8azUpImx38JmfUWj0vqVvltUjQ1MtOtV5ut4_yjDClrRGK4WxRCZc6AALSsi6ib9QPpXi_G50Aqd1cOBNG4wCjT4hPjZzq8K9o1\">\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "cardify signup_form");
                __builder2.AddMarkupContent(18, "<div class=\"login--header\"><h3>Tạo tài khoản</h3>\r\n                            <p>\r\n                                Hãy điền đầy đủ thông tin bên dưới để đăng ký tài khoản thành viên\r\n                            </p></div>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "login--form");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label for=\"hotentxt\">Tên của bạn:</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "hotentxt");
                __builder2.AddAttribute(30, "type", "text");
                __builder2.AddAttribute(31, "class", "text_field");
                __builder2.AddAttribute(32, "placeholder", "Nhập tên của bạn");
                __builder2.AddAttribute(33, "name", "hoten");
                __builder2.AddAttribute(34, "autocomplete", "off");
                __builder2.AddAttribute(35, "required", "");
                __builder2.AddAttribute(36, "autofocus", "");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                        model.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Name = __value, model.Name))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                                ");
                __builder2.AddMarkupContent(41, "<span id=\"hotenerrortxt\" class=\"text-danger\" style=\"color: red; float: right; margin-bottom: 20px; display: block;\">Tối thiểu 3 ký tự và tối đa 50 ký tự</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label for=\"emailtxt\">Tên đăng nhập:</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "id", "username");
                __builder2.AddAttribute(48, "type", "text");
                __builder2.AddAttribute(49, "class", "text_field");
                __builder2.AddAttribute(50, "placeholder", "Nhập tên đăng nhập");
                __builder2.AddAttribute(51, "name", "username");
                __builder2.AddAttribute(52, "autocomplete", "off");
                __builder2.AddAttribute(53, "required", "");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                        model.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.UserName = __value, model.UserName))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                                ");
                __builder2.OpenElement(58, "span");
                __builder2.AddAttribute(59, "id", "emailerrortxt");
                __builder2.AddAttribute(60, "class", "text-danger");
                __builder2.AddAttribute(61, "style", "color: red; float: right; margin-bottom: 20px; display: none;");
                __Blazor.eShopClient.Pages.AccountView.Register.TypeInference.CreateValidationMessage_0(__builder2, 62, 63, 
#nullable restore
#line 58 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                            ()=>model.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "<label for=\"emailtxt\">Email:</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(68);
                __builder2.AddAttribute(69, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 63 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                     ()=>CheckExist(model.Email)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "id", "emailtxt");
                __builder2.AddAttribute(71, "type", "email");
                __builder2.AddAttribute(72, "class", "text_field");
                __builder2.AddAttribute(73, "placeholder", "Nhập email của bạn");
                __builder2.AddAttribute(74, "name", "email");
                __builder2.AddAttribute(75, "autocomplete", "off");
                __builder2.AddAttribute(76, "required", "");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                                                               model.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Email = __value, model.Email))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n                                ");
                __builder2.OpenElement(81, "span");
                __builder2.AddAttribute(82, "id", "emailerrortxt");
                __builder2.AddAttribute(83, "class", "text-danger");
                __builder2.AddAttribute(84, "style", "color: red; float: right; margin-bottom: 20px; display: none;");
                __Blazor.eShopClient.Pages.AccountView.Register.TypeInference.CreateValidationMessage_1(__builder2, 85, 86, 
#nullable restore
#line 65 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                            ()=>model.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                            ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, "<label for=\"passtxt\">Mật khẩu:</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(91);
                __builder2.AddAttribute(92, "id", "passtxt");
                __builder2.AddAttribute(93, "type", "password");
                __builder2.AddAttribute(94, "class", "text_field");
                __builder2.AddAttribute(95, "placeholder", "Nhập mật khẩu");
                __builder2.AddAttribute(96, "name", "pass");
                __builder2.AddAttribute(97, "required", "");
                __builder2.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 75 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                        model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                __builder2.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n                                ");
                __builder2.OpenElement(102, "span");
                __builder2.AddAttribute(103, "id", "passerrortxt");
                __builder2.AddAttribute(104, "class", "text-danger");
                __builder2.AddAttribute(105, "style", "color:red; float:right; margin-bottom:20px");
                __Blazor.eShopClient.Pages.AccountView.Register.TypeInference.CreateValidationMessage_2(__builder2, 106, 107, 
#nullable restore
#line 77 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                            ()=>model.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n                            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-group");
                __builder2.AddMarkupContent(111, "<label for=\"repasstxt\">Nhập lại mật khẩu</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(112);
                __builder2.AddAttribute(113, "id", "repasstxt");
                __builder2.AddAttribute(114, "type", "password");
                __builder2.AddAttribute(115, "class", "text_field");
                __builder2.AddAttribute(116, "placeholder", "Nhập lại mật khẩu");
                __builder2.AddAttribute(117, "name", "repass");
                __builder2.AddAttribute(118, "required", "");
                __builder2.AddAttribute(119, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 82 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                        model.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ConfirmPassword = __value, model.ConfirmPassword))));
                __builder2.AddAttribute(121, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(122, "\r\n                                ");
                __builder2.OpenElement(123, "span");
                __builder2.AddAttribute(124, "id", "repasserrortxt");
                __builder2.AddAttribute(125, "class", "text-danger");
                __builder2.AddAttribute(126, "style", "color: red; float: right; margin-bottom: 20px; display: none;");
                __Blazor.eShopClient.Pages.AccountView.Register.TypeInference.CreateValidationMessage_3(__builder2, 127, 128, 
#nullable restore
#line 84 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                            ()=>model.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 87 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                             if (isError)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(129, "span");
                __builder2.AddAttribute(130, "id", "repasserrortxt");
                __builder2.AddAttribute(131, "class", "text-danger");
                __builder2.AddAttribute(132, "style", "color: red; float: right; margin-bottom: 20px; display: none;");
                __builder2.AddContent(133, 
#nullable restore
#line 90 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                     error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 92 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(134, "<button class=\"btn btn--xs register_btn\" type=\"submit\">Đăng ký</button>\r\n                            ");
                __builder2.AddMarkupContent(135, "<div class=\"login_assist\"><p>\r\n                                    Bạn đã có tài khoản thành viên ?\r\n                                    <a href=\"/login\">Đăng nhập</a></p></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n        ");
            __builder.AddMarkupContent(137, @"<div class=""quangcao""><div class=""d-none d-md-block""><div class=""optad_728x90_1""><div id=""oa-360-1659637915149_osw72g8w5"" style=""visibility: hidden;""><div id=""oa-360-1659637915149_oppbgt8t6"" style=""position: relative; display: inline-block;""><div id=""oa-360-1659637915150_6vbeiqd6o"" style=""display: none;""></div><div id=""oa-360-1659637915150_orodsyxjr"" style=""display: none;""></div></div></div></div></div>
            <div class=""d-block d-md-none""><div class=""optad_300x250_1""><div id=""oa-360-1659637915154_zkea44pin"" style=""visibility: hidden;""><div id=""oa-360-1659637915154_drfz60cdf"" style=""position: relative; display: inline-block;""><div id=""oa-360-1659637915154_2ztj02aq4"" style=""display: none;""></div><div id=""oa-360-1659637915154_dk82ncw64"" style=""display: none;""></div></div></div></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
       
    public RegisterClientRequest model { get; set; } = new RegisterClientRequest();

    private string error;

    private bool isError;

    private string apiUrl;

    private string temp;

    //public string confirmPassword = "";
    protected override async Task OnInitializedAsync()
    {
        isError = false;
        error = "";
        apiUrl = config.GetSection("API")["APIUrl"].ToString();
        Console.WriteLine("dsfadsf");
    }
    public async void DangKy()
    {

        RegisterClientRequest clientRequest = new RegisterClientRequest() { Name = model.Name, UserName = model.UserName, Email = model.Email, Password = model.Password, ConfirmPassword = model.ConfirmPassword };

        StringContent content = new StringContent(JsonConvert.SerializeObject(clientRequest), System.Text.Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _register.Register(content);

        switch (response.StatusCode)
        {
            case HttpStatusCode.BadRequest:
                string apiResponse = await response.Content.ReadAsStringAsync();
                var problems = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiProblemModel>(apiResponse);
                foreach (var item in problems.Message.ToList())
                {
                    _toastSvc.ShowError(item.ToString());
                }
                break;
            case HttpStatusCode.InternalServerError:
                break;

            default:
                //string apiResponse = await response.Content.ReadAsStringAsync();
                _toastSvc.ShowSuccess($"Đăng ký thành công {clientRequest.Email}.\n" +
                    $"Hãy chờ link xác nhận email");
                //ViewWebClientLogin viewWebLogin = new ViewWebClientLogin() { UserName = clientRequest.UserName, Password = clientRequest.Password };
                //HttpResponseMessage loginResponse = await _register.Login(viewWebLogin);
                //if (loginResponse.StatusCode != HttpStatusCode.OK)
                //{
                //    //error += (error == "" ? "" : "<br/>") + " - Lỗi khi gọi API.";
                //}
                //else
                //{
                //    string apiResponse2 = await loginResponse.Content.ReadAsStringAsync();
                //    var viewToken = Newtonsoft.Json.JsonConvert.DeserializeObject<ViewToken>(apiResponse2);
                //    sessionStorage.SetItem("KhachhangId", viewToken.KhachhangId);
                //    sessionStorage.SetItem("Email", viewToken.Email);
                //    sessionStorage.SetItem("UserName", viewToken.UserName);
                //    sessionStorage.SetItem("Name", viewToken.Name);
                //    sessionStorage.SetItem("AccessToken", viewToken.Token);
                //    sessionStorage.SetItem("NgayThamGia", viewToken.NgayThamGia);
                //    await auth.GetAuthenticationStateAsync();
                //    _toastSvc.ShowSuccess($"Đăng nhập thành công {viewToken.Email}");
                //    _OCSvc.Invoke();
                //    await Task.Delay(1000);
                //    NavigationManager.NavigateTo("/", true);
                //}
                //await Task.Delay(1000);
                //NavigationManager.NavigateTo("/", true);
                break;
        }


    }
    public async void CheckExist(string content)
    {
        var res = await _register.GetExist(content);
        if (res.StatusCode == HttpStatusCode.OK)
        {
            _toastSvc.ShowError("Hợp lệ");

        }
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("setTitle", "Đăng ký | Web bán thức ăn"); ;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginAndRegisterService _register { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetNameOrEmailSvc _getEmailOrUserName { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.eShopClient.Pages.AccountView.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591