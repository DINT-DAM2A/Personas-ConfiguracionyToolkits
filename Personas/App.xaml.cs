using System.Windows;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(
                "NTY2OTI3QDMxMzkyZTM0MmUzMG85Q0toWFI2U2dGcVIwdjlXRHBDVGlHanpxZFlWVEJLcnZWUWtuSE5EekU9");
        }
    }
}
