#pragma checksum "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12089c0eb76b72b463081f71d618139677882d73"
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
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/food-detail/{id}")]
    public partial class FoodDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "product_details mt-60 mb-60");
            __builder.AddAttribute(2, "style", "    padding-top: 120px;\r\n    padding-bottom: 120px;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-6 col-md-6");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "product-details-tab");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "id", "img-1");
            __builder.AddAttribute(13, "class", "zoomWrapper single-zoom");
#nullable restore
#line 18 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                         try
                        {
                            if (monan.Photos.Any())
                            {
                                temp = imgUrl + monan.Photos.FirstOrDefault().FileName;
                            }
                            else
                            {
                                temp = imgUrl + "/nophoto.png";
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "#");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "id", "zoom1");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 29 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                      temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "data-zoom-image", 
#nullable restore
#line 29 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                                              temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "alt", "big-1");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                        }
                        catch
                        {

                        }
                        

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
#nullable restore
#line 44 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                             try
                            {
                                if (monan.Photos.Any())
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                     foreach (var item in monan.Photos)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-4");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "#");
            __builder.AddAttribute(30, "class", "elevatezoom-gallery active");
            __builder.AddAttribute(31, "data-update");
            __builder.AddAttribute(32, "data-image", "assets/img/product/details-2.jpg");
            __builder.AddAttribute(33, "data-zoom-image", "assets/img/product/details-2.jpg");
            __builder.OpenElement(34, "img");
            __builder.AddAttribute(35, "src", (
#nullable restore
#line 52 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                           imgUrl

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 52 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                                   item.FileName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "alt", "zo-th-1");
            __builder.AddAttribute(37, "style", "width:100px;height:100px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                                                               
                                }
                                else
                                {
                                    temp = imgUrl + "/nophoto.png";
                                }

                            }
                            catch
                            {

                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-lg-6 col-md-6 ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "product_d_right");
            __builder.OpenElement(43, "div");
            __builder.OpenElement(44, "h1");
            __builder.AddContent(45, 
#nullable restore
#line 81 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                             monan.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, " (<i class=\"fas fa-eye pcolor\"></i> ");
            __builder.AddContent(47, 
#nullable restore
#line 81 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                                            monan.Views

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(48, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "price_box");
            __builder.OpenElement(52, "span");
            __builder.AddAttribute(53, "class", "current_price");
            __builder.AddMarkupContent(54, "Giá ");
            __builder.AddContent(55, 
#nullable restore
#line 94 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                             monan.Gia.ToString("n0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, " đồng");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "product_meta");
            __builder.OpenComponent<eShopClient.Shared.Label.FoodCategoryLabel>(60);
            __builder.AddAttribute(61, "PhanLoai", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MonAn.PhanLoai>(
#nullable restore
#line 99 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                                                   monan.phanLoai

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        <br>\r\n\r\n                        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "product_variant quantity");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "input-group mb-3");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "number");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "placeholder", "Thêm số lượng");
            __builder.AddAttribute(71, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 129 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                                                                                (e) => quantity = int.Parse(e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 130 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                                                  () => InputQuantity(quantity)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "value", "quantity");
            __builder.AddAttribute(74, "aria-label", "Recipient\'s username");
            __builder.AddAttribute(75, "style", "height:44px");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                ");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "class", "btn btn-secondary");
            __builder.AddAttribute(79, "style", "width: 99px;\r\n      height: 46px;\r\n      float: right;");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 133 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
                               () => AddCart(monan.Id,quantity)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(81, "\r\n                                    Add To Cart\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 163 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\FoodDetail.razor"
       
    public List<MonAn> monAns = null;
    public MonAn monan = null;
    protected string imgUrl = "";
    protected string temp = "";
    public int quantity = 1;
    [Parameter]
    public string id { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        monan = new MonAn();
        monan = await _productSvc.Get("MonAn/" + id);
        temp = imgUrl + "nophoto.png";
    }
    private void AddCart(int id, int soluong)
    {
        if (monan.Quantity < soluong)
        {
            quantity = monan.Quantity;
            _toastSvc.ShowWarning($"Sản phẩm {monan.Name} chỉ còn x{monan.Quantity}");
        }
        _cartSvc.AddMultiple(id, quantity, monan);
        _toastSvc.ShowSuccess($"Thêm thành công");
        _OCSvc.Invoke();
        this.StateHasChanged();
    }
    public void InputQuantity(int soluong)
    {
        if (monan.Quantity < soluong)
        {
            quantity = monan.Quantity;
            _toastSvc.ShowWarning($"Sản phẩm {monan.Name} chỉ còn x{monan.Quantity}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService _cartSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICallProductSvc _productSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591
