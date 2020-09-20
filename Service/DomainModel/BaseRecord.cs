using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DomainModel
{
    public class BaseRecord
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
