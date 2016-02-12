using CODE.Framework.Wpf.Mvvm;
using System;
using System.Collections.Generic;

namespace CODE.Framework.Wpf.TestUI.Models.Demo
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public bool Active { get; set; }
    }

    public class ListViewModel : ViewModel
    {
        private List<Employee> employees;

        public List<Employee> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                if (value == employees) return;
                employees = value;
                NotifyChanged("Employees");
            }
        }
        public Employee SelectedEmployee { get; set; }

        public ListViewModel()
        {
            // TODO: Populate actions and default property values here
            Actions.Add(new ViewAction("Example", execute: (a, o) => { /* Do something here */ }));
            Actions.Add(new CloseCurrentViewAction(this, beginGroup: true));

            this.Employees = new List<Employee>();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            this.Employees.Clear();

            this.Employees.Add(new Employee() { Id = 1, FullName = "Vazquez Roberto", Email = "rvazquez@live.mx", TelephoneNumber = "+52 961 3163", Birthday = new DateTime(1980,3,15), Age = 33, Active = true });
            this.Employees.Add(new Employee() { Id = 1, FullName = "Ruiz Eduardo", Email = "eruiz@live.mx", TelephoneNumber = "+52 968 1126", Birthday = new DateTime(1980, 3, 20), Age = 34, Active = false });

            NotifyChanged("Employees");
        }
    }
}
