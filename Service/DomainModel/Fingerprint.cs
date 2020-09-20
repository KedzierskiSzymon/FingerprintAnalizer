using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DomainModel
{
    public class Fingerprint : BaseRecord
    {
        public int? UserId { get; set; }

        public IEnumerable<Minutia> Minutiae { get; set; }

        public Fingerprint()
        {
            Minutiae = new List<Minutia>();
        }
    }
}
