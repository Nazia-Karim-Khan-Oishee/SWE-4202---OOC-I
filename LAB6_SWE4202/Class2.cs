using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_SWE4202
{
    internal class Order
    {
            public string OrderId;
            public User user;
            public string Status = "Pending";

            public void setStatus(string status)
            {
                this.Status = status;
            }
             public void setuser(User Dummy_user)
             {
                    this.user = Dummy_user;
             }
        public void setOrderId(string orderid)
            {
                this.OrderId = orderid;
            }
            public void setUser(User dummy_user)
            {
                this.user = dummy_user;
            }
            
            public string listShow()
            {
                return ("Shirt : " + this.user.userShirt + "\t" + "Pant : " + this.user.userPant + "\t" + "Suit : " + this.user.userSuit + "\t" + "Bed Sheet : " + this.user.userBedSheet);
            }


        }
    }

