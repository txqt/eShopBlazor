#pragma checksum "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40ac0502cf0604746cae6adfd40ac36e575e0ba4"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopClient.Pages
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
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/History")]
    public partial class History : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Danh sách đơn hàng</h1>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, @"<thead><tr><th>
                Khách hàng
            </th>
            <th>
                Ngày đặt
            </th>
            <th>
                Tổng tiền
            </th>
            <th>
                Trạng thái
            </th>
            <th>
                Ghi chú
            </th>
            <th></th></tr></thead>
    ");
            __builder.OpenElement(4, "tbody");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 38 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                 if (donHangs == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<eShopClient.Shared.LoadingIndicator>(7);
                __builder2.CloseComponent();
#nullable restore
#line 41 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                     foreach (var item in donHangs)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "tr");
                __builder2.OpenElement(9, "td");
                __builder2.AddContent(10, 
#nullable restore
#line 48 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                                 item.KhachHang.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n                            ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 51 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                                 item.NgayDat.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                            ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 54 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                                 item.Tongtien

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                            ");
                __builder2.OpenElement(18, "td");
                __builder2.OpenComponent<eShopClient.Shared.Label.OrderStatusLabel>(19);
                __builder2.AddAttribute(20, "trangThaiDonHang", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DonHang.TrangThaiDonHang>(
#nullable restore
#line 57 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                                                                                              item.TrangthaiDonhang

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 62 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                                 item.Ghichu

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "td");
                __builder2.OpenElement(26, "a");
                __builder2.AddAttribute(27, "href", "/history-detail/" + (
#nullable restore
#line 66 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                                                          item.DonHangID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(28, "Chi tiết");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 69 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
                     
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(29, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(30, "<tr><td><a href=\"/login\">Đăng nhập để xem lịch sử</a></td></tr>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.AddMarkupContent(32, "<div><a href=\"/\">Trang chủ</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\History.razor"
       
    private string emailAddress;
    List<DonHang> donHangs = null;
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    //public PostCartModel giohang;
    //private double total = 0;
    //protected string imgUrl = "";
    //protected string temp = "";
    public async Task<string> GetTypeOfClaim(string type)
    {
        var user = (await AuthStat).User;
        return user.Claims.FirstOrDefault(x => x.Type == type).Value.ToString();
    }
    protected override async Task OnInitializedAsync()
    {
        var user = (await AuthStat).User;
        donHangs = new List<DonHang>();
        string khachhangId = await GetTypeOfClaim("khachid");
        var accessToken = await GetTypeOfClaim("token");
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        //imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        Console.WriteLine(accessToken);
        using (var client = new HttpClient())
        {

            //Dictionary<string, string> query = new Dictionary<string, string>();
            client.DefaultRequestHeaders.Authorization = new
                    System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);

            using (var response = await client.GetAsync("DonHang/" + khachhangId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                donHangs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DonHang>>(apiResponse);
                donHangs = donHangs.OrderByDescending(x => x.NgayDat).ToList();
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
