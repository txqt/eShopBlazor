// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace eShopClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using eShopClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using eShopClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using eShopClient.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Login.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Login.razor"
       

    private string error;

    public static string Email = "";
    public static string password = "";


    protected override void OnInitialized()
    {
         
        if (sessionStorage.GetItem<string>("Email") != null)
        {
            _toastSvc.ShowWarning("Bạn đã đăng nhập rồi !");
            NavigationManager.NavigateTo("/");
        }
       
    }

    private string Encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }

    public void Enter(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            if (password != "")
            {
                CheckLogin();
            }
        }
    }

    public async Task CheckLogin()
    {
        error = "";
        if (Email == "")
        {
            error = " - Bạn cần nhập email.";
        }
        if (password == "")
        {
            error += (error == "" ? "" : "<br/>") + " - Bạn cần nhập password.";
        }
        if (error == "")
        {

            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            using (var client = new HttpClient())
            {
                ViewWebLogin viewWebLogin = new ViewWebLogin() { Email = Email, Password = password };
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                //client.DefaultRequestHeaders.Authorization =new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(viewWebLogin), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl + "Token", content);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    error += (error == "" ? "" : "<br/>") + " - Lỗi khi gọi API.";
                    //xu ly loi
                    //return Content(response.ToString());
                }
                else
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    var viewToken = Newtonsoft.Json.JsonConvert.DeserializeObject<ViewToken>(apiResponse);

                    var accessToken = viewToken.Token;
                    sessionStorage.SetItem("KhachhangId", viewToken.KhachhangId);
                    sessionStorage.SetItem("Email", viewToken.Email);
                    sessionStorage.SetItem("UserName", Email);
                    //Console.WriteLine("email: " + viewToken.Email);
                    sessionStorage.SetItem("AccessToken", accessToken);
                    await auth.GetAuthenticationStateAsync();
                    //await JSRuntime.InvokeAsync<object>("refreshMenu", new {email= email});
                    //await JSRuntime.InvokeAsync<object>("CalledJSFunctionWithParameter", "Jignesh Trivedi");
                    _toastSvc.ShowSuccess($"Đăng nhập thành công {viewToken.Email}\n{viewToken.KhachhangId}");
                    _OCSvc.Invoke();
                    NavigationManager.NavigateTo("/");
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
