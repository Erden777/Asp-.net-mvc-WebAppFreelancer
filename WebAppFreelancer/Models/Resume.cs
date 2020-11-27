using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFreelancer.Models
{
    public class Resume
    {
        public int resumeId { get; set; }
        public string knowledge { get; set; }
        public string highSchoolName { get; set; }
        public string experience { get; set; }
        public ApplicationUser user { get; set; }
        public int userID { get; set; }

    }
}