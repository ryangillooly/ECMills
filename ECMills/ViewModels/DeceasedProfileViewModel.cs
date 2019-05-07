using ECMills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECMills.ViewModels
{
    public class DeceasedProfileViewModel
    {
        public IEnumerable<sp_GetDeceasedProfile_Result> sp_GetDeceasedProfile_Results { get; set; }
        
        public IEnumerable<sp_GetDeceasedAddressList_Result> sp_GetDeceasedAddressList_Results { get; set; }

        //public DeceasedProfileViewModel()
        //{
        //    sp_GetDeceasedProfile_Results = new sp_GetDeceasedProfile_Result();
        //    sp_GetDeceasedAddressList_Results = new sp_GetDeceasedAddressList_Result();
        //}
    }
}