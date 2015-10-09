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

            int monthlyInvestment = int.Parse(investmentOption.SelectedValue);
            float intrestRate = float.Parse(interestRate.Text.ToString());
            int numberYears = int.Parse(this.numberYears.Text.ToString());
            var i = (intrestRate / 100) / 12;
            var n = numberYears * 12;
            var v = 1 / (1 + i);

            var z = Math.Pow((1 + i), n);
            var w = Math.Pow(v, n);

            var totala = monthlyInvestment * ((1 - w) / i) * (1 + i) * z;
            var totalamt = monthlyInvestment * n;
            var totalint = totala - totalamt;
            output.Text = (totala).ToString("$#.##");
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            interestRate.Text = "";
            numberYears.Text = "";
        }
    }
}