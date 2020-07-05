using System;

namespace Plife.Data.Models
{
    public class New
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
    }
}
