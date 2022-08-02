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
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\Index.razor"
       
    private string name;
    public List<MonAn> monAns = null;
    protected string imgUrl = "";
    protected string temp = "";
    public string CARTKEY = "cart";
    //protected void OnInitialized()
    protected override async Task OnInitializedAsync()
    {
        //sessionStorage.SetItem("name", "John Smith");
        //var name = sessionStorage.GetItem<string>("name");

        //monAns = _monAnService.GetMonAnAll();
        Console.WriteLine("email: " + sessionStorage.GetItem<string>("Email"));
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
    public MonAn CheckFoodExist(int id)
    {
        return monAns.Where(u => u.Id == id).FirstOrDefault();
    }
    public void SetItemToCart(PostCartModel giohang)
    {
        sessionStorage.SetItem(CARTKEY, JsonConvert.SerializeObject(giohang));
    }
    public string GetItemInCart()
    {
        return sessionStorage.GetItem<string>(CARTKEY);
    }
    private void AddCart(int id)
    {
        //_cartSvc.AddToCart(id, monAns);
        //var cart = HttpContext.Session.GetString("cart");//get key cart
        var cart = GetItemInCart();//get key cart
        var monAn = CheckFoodExist(id);
        if (cart == null)
        {


            List<CartItem> listCart = new List<CartItem>()
            {
                    new CartItem
                    {
                        product = monAn,
                        quantity = 1,
                        Sotien= (double)monAn.Gia
                    }
            };

            PostCartModel giohang = new PostCartModel()
                {
                    cartItems = listCart,
                    TongTien = Tinhtien(listCart)
                };

            SetItemToCart(giohang);
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
        }
        else
        {
            PostCartModel giohang = JsonConvert.DeserializeObject<PostCartModel>(cart);
            //List <ViewCart> dataCart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
            bool check = true;
            for (int i = 0; i < giohang.cartItems.Count; i++)
            {
                if (giohang.cartItems[i].product.Id == id)
                {
                    giohang.cartItems[i].quantity++;
                    giohang.cartItems[i].Sotien = (double)monAn.Gia * giohang.cartItems[i].quantity;
                    check = false;
                    break;
                }
            }

            if (check)
            {
                //var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
                giohang.cartItems.Add(new CartItem
                    {
                        product = monAn,
                        quantity = 1,
                        Sotien = (double)monAn.Gia * 1
                    });
            }
            giohang.TongTien = Tinhtien(giohang.cartItems);

            SetItemToCart(giohang);
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
        }
        _toastSvc.ShowSuccess($"Thêm thành công");
        _OCSvc.Invoke();
        this.StateHasChanged();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
