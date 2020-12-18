using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class ShopKeeper 
    {
        public IMobileShop iphone;
        public IMobileShop samsung;
        public IMobileShop huawei;

        public ShopKeeper()
        {
            iphone = new Iphone();
            samsung = new Samsung();
            huawei = new Huawei();
        }

        public void IphoneSale()
        {
            iphone.ModelNo();
            iphone.Price();
        }

        public void SamsungSale()
        {
            samsung.ModelNo();
            samsung.Price();
        }

        public void HuaweiSale()
        {
            huawei.ModelNo();
            huawei.Price();
        }


    }
}
