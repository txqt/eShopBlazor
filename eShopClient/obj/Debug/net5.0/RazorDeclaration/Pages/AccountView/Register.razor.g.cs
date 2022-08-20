// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
