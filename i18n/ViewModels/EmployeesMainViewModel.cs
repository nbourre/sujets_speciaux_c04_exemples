using i18n.Commands;
using i18n.Services;
using SharedModels;
using System;
using System.Collections.ObjectModel;

namespace i18n.ViewModels
{
    public class EmployeesMainViewModel : BaseViewModel
    {
        EmployeeDataService ds = new EmployeeDataService();

        public DelegateCommand<string> RestartCommand { get; set; }

        public DelegateCommand<string> ChangeLanguageCommand { get; set; }

        private ObservableCollection<Employee> employees;

        public ObservableCollection<Employee> Employees
        {
            get => employees;
            set { 
                employees = value;
                OnPropertyChanged();
            }
        }

        public EmployeesMainViewModel()
        {
            employees = new ObservableCollection<Employee>(ds.GetAll());
            ChangeLanguageCommand = new DelegateCommand<string>(ChangeLanguage);
        }

        private void ChangeLanguage(string param)
        {
            Properties.Settings.Default.Language = param;
            Properties.Settings.Default.Save();

            RestartCommand?.Execute("");
        }
    }
}