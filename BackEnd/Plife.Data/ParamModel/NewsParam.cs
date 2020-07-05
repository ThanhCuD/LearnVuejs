using System;
using System.Collections.Generic;
using System.Text;

namespace Plife.Data.ParamModel
{
    public class SaveNewsParamModel
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
    }
}
