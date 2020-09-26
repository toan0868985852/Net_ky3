using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GolfClub.DAL;
using GolfClub.Model;

namespace GolfClub
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