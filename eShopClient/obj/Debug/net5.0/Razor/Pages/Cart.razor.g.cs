#pragma checksum "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78fe19f3e9712ee8f5864affb46e8568a63eeebd"
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
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
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
#nullable restore
#line 14 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
 if (giohang.cartItems != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "h-100");
            __builder.AddAttribute(2, "style", "background-color: #eee;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container h-100 py-5");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row d-flex justify-content-center align-items-center h-100");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-10");
            __builder.AddContent(9, 
#nullable restore
#line 29 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                     giohang.TongTien

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 30 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                     foreach (var item in giohang.cartItems)
                    {


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
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card rounded-3 mb-4");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body p-4");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row d-flex justify-content-between align-items-center");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-2 col-lg-2 col-xl-2");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 46 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                   temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "style", "width:150px;height:150px");
            __builder.AddAttribute(21, "class", "img-fluid rounded-3");
            __builder.AddAttribute(22, "alt", 
#nullable restore
#line 47 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                                       item.product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-md-3 col-lg-3 col-xl-3");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "class", "lead fw-normal mb-2");
            __builder.AddContent(28, 
#nullable restore
#line 50 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                                        item.product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-md-3 col-lg-3 col-xl-2 d-flex");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "id", "txtQuantity_" + (
#nullable restore
#line 59 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                                item.product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "min", "0");
            __builder.AddAttribute(35, "name", "quantity");
            __builder.AddAttribute(36, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 59 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                                                                                   (e) => item.quantity = int.Parse(e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 60 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                  () => UpdateCart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "value", 
#nullable restore
#line 60 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                                                  item.quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "type", "number");
            __builder.AddAttribute(40, "class", "form-control form-control-sm");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-md-3 col-lg-2 col-xl-2 offset-lg-1");
            __builder.OpenElement(44, "h5");
            __builder.AddAttribute(45, "class", "mb-0");
            __builder.AddContent(46, 
#nullable restore
#line 69 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                          item.Sotien

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-md-1 col-lg-1 col-xl-1 text-end");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "class", "text-danger");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                                         () => DeleteCart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "<i class=\"fas fa-trash fa-lg\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card rounded-3 mb-4");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "card-body p-4");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row d-flex justify-content-between align-items-center");
            __builder.AddMarkupContent(60, "<div class=\"col-md-6 col-lg-6 col-xl-6\"></div>\r\n                                    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-md-6 col-lg-6 col-xl-6 text-end");
            __builder.AddMarkupContent(63, "\r\n                                        Tổng tiền: ");
            __builder.AddContent(64, 
#nullable restore
#line 86 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
                                                    giohang.TongTien

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(65, " đồng\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(67);
            __builder.AddAttribute(68, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(69, "<div class=\"card\"><div class=\"card-body\"><a href=\"/checkout\" class=\"btn btn-warning btn-block btn-lg\">Proceed to Pay</a></div></div>");
            }
            ));
            __builder.AddAttribute(70, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(71, "<div class=\"card\"><div class=\"card-body\"><a href=\"/login\" class=\"btn btn-warning btn-block btn-lg\">Đăng nhập để đặt hàng</a></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 113 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<p>Giỏ hàng trống</p>");
#nullable restore
#line 117 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Pages\Cart.razor"
       
    private string emailAddress;
    public PostCartModel giohang;
    private double total = 0;
    protected string imgUrl = "";
    protected string temp = "";

    protected override void OnInitialized()
    {
        //emailAddress = sessionStorage.GetItem<string>("Email");//get key cart
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
        if (giohang.cartItems != null)
        {
            _OCSvc.Invoke();
            return true;
        }
        _OCSvc.Invoke();
        return false;
    }

    private void UpdateCart(CartItem item)
    {
        if(item.product.Quantity < item.quantity)
        {
            item.quantity = item.product.Quantity;
            _toastSvc.ShowWarning($"Sản phẩm {item.product.Name} chỉ còn x{item.product.Quantity}");
        }
        item.Sotien = (double)(item.quantity * item.product.Gia);
        giohang.TongTien = Tinhtien(giohang.cartItems);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
        _OCSvc.Invoke();
    }

    private void DeleteCart(CartItem item)
    {
        giohang.cartItems.Remove(item);
        if(giohang.cartItems.Count == 1)
        {
            giohang.cartItems.Clear();
            giohang.cartItems = null;
            sessionStorage.RemoveItem("cart");
        }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
    }
}
#pragma warning restore 1591
