using System;
using System.Collections.Generic;

namespace multifabriken_jajo21
{
    abstract class Order
    {
        protected List<string> orders;
        public Order() {
            orders = new List<string>();
        }
        public abstract void GetOrderString();
    }
}