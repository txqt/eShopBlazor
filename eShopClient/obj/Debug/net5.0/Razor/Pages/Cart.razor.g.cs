#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe4da505e92a50cd6163413cb7b52c733e190da"
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
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .viewProduct, .addProduct {
        border: 0;
        font-weight: 700;
        padding: 9px 5px;
        background: #ffd800;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        border-radius: 5px;
        display: block;
        width: 186px;
        margin: 0 auto;
        color: #0e0e0e;
        text-align: center;
    }
</style>");
#nullable restore
#line 30 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
 if (giohang.cartItems != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "shopping_cart_area mt-60");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "action", "#");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-12");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "table_desc");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "cart_page table-responsive");
            __builder.OpenElement(15, "table");
            __builder.AddMarkupContent(16, @"<thead><tr><th class=""product_thumb"">Image</th>
                                            <th class=""product_name"">Product</th>
                                            <th class=""product-price"">Price</th>
                                            <th class=""product_quantity"">Quantity</th>
                                            <th class=""product_total"">Total</th>
                                            <th class=""product_remove"">Remove</th></tr></thead>
                                    ");
            __builder.OpenElement(17, "tbody");
#nullable restore
#line 51 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                         foreach (var item in giohang.cartItems)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
#nullable restore
#line 54 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                                  
                                                    if (item.product.Photos.Any())
                                                    {
                                                        temp = imgUrl + item.product.Photos.FirstOrDefault().FileName;
                                                    }
                                                    else
                                                    {
                                                        temp = imgUrl + "/nophoto.png";
                                                    }
                                                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "class", "product_thumb");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "#");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 64 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                                                                                 temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                                ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "class", "product_name");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", "#");
#nullable restore
#line 65 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
__builder.AddContent(31, item.product.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                                ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "class", "product-price");
#nullable restore
#line 66 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
__builder.AddContent(35, item.product.Gia);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                                ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "class", "product_quantity");
            __builder.AddMarkupContent(39, "<label>Quantity</label> ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "number");
            __builder.AddAttribute(42, "id", "txtQuantity_" + (
#nullable restore
#line 68 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                                                                                                  item.product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 69 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                                                                     (e) => item.quantity = int.Parse(e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 70 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                                                                      () => UpdateCart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "value", 
#nullable restore
#line 70 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                                                                                                      item.quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                                ");
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "class", "product_total");
#nullable restore
#line 72 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
__builder.AddContent(49, item.Sotien);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                                ");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "class", "product_remove");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "href", "javascript:return false;");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                                                                                 () => DeleteCart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onmouseup", "delCart(" + (
#nullable restore
#line 75 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                                                   item.product.Id

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddMarkupContent(57, "<i class=\"ion-android-close\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "coupon_area");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-lg-6 col-md-6");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "coupon_code right");
            __builder.AddMarkupContent(67, "<h3>Cart Totals</h3>\r\n\r\n                                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "cart_subtotal");
            __builder.AddMarkupContent(70, "<p>Total</p>\r\n                                    ");
            __builder.OpenElement(71, "p");
            __builder.AddAttribute(72, "class", "cart_amount");
#nullable restore
#line 100 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
__builder.AddContent(73, giohang.TongTien);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(75);
            __builder.AddAttribute(76, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 104 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                         if (IsHaveItemInCart() == true)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(77, "<div class=\"checkout_btn\"><a class=\"btn\" href=\"/checkout\">Đặt hàng</a></div>");
#nullable restore
#line 109 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"

                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(78, "<div class=\"checkout_btn\"><a class=\"btn\" href=\"/\">Cần ít nhất một sản phẩm để đặt hàng</a></div>");
#nullable restore
#line 116 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
                                        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(79, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(80, "<div class=\"checkout_btn\"><a href=\"/login\">Bạn cần đăng nhập để đặt hàng</a></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 134 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "<p>Giỏ hàng trống</p>");
#nullable restore
#line 138 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "<p></p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 204 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Cart.razor"
       
    private string emailAddress;
    public PostCartModel giohang;
    private double total = 0;
    protected string imgUrl = "";
    protected string temp = "";

    protected override void OnInitialized()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");//get key cart
        var cart = sessionStorage.GetItem<string>("cart");//get key cart

        if (cart == null)
        {
            giohang = new PostCartModel();
        }
        else
        {
            giohang = JsonConvert.DeserializeObject<PostCartModel>(cart);
        }

        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        _OCSvc.OnChange += StateHasChanged;
    }
    public void Dispose()
    {
        _OCSvc.OnChange -= StateHasChanged;
    }
    public bool IsHaveItemInCart()
    {
        if (sessionStorage.GetItem<string>("cart") != null || sessionStorage.GetItem<string>("cart") == "")
        {
            return true;
        }
        return false;
    }
    private void UpdateCart(CartItem item)
    {
        item.Sotien = (double)(item.quantity * item.product.Gia);
        giohang.TongTien = Tinhtien(giohang.cartItems);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
    }

    private void DeleteCart(CartItem item)
    {
        giohang.cartItems.Remove(item);
        giohang.TongTien = Tinhtien(giohang.cartItems);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
        _OCSvc.Invoke();
    }



    private double Tinhtien(List<CartItem> listCart)
    {
        double tongtien = 0;
        if (listCart != null)
        {
            for (int i = 0; i < listCart.Count; i++)
            {
                tongtien += listCart[i].Sotien;
            }
        }
        return tongtien;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
    }
}
#pragma warning restore 1591
