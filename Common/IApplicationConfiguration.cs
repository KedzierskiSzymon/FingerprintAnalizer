using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public interface IApplicationConfiguration
    {
        string ConnectionString { get; set; }
        string FingerprintDirectory { get; set; }
        string OperationDirectory { get; set; }
        string FileExtension { get; set; }
    }
}
