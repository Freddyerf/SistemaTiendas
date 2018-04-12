using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models.ManageViewModels
{
    public class CashierViewModel
    {
        private DateTime _dateTime = DateTime.Now;

        public DateTime dateTime { get => _dateTime; set => _dateTime = value; }
    }
}
