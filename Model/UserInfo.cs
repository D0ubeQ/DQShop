using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserInfo
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string UserType { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
    }
    public class Goods
    {
        public Guid Id { get; set; }
        public string GoodsName { get; set; }
        public string  MerId { get; set; }
        public string Descript { get; set; }
        public string GoodsPic { get; set; }
        public string  Price { get; set; }
        public string  Stock { get; set; }

    }
    public class Order
    {

    }
}
