using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab1._1._1.Models;
using lab1._1._1.DAL;

namespace lab1._1._1.Repository
{
    public class DbHelper
    {
        public Member PostMemberDetails(Member memberModel)
        {
            ClubMemberDbManager dbInstance = new ClubMemberDbManager();
            return dbInstance.CreateMember(memberModel);
        }
    }
}