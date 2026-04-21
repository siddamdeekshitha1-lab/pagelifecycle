using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pagelifecycle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            label3.Text = "Hi page load event<br>";
            btnsubmit.Visible = false;
        }
        protected void page_preINIT(object sender, EventArgs e)
        {
            lblmsg.Text = "Hi page pre init event<br>";
        }
        protected void page_INIT(object sender, EventArgs e)
        {
            label1.Text = "hii page_INIT event<br>";
        }
        protected void page_INITComplete(object sender, EventArgs e)
        {
            label2.Text = "page init complete <br>";
        }
        protected void page_LoadComplete(object sender, EventArgs e)
        {
            label4.Text = "page load complete<br>";
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (rbtnTelugu.Checked)
            {
                lbltelugu.Text = "selected language is telugu";
            }
            else if (rbtnhindi.Checked)
            {
                lblhindi.Text = "selected language is hindi";
            }
            else if (rbtnEnglish.Checked)
            {
                lblenglish.Text = "selected language is english";
            }
        }

        protected void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (txtusername.Text.Length > 0)
            {
                btnsubmit.Visible = true;
            }
        }

        protected void rbtnTelugu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTelugu.Checked)
            {
                lbltelugu.Text = "selected language is telugu";
            }
        }

        protected void rbtnhindi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnhindi.Checked)
            {
                lblhindi.Text = "selected language is:Hindi";
            }
        }

        protected void rbtnEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEnglish.Checked)
            {
                lblenglish.Text = "selected language is:English";
            }
        }

        protected void chkchess_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchess.Checked)
            {
                lblmesg.Text = "chess is selected";
            }
        }

        protected void chkTennis_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTennis.Checked)
            {
                lbltennis.Text="tennis is selected";
            }
        }

        protected void chkcricket_CheckedChanged(object sender, EventArgs e)
        {
            if( chkcricket.Checked)
            {
                lblcricket.Text = "cricket is selected";
            }
        }
    }

}