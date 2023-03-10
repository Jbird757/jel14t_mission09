using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jel14t_mission09.Models
{
    public interface ICheckoutRepository
    {
        IQueryable<Checkout> Checkout { get; }

        void SaveCheckout(Checkout checkout);
    }
}
