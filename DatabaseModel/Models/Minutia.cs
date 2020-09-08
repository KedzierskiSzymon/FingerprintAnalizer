using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModel.Models
{
    public class Minutia : BaseRecord
    {
        public int Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public double Angle { get; set; }
        public int FingerprintId { get; set; }
    }
}
