using System.Windows;
using Clime.MVVMUtils;

namespace Clime.View
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}