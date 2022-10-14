
using System.Threading.Tasks;
using ZXing.Mobile;
using Xamarin.Forms;
using Lab8.Service;
using Lab8.Droid.Service;
using Android.Nfc.Tech;

[assembly: Dependency(typeof(QrScanningService))]
namespace Lab8.Droid.Service
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            MobileBarcodeScanner.Initialize(MainActivity.Instance.Application);

            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}