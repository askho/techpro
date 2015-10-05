using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            investmentOption.Items.Add("150");
            investmentOption.Items.Add("120");
            investmentOption.Items.Add("100");
        }

        protected void calc_Click(object sender, EventArgs e)
        {
            float monthlyInvestment = float.Parse(investmentOption.SelectedValue);
            float annualInterest = float.Parse(interestRate.Text);
            int numYears = int.Parse(numberYears.Text);
            int result = 0;
        }
    }
}