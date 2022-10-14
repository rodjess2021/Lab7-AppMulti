using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Service
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();

    }
}
