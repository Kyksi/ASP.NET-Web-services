using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_pages
{
    public partial class web_service_try : System.Web.UI.Page
    {
        String price;
        PlatinumPrice.GetPlatinumPriceSoapClient PlatinumClient = new PlatinumPrice.GetPlatinumPriceSoapClient();
        GoldPrice.GetGoldPriceSoapClient GoldClient = new GoldPrice.GetGoldPriceSoapClient();
        SilverPrice.GetSilverPriceSoapClient SilverClient = new SilverPrice.GetSilverPriceSoapClient();
        PalladiumPrice.GetPalladiumPriceSoapClient PalladiumClient = new PalladiumPrice.GetPalladiumPriceSoapClient();
        RhodiumPrice.GetRhodiumPriceSoapClient RhodiumClient = new RhodiumPrice.GetRhodiumPriceSoapClient();
        OilPrice.GetCrudeOilPriceSoapClient OilClient = new OilPrice.GetCrudeOilPriceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1_SelectedIndexChanged(sender, e);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedIndex)
            {
                case (0):
                    GoldPrice.ArrayOfString array = GoldClient.GetCurrentGoldPrice("nazar.semenyuck@yandex.ua", "Nazar123456");
                    Label1.Text = "$ " + array[0] + " for Oz";
                    Label2.Text = "Current price of gold is: ";
                    break;
                case (1):
                    price = SilverClient.GetCurrentSilverPrice("nazar.semenyuck@yandex.ua", "Nazar123456");
                    Label1.Text = "$ " + price + " for Oz";
                    Label2.Text = "Current price of silver is: ";
                    break;
                case (2):
                    price = PlatinumClient.GetCurrentPlatinumPrice("nazar.semenyuck@yandex.ua", "Nazar123456");
                    Label1.Text = "$ " + price + " for Oz";
                    Label2.Text = "Current price of platinum is: ";
                    break;
                case (3):
                    price = PalladiumClient.GetCurrentPalladiumPrice("nazar.semenyuck@yandex.ua", "Nazar123456");
                    Label1.Text = "$ " + price + " for Oz";
                    Label2.Text = "Current price of palladium is: ";
                    break;
                case (4):
                    price = RhodiumClient.GetCurrentRhodiumPrice("nazar.semenyuck@yandex.ua", "Nazar123456");
                    Label1.Text = "$ " + price + " for Oz";
                    Label2.Text = "Current price of rhodium is: ";
                    break;
                case (5):
                    price = OilClient.GetOilPrice("nazar.semenyuck@yandex.ua", "Nazar123456");
                    Label1.Text = "$ " + price + " for Barrel";
                    Label2.Text = "Current price of crude oil is: ";
                    break;
            }
        }
    }
}