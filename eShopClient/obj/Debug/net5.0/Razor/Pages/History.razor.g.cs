#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1efb6ee0d70eb5792a7bdbe2d5351a1094501c5"
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
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
using System.Text.Json.Serialization;

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
#nullable restore
#line 35 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
         if(donHangs.Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<tr><td>\r\n                    Lịch sử trống!\r\n                </td></tr>");
#nullable restore
#line 42 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
        }
        else
        {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
         foreach (var item in donHangs)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 50 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
__builder.AddContent(8, emailAddress);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 53 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
__builder.AddContent(11, item.NgayDat.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 56 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
__builder.AddContent(14, item.Tongtien);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 59 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
__builder.AddContent(17, item.TrangthaiDonhang);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 62 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
__builder.AddContent(20, item.Ghichu);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/Detail/" + (
#nullable restore
#line 66 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
                                      item.DonHangID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "Chi tiết");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
         
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.AddMarkupContent(27, "<div><a href=\"/\">Trang chủ</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\History.razor"
       
    private string emailAddress;
    List<DonHang> donHangs = null;

    //public PostCartModel giohang;
    //private double total = 0;
    //protected string imgUrl = "";
    //protected string temp = "";

    protected override async Task OnInitializedAsync()
    {
        donHangs  = new List<DonHang>();
        emailAddress = sessionStorage.GetItem<string>("Email");//get key cart
        string khachhangId = sessionStorage.GetItem<string>("KhachhangId");//get key cart
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        Console.WriteLine("api url:"+apiUrl);
        //imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        
        using (var client = new HttpClient())
        {

            Console.WriteLine(accessToken);
            //Dictionary<string, string> query = new Dictionary<string, string>();
            client.DefaultRequestHeaders.Authorization = new
                    System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);

            using (var response = await client.GetAsync("DonHang/?id=" + khachhangId))
            {
                Console.WriteLine("khach id: "+khachhangId);
                string apiResponse = await response.Content.ReadAsStringAsync();
                donHangs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DonHang>>(apiResponse);
                Console.WriteLine("apiRes: "+apiResponse);
                Console.WriteLine("ddonhang: "+donHangs);

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
