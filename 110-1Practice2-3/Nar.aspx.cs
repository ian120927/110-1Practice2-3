using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_3
{
    public partial class Nar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        int num = 153;
        int num_ori, rem, sum = 0; //num原始數字,rem=取餘數,sum=除完各各餘數平方相加起來
        num_ori = 0;          
        num = num_ori;

          while(num_ori != 0)
            {
                rem = num_ori % 10; //每一個位數去除10所得的餘數
                sum = sum + (rem * rem * rem); //餘數次方出來結果
                sum = sum / 10;//原始數字除以10
            }
        
        if (sum == num_ori)
            {
                Response.Write("ture");
            }
            else
            {
                Response.Write("Flase");
            }
        }
    }
}