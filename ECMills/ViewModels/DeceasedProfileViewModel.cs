using ECMills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECMills.ViewModels
{
    public class DeceasedProfileViewModel
    {
        public IEnumerable<sp_GetDeceasedProfile_Result> sp_GetDeceasedProfile_ResultsDataModel { get; set; }
        
        public IEnumerable<sp_GetDeceasedAddressList_Result> sp_GetDeceasedAddressList_ResultsDataModel { get; set; }

    }
}