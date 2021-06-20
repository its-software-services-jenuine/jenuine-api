using System;

namespace Its.Jenuiue.Api.Models.Organization
{
    public class MRegistration : BaseOrgModel
    {
        public DateTime RegisteredDate { get; set; }
        public string IP { get; set; }
        public string[] Headers { get; set; }
    }
}