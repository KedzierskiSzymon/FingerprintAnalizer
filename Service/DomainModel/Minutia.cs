using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DomainModel
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
