using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspModulo2
{
    public partial class wFormSalario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton(object sender, EventArgs e)
        {
            txbOutro.Visible = false;

            if (radioDesconto.SelectedIndex == 3)
            {
                txbOutro.Visible = true;
            }
        }
    }
}