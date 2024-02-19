using System;
using System.Collections.Generic;

namespace CoreModelss
{
    public partial class TblPharmEasyUser
    {
        public TblPharmEasyUser()
        {
            TblPharmEasyUserCarts = new HashSet<TblPharmEasyUserCart>();
            TblPharmEasyUserOrders = new HashSet<TblPharmEasyUserOrder>();
        }

        public int UserId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Username { get; set; } = null!;
        public long? Phonenumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ICollection<TblPharmEasyUserCart> TblPharmEasyUserCarts { get; set; }
        public virtual ICollection<TblPharmEasyUserOrder> TblPharmEasyUserOrders { get; set; }
    }
}
