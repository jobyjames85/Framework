﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ModelServe
{
    [DataContract]
    public class StringData
    {
        [DataMember]
        public string OriginalString;


        [DataMember]
        public string FlippedCaseString;

    }
}