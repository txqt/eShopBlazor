#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c464279471f5e7b4392ac31fe8c0645ec02bd564"
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
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/history-detail/{id}")]
    public partial class HistoryDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\">Chi tiết đơn hàng</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<hr>\r\n    ");
            __builder.OpenElement(3, "dl");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<dt class=\"col-sm-2\">Ngày đặt</dt>\r\n        ");
            __builder.OpenElement(6, "dd");
            __builder.AddAttribute(7, "class", "col-sm-10");
            __builder.AddContent(8, 
#nullable restore
#line 22 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
             model.NgayDat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<dt class=\"col-sm-2\">Tổng tiền</dt>\r\n        ");
            __builder.OpenElement(11, "dd");
            __builder.AddAttribute(12, "class", "col-sm-10");
            __builder.AddContent(13, 
#nullable restore
#line 26 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
             model.Tongtien

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, " đồng\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<dt class=\"col-sm-2\">Trạng thái</dt>\r\n        ");
            __builder.OpenElement(17, "dd");
            __builder.AddAttribute(18, "class", "col-sm-10");
            __builder.OpenComponent<eShopClient.Shared.Label.OrderStatusLabel>(19);
            __builder.AddAttribute(20, "trangThaiDonHang", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DonHang.TrangThaiDonHang>(
#nullable restore
#line 30 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                                                                          model.TrangthaiDonhang

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.AddMarkupContent(22, "<dt class=\"col-sm-2\">Ghi chú</dt>\r\n        ");
            __builder.OpenElement(23, "dd");
            __builder.AddAttribute(24, "class", "col-sm-10");
            __builder.AddContent(25, 
#nullable restore
#line 35 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
             model.Ghichu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table");
            __builder.AddMarkupContent(29, @"<thead><tr><th>
                    Món ăn
                </th>
                <th>
                    Hình
                </th>
                <th>
                    Số lượng
                </th>
                <th>
                    Thành tiền
                </th></tr></thead>
        ");
            __builder.OpenElement(30, "tbody");
#nullable restore
#line 58 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
             foreach (var item in listDonhang)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                 if (item != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 65 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                             item.MonAn.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
#nullable restore
#line 68 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                             try
                            {
                                if (item.MonAn.Photos.Any())
                                {
                                    temp = imgUrl + item.MonAn.Photos.FirstOrDefault().FileName;
                                }
                                else
                                {
                                    temp = imgUrl + "/nophoto.png";
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "img");
            __builder.AddAttribute(37, "src", 
#nullable restore
#line 78 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                                           temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "style", "width:150px");
            __builder.CloseElement();
#nullable restore
#line 79 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                            }
                            catch
                            {

                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 87 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                             item.SoLuong

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 90 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                             item.ThanhTien

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 93 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.AddMarkupContent(46, "<div><a class=\"btn btn-info\" href=\"/\">Trang chủ</a> |\r\n    <a class=\"btn\" href=\"/History\">Danh sách</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\HistoryDetail.razor"
       
    [Parameter]
    public string id { get; set; }
    private string Tieude = "";
    protected string temp = "";
    protected string imgUrl = "";
    public DonHang model;
    public List<DonHangChiTiet> listDonhang = new List<DonHangChiTiet>();
    protected override async Task OnParametersSetAsync()
    //protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            NavigationManager.NavigateTo("/History", true); ;
        }
        else
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            imgUrl = config.GetSection("API")["ImgUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            model = new DonHang();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await client.GetAsync("DonHangChiTiet/" + id))
                {
                    //string apiResponse = await response.Content.ReadAsStringAsync();
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    model = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DonHang>>(apiResponse)[0];
                    listDonhang = model.donHangChiTiets;
                }
            }
        }
    }
    [Inject] IJSRuntime JSRuntime { get; set; }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("setTitle", $"Chi tiết đơn hàng | Web bán thức ăn"); ;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
