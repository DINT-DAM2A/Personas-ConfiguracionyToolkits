using System.Windows.Controls;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para ConsultaPersona.xaml
    /// </summary>
    public partial class ConsultaPersona : UserControl
    {
        ConsultaPersonaVM vm;

        public ConsultaPersona()
        {
            InitializeComponent();
            vm = new ConsultaPersonaVM();
            this.DataContext = vm;
        }
    }
}
