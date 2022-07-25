#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2799a47ffccfcf8525ce1433cb2585149abb4563"
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
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .list-product {
        margin: auto;
        display: flex;
        flex-wrap: wrap;
    }

    .product {
        margin-top: 10px;
        margin-right: 10px;
        width: 205px;
    }

    .img {
        width: 150px;
        display: block;
        margin: auto;
    }

    .title {
        color: #0e0e0e;
        display: block;
        font-size: 15px;
        font-weight: bold;
        text-align: center;
        height: 60px;
    }

    .field-price {
        font-size: 24px;
        color: #d50000;
        margin-bottom: 15px;
        font-weight: 700;
        text-align: center;
    }

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
    }

    .addProduct {
        margin-left: 2px;
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "list-product row");
#nullable restore
#line 66 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
     foreach (var item in monAns)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "product");
#nullable restore
#line 70 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
              
                if (item.Photos.Any())
                {
                    temp = imgUrl + item.Photos.FirstOrDefault().FileName;
                }
                else
                {
                    temp = imgUrl + "/nophoto.png";
                }
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 80 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
                       temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "class", "img-responsive");
            __builder.AddAttribute(10, "style", "width:200px;height:200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "title");
#nullable restore
#line 81 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
__builder.AddContent(14, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "field-price");
#nullable restore
#line 82 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
__builder.AddContent(18, item.Gia);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "addProduct text-center");
            __builder.AddAttribute(23, "onmouseup", "addCart(" + (
#nullable restore
#line 83 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
                                                                                     item.Id

#line default
#line hidden
#nullable disable
            ) + ");");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
                                                                                                          () => AddCart(item.Id,0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Add order ");
            __builder.OpenElement(26, "img");
            __builder.AddAttribute(27, "id", "imgBusy_" + (
#nullable restore
#line 83 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
                                                                                                                                                                item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "src", "images/busy.gif");
            __builder.AddAttribute(29, "style", "display:none");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 89 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
        
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
       
    private string name;
    public List<MonAn> monAns;
    protected string imgUrl="";
    protected string temp = "";
    //protected void OnInitialized()
    protected override async Task OnInitializedAsync()
    {
        //sessionStorage.SetItem("name", "John Smith");
        //var name = sessionStorage.GetItem<string>("name");

        //monAns = _monAnService.GetMonAnAll();

        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();

        monAns = new List<MonAn>();
        using (var client = new HttpClient())
        {
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("MonAn"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                monAns = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MonAn>>(apiResponse);
            }
        }
    }
    
    private void AddCart(int productid, int quantity)
    {
        //if (quantity <= 0)
        //    {
        //        quantity = 1;
        //    }
            
        //    var product = monAns
        //                    .Where(p => p.Id == productid && p.TrangThai == true)
                           
        //                    .FirstOrDefault();
        //    if (product == null)
        //        return;
        //    if (quantity > product.Quantity)
        //    {
        //        quantity = product.Quantity;
        //    }

        //        // Xử lý đưa vào Cart ...
        //    //var cart = _cartService.GetCartItems();
        //    var cartitem = cart.Find(p => p.product.Id == productid);
        //    if (cartitem != null)
        //    {
                
        //        cartitem.quantity += quantity;
        //        if (cartitem.quantity > cartitem.product.Quantity)
        //        {
        //            cartitem.quantity = cartitem.product.Quantity;
        //        }
        //    }
        //    else
        //    {
        //        //  Thêm mới
        //        cart.Add(new CartItem() { quantity = quantity, product = product });
        //    }
            //product.Quantity -= quantity;
            //_context.Update(product);
            //_context.SaveChanges();
            // Lưu cart vào Session
            //_cartService.SaveCartSession(cart);
        //var cart = HttpContext.Session.GetString("cart");//get key cart
        //var cart = sessionStorage.GetItem<string>("cart");//get key cart
        //if (cart == null)
        //{

        //    var monAn = monAns.Where(u=>u.Id==id).FirstOrDefault();
        //    List<CartItem> listCart = new List<CartItem>()
        //        {
        //            new CartItem
        //            {
        //                product = monAn,
        //                quantity = 1,
        //                Sotien= monAn.Gia
        //            }
        //    };

        //    ASM.Share.Models.Cart giohang = new ASM.Share.Models.Cart() {
        //        ListViewCart = listCart, Tongtien = Tinhtien(listCart) };

        //    sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
        //    //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
        //}
        //else
        //{
        //    var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();

        //    ASM.Share.Models.Cart giohang = JsonConvert.DeserializeObject<ASM.Share.Models.Cart>(cart);
        //    //List <ViewCart> dataCart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
        //    bool check = true;
        //    for (int i = 0; i < giohang.ListViewCart.Count; i++)
        //    {
        //        if (giohang.ListViewCart[i].MonAn.MonAnID == id)
        //        {
        //            giohang.ListViewCart[i].Quantity++;
        //            giohang.ListViewCart[i].Sotien = monAn.Gia * giohang.ListViewCart[i].Quantity;
        //            check = false;
        //        }
        //    }

        //    if (check)
        //    {
        //        //var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
        //        giohang.ListViewCart.Add(new CartItem
        //        {
        //            MonAn = monAn,
        //            Quantity = 1,
        //            Sotien= monAn.Gia*1
        //        });
        //    }
        //    giohang.Tongtien = Tinhtien(giohang.ListViewCart);
        //    sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));

            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
        //}
    }

    //private double Tinhtien(List<CartItem> listCart)
    //{
    //    double tongtien = 0;
    //    if (listCart != null)
    //    {
    //        for (int i = 0; i < listCart.Count; i++)
    //        {
    //            tongtien += listCart[i].Sotien;
    //        }
    //    }
    //    return tongtien;
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
