using System.Windows;
using Clime.MVVMUtils;
using GalaSoft.MvvmLight.Messaging;

namespace Clime.View
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();

            // Showing MessageBoxes and sending callbacks
            Messenger.Default.Register<DialogMessage>(
                this,
                msg =>
                {
                    var result = MessageBox.Show(msg.Content, msg.Caption, msg.Button);
                    msg.ProcessCallback(result);
                });
        }
    }
}