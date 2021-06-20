using System;
using System.Collections.Generic;

namespace Its.Jenuiue.Api.Models.Organization
{
    public class MRegistration : BaseOrgModel
    {
        public DateTime RegisteredDate { get; set; }
        public string IP { get; set; }
        public List<string> Headers { get; set; }
    }
}