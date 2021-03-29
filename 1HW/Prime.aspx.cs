using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = 2;
            int cout = 100;
            Response.Write("判段是否為質數:" + num + "</br>");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cout++;
                }
            }
            if(cout == 2)
            {
                Response.Write("Y");
            }
            else
            {
                Response.Write("N");
            }
        }
    }
}