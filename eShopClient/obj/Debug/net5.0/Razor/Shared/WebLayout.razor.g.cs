#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Shared\WebLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc460b49dcb6ef27d4aa8bbe1bb6a3a5c34e7d67"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopClient.Shared
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
    public partial class WebLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"off_canvars_overlay\" b-54ym07er1g></div>\r\n    ");
            __builder.AddMarkupContent(1, "<div class=\"Offcanvas_menu\" b-54ym07er1g><div class=\"container\" b-54ym07er1g><div class=\"row\" b-54ym07er1g><div class=\"col-12\" b-54ym07er1g><div class=\"canvas_open\" b-54ym07er1g><a href=\"javascript:void(0)\" b-54ym07er1g><i class=\"ion-navicon\" b-54ym07er1g></i></a></div>\r\n                    <div class=\"Offcanvas_menu_wrapper\" b-54ym07er1g><div class=\"canvas_close\" b-54ym07er1g><a href=\"javascript:void(0)\" b-54ym07er1g><i class=\"ion-android-close\" b-54ym07er1g></i></a></div>\r\n                        <div class=\"support_info\" b-54ym07er1g><p b-54ym07er1g>Any Enquiry: <a href=\"tel:\" b-54ym07er1g>+56985475235</a></p></div>\r\n                        <div class=\"top_right text-right\" b-54ym07er1g><ul b-54ym07er1g><li b-54ym07er1g><a href=\"my-account.html\" b-54ym07er1g> My Account </a></li> \r\n                               <li b-54ym07er1g><a href=\"checkout.html\" b-54ym07er1g> Checkout </a></li></ul></div> \r\n                        <div class=\"search_container\" b-54ym07er1g><form action=\"#\" b-54ym07er1g><div class=\"search_box\" b-54ym07er1g><input placeholder=\"Search product...\" type=\"text\" b-54ym07er1g>\r\n                                    <button type=\"submit\" b-54ym07er1g>Search</button></div></form></div> \r\n                        \r\n                        <div class=\"middel_right_info\" b-54ym07er1g><div class=\"header_wishlist\" b-54ym07er1g><a href=\"wishlist.html\" b-54ym07er1g><img src=\"assets/img/user.png\" alt b-54ym07er1g></a></div>\r\n                            <div class=\"mini_cart_wrapper\" b-54ym07er1g><a href=\"javascript:void(0)\" b-54ym07er1g><img src=\"assets/img/shopping-bag.png\" alt b-54ym07er1g></a>\r\n                                <span class=\"cart_quantity\" b-54ym07er1g>2</span>\r\n                                \r\n                                 <div class=\"mini_cart\" b-54ym07er1g><div class=\"cart_item\" b-54ym07er1g><div class=\"cart_img\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><img src=\"assets/img/s-product/product.jpg\" alt b-54ym07er1g></a></div>\r\n                                        <div class=\"cart_info\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>Sit voluptatem rhoncus sem lectus</a>\r\n                                            <p b-54ym07er1g>Qty: 1 X <span b-54ym07er1g> $60.00 </span></p></div>\r\n                                        <div class=\"cart_remove\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"ion-android-close\" b-54ym07er1g></i></a></div></div>\r\n                                    <div class=\"cart_item\" b-54ym07er1g><div class=\"cart_img\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><img src=\"assets/img/s-product/product2.jpg\" alt b-54ym07er1g></a></div>\r\n                                        <div class=\"cart_info\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>Natus erro at congue massa commodo</a>\r\n                                            <p b-54ym07er1g>Qty: 1 X <span b-54ym07er1g> $60.00 </span></p></div>\r\n                                        <div class=\"cart_remove\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"ion-android-close\" b-54ym07er1g></i></a></div></div>\r\n                                    <div class=\"mini_cart_table\" b-54ym07er1g><div class=\"cart_total\" b-54ym07er1g><span b-54ym07er1g>Sub total:</span>\r\n                                            <span class=\"price\" b-54ym07er1g>$138.00</span></div>\r\n                                        <div class=\"cart_total mt-10\" b-54ym07er1g><span b-54ym07er1g>total:</span>\r\n                                            <span class=\"price\" b-54ym07er1g>$138.00</span></div></div>\r\n\r\n                                    <div class=\"mini_cart_footer\" b-54ym07er1g><div class=\"cart_button\" b-54ym07er1g><a href=\"cart.html\" b-54ym07er1g>View cart</a></div>\r\n                                        <div class=\"cart_button\" b-54ym07er1g><a href=\"checkout.html\" b-54ym07er1g>Checkout</a></div></div></div></div></div>\r\n                        <div id=\"menu\" class=\"text-left \" b-54ym07er1g><ul class=\"offcanvas_main_menu\" b-54ym07er1g><li class=\"menu-item-has-children active\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>Home</a></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"product-details.html\" b-54ym07er1g>product</a></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>pages </a>\r\n                                    <ul class=\"sub-menu\" b-54ym07er1g><li b-54ym07er1g><a href=\"about.html\" b-54ym07er1g>About Us</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"contact.html\" b-54ym07er1g>contact</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"privacy-policy.html\" b-54ym07er1g>privacy policy</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"faq.html\" b-54ym07er1g>Frequently Questions</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"login.html\" b-54ym07er1g>login</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"register.html\" b-54ym07er1g>register</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"forget-password.html\" b-54ym07er1g>Forget Password</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"404.html\" b-54ym07er1g>Error 404</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"cart.html\" b-54ym07er1g>cart</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"tracking.html\" b-54ym07er1g>tracking</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"checkout.html\" b-54ym07er1g>checkout</a></li></ul></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>blog</a>\r\n                                    <ul class=\"sub-menu\" b-54ym07er1g><li b-54ym07er1g><a href=\"blog.html\" b-54ym07er1g>blog</a></li>\r\n                                        <li b-54ym07er1g><a href=\"blog-details.html\" b-54ym07er1g>blog details</a></li></ul></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"login.html\" b-54ym07er1g>my account</a></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"contact.html\" b-54ym07er1g> Contact Us</a></li></ul></div>\r\n\r\n                        <div class=\"Offcanvas_footer\" b-54ym07er1g><span b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-envelope-o\" b-54ym07er1g></i> info@drophunt.com</a></span>\r\n                            <ul b-54ym07er1g><li class=\"facebook\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-facebook\" b-54ym07er1g></i></a></li>\r\n                                <li class=\"twitter\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-twitter\" b-54ym07er1g></i></a></li>\r\n                                <li class=\"pinterest\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-pinterest-p\" b-54ym07er1g></i></a></li>\r\n                                <li class=\"google-plus\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-google-plus\" b-54ym07er1g></i></a></li>\r\n                                <li class=\"linkedin\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-linkedin\" b-54ym07er1g></i></a></li></ul></div></div></div></div></div></div>\r\n    \r\n    \r\n    ");
            __builder.OpenElement(2, "header");
            __builder.AddAttribute(3, "b-54ym07er1g");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main_header");
            __builder.AddAttribute(6, "b-54ym07er1g");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "header_middle");
            __builder.AddAttribute(9, "b-54ym07er1g");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "container");
            __builder.AddAttribute(12, "b-54ym07er1g");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row align-items-center");
            __builder.AddAttribute(15, "b-54ym07er1g");
            __builder.AddMarkupContent(16, "<div class=\"col-lg-3 col-md-6\" b-54ym07er1g><div class=\"logo\" b-54ym07er1g><a href=\"index-2.html\" b-54ym07er1g><img src=\"assets/img/logo/logo.png\" alt b-54ym07er1g></a></div></div>\r\n                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-lg-9 col-md-6");
            __builder.AddAttribute(19, "b-54ym07er1g");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "middel_right");
            __builder.AddAttribute(22, "b-54ym07er1g");
            __builder.AddMarkupContent(23, @"<div class=""search_container"" b-54ym07er1g><form action=""#"" b-54ym07er1g><div class=""search_box"" b-54ym07er1g><input placeholder=""Search product..."" type=""text"" b-54ym07er1g>
                                            <button type=""submit"" b-54ym07er1g>Search</button></div></form></div>
                                
                                ");
            __builder.OpenComponent<eShopClient.Shared.RighSideNav>(24);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            \r\n            \r\n            ");
            __builder.AddMarkupContent(26, @"<div class=""main_menu_area"" b-54ym07er1g><div class=""container"" b-54ym07er1g><div class=""row justify-content-center"" b-54ym07er1g><div class=""col-lg-12 col-md-12"" b-54ym07er1g><div class=""main_menu menu_position"" b-54ym07er1g><nav b-54ym07er1g><ul b-54ym07er1g><li b-54ym07er1g><a href=""/"" b-54ym07er1g>home</a></li></ul></nav></div></div></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    \r\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "container");
            __builder.AddAttribute(30, "b-54ym07er1g");
            __builder.OpenElement(31, "main");
            __builder.AddAttribute(32, "role", "main");
            __builder.AddAttribute(33, "class", "pb-3");
            __builder.AddAttribute(34, "b-54ym07er1g");
#nullable restore
#line 244 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Shared\WebLayout.razor"
__builder.AddContent(35, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n");
            __builder.AddMarkupContent(37, "<footer class=\"footer_widgets\" b-54ym07er1g><div class=\"footer_top\" b-54ym07er1g><div class=\"container\" b-54ym07er1g><div class=\"row\" b-54ym07er1g><div class=\"col-lg-4 col-md-6\" b-54ym07er1g><div class=\"widgets_container contact_us\" b-54ym07er1g><div class=\"footer_logo\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><img src=\"assets/img/logo/logo.png\" alt b-54ym07er1g></a></div>\r\n                        <div class=\"footer_contact\" b-54ym07er1g><p b-54ym07er1g>John draw real poor on call my from. May she mrs furnished discourse extremely. Ask doubt noisy shade guest Lose away off why half led have near bed. At engage simple father of period others except</p>\r\n                            <p b-54ym07er1g>Ask doubt noisy shade guest Lose away off why half led have near bed. At engage simple father of period others except</p></div></div></div>\r\n                <div class=\"col-lg-2 col-md-6 col-sm-6\" b-54ym07er1g><div class=\"widgets_container widget_menu\" b-54ym07er1g><h3 b-54ym07er1g>Information</h3>\r\n                        <div class=\"footer_menu\" b-54ym07er1g><ul b-54ym07er1g><li b-54ym07er1g><a href=\"about.html\" b-54ym07er1g>About Us</a></li>\r\n                                <li b-54ym07er1g><a href=\"blog.html\" b-54ym07er1g>Delivery Information</a></li>\r\n                                <li b-54ym07er1g><a href=\"contact.html\" b-54ym07er1g>Privacy Policy</a></li>\r\n                                <li b-54ym07er1g><a href=\"services.html\" b-54ym07er1g>Terms & Conditions</a></li>\r\n                                <li b-54ym07er1g><a href=\"#\" b-54ym07er1g>Returns</a></li>\r\n                                <li b-54ym07er1g><a href=\"#\" b-54ym07er1g>Gift Certificates</a></li></ul></div></div></div>\r\n                <div class=\"col-lg-2 col-md-6 col-sm-6\" b-54ym07er1g><div class=\"widgets_container widget_menu\" b-54ym07er1g><h3 b-54ym07er1g>My Account</h3>\r\n                        <div class=\"footer_menu\" b-54ym07er1g><ul b-54ym07er1g><li b-54ym07er1g><a href=\"#\" b-54ym07er1g>My Account</a></li>\r\n                                <li b-54ym07er1g><a href=\"#\" b-54ym07er1g>Order History</a></li>\r\n                                <li b-54ym07er1g><a href=\"wishlist.html\" b-54ym07er1g>Wish List</a></li>\r\n                                <li b-54ym07er1g><a href=\"#\" b-54ym07er1g>Newsletter</a></li>\r\n                                <li b-54ym07er1g><a href=\"#\" b-54ym07er1g>Affiliate</a></li>\r\n                                <li b-54ym07er1g><a href=\"faq.html\" b-54ym07er1g>International Orders</a></li></ul></div></div></div>\r\n                <div class=\"col-lg-4 col-md-6\" b-54ym07er1g><div class=\"widgets_container newsletter\" b-54ym07er1g><h3 b-54ym07er1g>Follow Us</h3>\r\n                        <div class=\"footer_social_link\" b-54ym07er1g><ul b-54ym07er1g><li b-54ym07er1g><a class=\"facebook\" href=\"#\" title=\"Facebook\" b-54ym07er1g><i class=\"fa fa-facebook\" b-54ym07er1g></i></a></li>\r\n                                <li b-54ym07er1g><a class=\"twitter\" href=\"#\" title=\"Twitter\" b-54ym07er1g><i class=\"fa fa-twitter\" b-54ym07er1g></i></a></li>\r\n                                <li b-54ym07er1g><a class=\"instagram\" href=\"#\" title=\"instagram\" b-54ym07er1g><i class=\"fa fa-instagram\" b-54ym07er1g></i></a></li>\r\n                                <li b-54ym07er1g><a class=\"linkedin\" href=\"#\" title=\"linkedin\" b-54ym07er1g><i class=\"fa fa-linkedin\" b-54ym07er1g></i></a></li>\r\n                                <li b-54ym07er1g><a class=\"rss\" href=\"#\" title=\"rss\" b-54ym07er1g><i class=\"fa fa-rss\" b-54ym07er1g></i></a></li></ul></div>\r\n                        <div class=\"subscribe_form\" b-54ym07er1g><h3 b-54ym07er1g>Join Our Newsletter Now</h3>\r\n                            <form id=\"mc-form\" class=\"mc-form footer-newsletter\" b-54ym07er1g><input id=\"mc-email\" type=\"email\" autocomplete=\"off\" placeholder=\"Your email address...\" b-54ym07er1g>\r\n                                <button id=\"mc-submit\" b-54ym07er1g>Subscribe!</button></form>\r\n                            \r\n                            <div class=\"mailchimp-alerts text-centre\" b-54ym07er1g><div class=\"mailchimp-submitting\" b-54ym07er1g></div>\r\n                                <div class=\"mailchimp-success\" b-54ym07er1g></div>\r\n                                <div class=\"mailchimp-error\" b-54ym07er1g></div></div></div></div></div></div></div></div>\r\n        <div class=\"footer_bottom\" b-54ym07er1g><div class=\"container\" b-54ym07er1g><div class=\"row align-items-center\" b-54ym07er1g><div class=\"col-lg-6 col-md-6\" b-54ym07er1g><div class=\"copyright_area\" b-54ym07er1g><p b-54ym07er1g><a href=\"templateshub.net\" b-54ym07er1g>Templates Hub</a></p></div></div>\r\n                    <div class=\"col-lg-6 col-md-6\" b-54ym07er1g><div class=\"footer_payment text-right\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><img src=\"assets/img/icon/payment.png\" alt b-54ym07er1g></a></div></div></div></div></div></footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
