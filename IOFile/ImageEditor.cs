using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IOFile
{
    public class ImageEditor : CommonFileEditor
    {
        public ImageEditor()
            : base()
        {

        }

        public BitmapImage LoadAndGetBitmapImage(IApplicationConfiguration configuration, string filename)
        {
            string fullFilename = configuration.FingerprintDirectory + filename + configuration.FileExtension;
            BitmapImage image = new BitmapImage(new Uri(fullFilename));

            return image;
        }

        public Bitmap LoadAndGetBitmap(IApplicationConfiguration configuration, string filename, bool originalData = true)
        {
            string fullFilename = (originalData) ? configuration.FingerprintDirectory : configuration.OperationDirectory;
            fullFilename += filename + configuration.FileExtension;
            Bitmap bitmap = new Bitmap(fullFilename);

            return bitmap;
        }

        public void SaveBitmapToFile(IApplicationConfiguration biometricModeConfiguration, Bitmap bitmap, string filename)
        {
            string fullFilename = biometricModeConfiguration.OperationDirectory + filename + biometricModeConfiguration.FileExtension;
            bitmap.Save(fullFilename);
        }
    }
}
