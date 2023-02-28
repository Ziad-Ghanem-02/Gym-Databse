using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   //OD

namespace DBapplication
{
    public class StoredProcedures
    {   //No para
        public static string viewAllHolidays = "viewAllHolidaysProc";
        public static string SelectCompanyCarsInWareHouse = "SelectCompanyCarsInWareHouseProc";
        public static string SelectSellerNames = "SelectSellerNamesproc";
        public static string SelectAllCarsInWareHouse = "SelectAllCarsInWareHouseProc";
        public static string SelectAllCarsInMaintince = "SelectAllCarsInMaintinceProc;";
        public static string SelectMaintainanceCenters = "SelectMaintainanceCentersProc";
        //para
        public static string Rented_Cars_with_SsN = "Rented_Cars_with_SsNProc";
        public static string Bought_Cars_with_SsN="Bought_Cars_with_SsNProc";
        public static string update_buyer_price_rent = "update_buyer_price_rentProc";
        public static string Sold_car_with_Sellerssn="Sold_car_with_SellerssnProc";
        public static string  ALL_From_Sellerssn = "ALL_From_SellerssnProc";

    }
}
