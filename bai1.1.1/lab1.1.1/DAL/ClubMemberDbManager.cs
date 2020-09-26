using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab1._1._1.Models;


namespace lab1._1._1.DAL
{
    public class ClubMemberDbManager
    {
        public Member CreateMember(Member memberModel)
        {
            using (var dbEntities = new GolfClubContext())
            {
                var MemberObj = new Member()
                {
                    Name = memberModel.Name,
                    Gender = memberModel.Gender,
                    MenberFee = memberModel.MenberFee
                };
                dbEntities.Members.Add(MemberObj);
                dbEntities.SaveChanger();
            }    
            return memberModel;
        }
    }
}