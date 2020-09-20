using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DomainModel
{
    public class User : BaseRecord
    {
        public string Name { get; set; }
        public IEnumerable<Fingerprint> Fingerprints { get; set; }

        public User()
        {
            Fingerprints = new List<Fingerprint>();
        }
    }
}
