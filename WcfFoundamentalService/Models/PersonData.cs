﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfFoundamentalService.Models
{
    [DataContract]
    public class PersonData
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string PersonalId { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string FullName { get; set; }
    }
}