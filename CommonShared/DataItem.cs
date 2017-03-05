using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CommonShared
{
    [DataContract]
    public class DataItem
    {
        [DataMember(Name = "fileName", IsRequired = true)]
        public string FileName
        {
            get; set;
        }

        [DataMember(Name = "display", IsRequired = true)]
        public string Display
        {
            get; set;
        }

        [DataMember(Name = "children", IsRequired = false, EmitDefaultValue = true)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<DataItem> Children
        {
            get; set;
        }
    }
}
