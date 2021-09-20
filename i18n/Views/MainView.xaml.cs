using i18n.Commands;
using i18n.ViewModels;
using System;
using System.Windows;

namespace i18n
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeesMainViewModel vm;
        App app;

        public MainWindow(App app)
        {
            InitializeComponent();
            vm = new EmployeesMainViewModel();
            DataContext = vm;

            this.app = app;

            vm.RestartCommand = new DelegateCommand<string>(Restart);
        }

        private void Restart(string obj)
        {
            var result = MessageBox.Show("Pour appliquer les changements, il faut redémarrer l'application.", "Message", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                app.Restart();
            }
        }
    }
}
