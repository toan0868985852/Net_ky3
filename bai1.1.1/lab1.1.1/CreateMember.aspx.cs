using lab1._1._1.DAL;
using lab1._1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab1._1._1
{
    public partial class CreateMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClubMemberDbManager objclubMemberObManager = new ClubMemberDbManager();
            Member memberModel = new Member();
            memberModel.Name = txtName.Text;
            memberModel.Gender = drpGender.SelectedItem.Text;
            memberModel.MenberFee = Convert.ToDouble(txtfees.Text);
            memberModel = objclubMemberObManager.CreateMember(memberModel);
            iblMessage.Text = "Member Created Successfully";
        }
    }
}