using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModel.Models
{
    public abstract class BaseRecord
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
