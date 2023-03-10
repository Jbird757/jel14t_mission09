using jel14t_mission09.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jel14t_mission09.Controllers
{
    public class CheckoutController : Controller
    {
        private ICheckoutRepository repo { get; set; }
        private Basket basket { get; set; }
        public CheckoutController (ICheckoutRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Checkout());
        }

        [HttpPost]
        public IActionResult Checkout(Checkout transaction)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Your Cart is Empty");
            }

            if (ModelState.IsValid)
            {
                transaction.Lines = basket.Items.ToArray();
                repo.SaveCheckout(transaction);
                basket.ClearBasket();

                return RedirectToPage("/CheckoutComplete");
            }

            return View();

        }
    }
}
