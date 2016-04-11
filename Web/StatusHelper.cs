using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hm.Web
{
    public class StatusHelper
    {
        public static string Node_Type_News = "1";
        public static string Node_Type_Page = "2";
        public static string Node_Type_Product = "3";
        public static string Node_Type_Media = "4";
        public static string[] Node_Type_Arr = { "", "新闻", "单页", "产品", "综合" };

        public static int Product_Status_Normal = 1;
        public static int Product_Status_None = 2;
        public static string[] Product_Status_Arr = { "", "正常", "无货" }; 
    }
}