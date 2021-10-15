using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_3
{
    public partial class Reflect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int M = 663166; //題目提供數值
            int M2 = 0; //初始值
            int sum = 0; //辯識第幾位數
            int rem = 0; //計算出來餘數

            M2 = M;

            while (M != 0)
            {
                sum = M % 10;
                rem = rem * 10 + sum;
                M = M / 10;
            }
            if (M == rem)
                Response.Write("True");
            else
                Response.Write("Flase");
        }
    }
}