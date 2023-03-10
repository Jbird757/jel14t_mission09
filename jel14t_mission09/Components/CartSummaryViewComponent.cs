using jel14t_mission09.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jel14t_mission09.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket cart;
        public CartSummaryViewComponent(Basket cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
