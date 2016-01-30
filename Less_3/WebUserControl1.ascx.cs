using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Less_4
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton2.Checked = false;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton1.Checked = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!RadioButton1.Checked && !RadioButton2.Checked)
            {
                Label1.Text = "Вы не выбрали пол";
            }

            if (RadioButton1.Checked)
            {
                //RadioButton2.Checked = false;
                Label1.Text = "Вы выбрали мужской пол";
            }

            if (RadioButton2.Checked)
            {
                //RadioButton1.Checked = false;
                Label1.Text = "Вы выбрали женский пол";
            }
        }


    }
}