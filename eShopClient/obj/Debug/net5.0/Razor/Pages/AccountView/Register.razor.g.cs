#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7021c8051b8369992de4521f035e604cc4261d04"
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
#line 1 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
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
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-6 offset-lg-3");
            __builder.AddAttribute(8, "style", "margin-bottom: 30px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "id", "formdangky");
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 25 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                         DangKy

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                                        model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "<input name=\"__RequestVerificationToken\" type=\"hidden\" value=\"qz6umO-dQ8azUpImx38JmfUWj0vqVvltUjQ1MtOtV5ut4_yjDClrRGK4WxRCZc6AALSsi6ib9QPpXi_G50Aqd1cOBNG4wCjT4hPjZzq8K9o1\">\r\n                    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "cardify signup_form");
                __builder2.AddMarkupContent(17, "<div class=\"login--header\"><h3>Tạo tài khoản</h3>\r\n                            <p>\r\n                                Hãy điền đầy đủ thông tin bên dưới để đăng ký tài khoản thành viên\r\n                            </p></div>\r\n                        ");
                __builder2.OpenElement(18, "span");
                __builder2.AddAttribute(19, "id", "emailerrortxt");
                __builder2.AddAttribute(20, "class", "text-danger");
                __builder2.AddAttribute(21, "style", "color: red; float: right; margin-bottom: 20px;");
                __Blazor.eShopClient.Pages.AccountView.Register.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 36 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                    ()=>model.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(25);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(27);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "login--form");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"hotentxt\">Tên của bạn:</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "hotentxt");
                __builder2.AddAttribute(36, "type", "text");
                __builder2.AddAttribute(37, "class", "text_field");
                __builder2.AddAttribute(38, "placeholder", "Nhập tên của bạn");
                __builder2.AddAttribute(39, "name", "hoten");
                __builder2.AddAttribute(40, "autocomplete", "off");
                __builder2.AddAttribute(41, "required", "");
                __builder2.AddAttribute(42, "autofocus", "");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                        model.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Name = __value, model.Name))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.AddMarkupContent(47, "<span id=\"hotenerrortxt\" class=\"text-danger\" style=\"color: red; float: right; margin-bottom: 20px; display: block;\">Tối thiểu 3 ký tự và tối đa 50 ký tự</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "<label for=\"emailtxt\">Tên đăng nhập:</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "id", "username");
                __builder2.AddAttribute(54, "type", "text");
                __builder2.AddAttribute(55, "class", "text_field");
                __builder2.AddAttribute(56, "placeholder", "Nhập tên đăng nhập");
                __builder2.AddAttribute(57, "name", "username");
                __builder2.AddAttribute(58, "autocomplete", "off");
                __builder2.AddAttribute(59, "required", "");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                        model.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.UserName = __value, model.UserName))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                                ");
                __builder2.OpenElement(64, "span");
                __builder2.AddAttribute(65, "id", "emailerrortxt");
                __builder2.AddAttribute(66, "class", "text-danger");
                __builder2.AddAttribute(67, "style", "color: red; float: right; margin-bottom: 20px;");
                __Blazor.eShopClient.Pages.AccountView.Register.TypeInference.CreateValidationMessage_1(__builder2, 68, 69, 
#nullable restore
#line 50 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                            ()=>model.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                            ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group");
                __builder2.AddMarkupContent(73, "<label for=\"emailtxt\">Email:</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(74);
                __builder2.AddAttribute(75, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 55 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                     ()=>CheckExist(model.Email)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "id", "emailtxt");
                __builder2.AddAttribute(77, "type", "email");
                __builder2.AddAttribute(78, "class", "text_field");
                __builder2.AddAttribute(79, "placeholder", "Nhập email của bạn");
                __builder2.AddAttribute(80, "name", "email");
                __builder2.AddAttribute(81, "autocomplete", "off");
                __builder2.AddAttribute(82, "required", "");
                __builder2.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                                                               model.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Email = __value, model.Email))));
                __builder2.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                                ");
                __builder2.OpenElement(87, "span");
                __builder2.AddAttribute(88, "id", "emailerrortxt");
                __builder2.AddAttribute(89, "class", "text-danger");
                __builder2.AddAttribute(90, "style", "color: red; float: right; margin-bottom: 20px; ");
                __Blazor.eShopClient.Pages.AccountView.Register.TypeInference.CreateValidationMessage_2(__builder2, 91, 92, 
#nullable restore
#line 57 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                            ()=>model.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group");
                __builder2.AddMarkupContent(96, "<label for=\"passtxt\">Mật khẩu:</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(97);
                __builder2.AddAttribute(98, "id", "passtxt");
                __builder2.AddAttribute(99, "type", "password");
                __builder2.AddAttribute(100, "class", "text_field");
                __builder2.AddAttribute(101, "placeholder", "Nhập mật khẩu");
                __builder2.AddAttribute(102, "name", "pass");
                __builder2.AddAttribute(103, "required", "");
                __builder2.AddAttribute(104, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                        model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                __builder2.AddAttribute(106, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n                                ");
                __builder2.OpenElement(108, "span");
                __builder2.AddAttribute(109, "id", "passerrortxt");
                __builder2.AddAttribute(110, "class", "text-danger");
                __builder2.AddAttribute(111, "style", "color:red; float:right; margin-bottom:20px");
                __Blazor.eShopClient.Pages.AccountView.Register.TypeInference.CreateValidationMessage_3(__builder2, 112, 113, 
#nullable restore
#line 69 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                            ()=>model.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                            ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "form-group");
                __builder2.AddMarkupContent(117, "<label for=\"repasstxt\">Nhập lại mật khẩu</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(118);
                __builder2.AddAttribute(119, "id", "repasstxt");
                __builder2.AddAttribute(120, "type", "password");
                __builder2.AddAttribute(121, "class", "text_field");
                __builder2.AddAttribute(122, "placeholder", "Nhập lại mật khẩu");
                __builder2.AddAttribute(123, "name", "repass");
                __builder2.AddAttribute(124, "required", "");
                __builder2.AddAttribute(125, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 74 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                        model.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(126, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ConfirmPassword = __value, model.ConfirmPassword))));
                __builder2.AddAttribute(127, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n                                ");
                __builder2.OpenElement(129, "span");
                __builder2.AddAttribute(130, "id", "repasserrortxt");
                __builder2.AddAttribute(131, "class", "text-danger");
                __builder2.AddAttribute(132, "style", "color: red; float: right; margin-bottom: 20px;");
                __Blazor.eShopClient.Pages.AccountView.Register.TypeInference.CreateValidationMessage_4(__builder2, 133, 134, 
#nullable restore
#line 76 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                            ()=>model.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n                            ");
                __builder2.OpenElement(136, "button");
                __builder2.AddAttribute(137, "class", "btn btn--xs register_btn");
                __builder2.AddAttribute(138, "type", "submit");
                __builder2.AddAttribute(139, "disabled", 
#nullable restore
#line 79 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                                                                             isLoading

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 80 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                 if (isLoading)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(140, "<span class=\"spinner-border spinner-border-sm\" role=\"status\" aria-hidden=\"true\"></span>");
#nullable restore
#line 83 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(141, "                                Đăng ký\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n                            ");
                __builder2.AddMarkupContent(143, "<div class=\"login_assist\"><p>\r\n                                    Bạn đã có tài khoản thành viên ?\r\n                                    <a href=\"/login\">Đăng nhập</a></p></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\AccountView\Register.razor"
       
    public RegisterClientRequest model { get; set; } = new RegisterClientRequest();

    private string error;

    private bool isError;

    private string apiUrl;

    private string temp;

    private bool isLoading = false;

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
        isLoading = true;
        Console.WriteLine("isloading: " + isLoading);
        RegisterClientRequest clientRequest = new RegisterClientRequest() { Name = model.Name, UserName = model.UserName, Email = model.Email, Password = model.Password, ConfirmPassword = model.ConfirmPassword };

        StringContent content = new StringContent(JsonConvert.SerializeObject(clientRequest), System.Text.Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _register.Register(content);

        string apiResponse = await response.Content.ReadAsStringAsync();

        var problems = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiProblemModel>(apiResponse);

        switch (response.StatusCode)
        {
            case HttpStatusCode.BadRequest:

                foreach (var item in problems.Message.ToList())
                {
                    _toastSvc.ShowError(item.ToString());
                }
                break;
            case HttpStatusCode.InternalServerError:
                break;

            default:
                //string apiResponse = await response.Content.ReadAsStringAsync();
                if (problems.IsSuccess)
                {
                    _toastSvc.ShowSuccess($"Đăng ký thành công {clientRequest.Email}.\n" +
                    $"Check email để xác nhận");
                }

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

        isLoading = false;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _register { get; set; }
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
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591