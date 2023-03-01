using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jel14t_mission09.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalEntries { get; set; }
        public int EntriesPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) Math.Ceiling(((double)TotalEntries / EntriesPerPage));
    }
}
