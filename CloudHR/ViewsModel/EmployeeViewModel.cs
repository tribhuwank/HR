using System;

namespace CloudHR.ViewsModel
{
    public class EmployeeViewModel: BaseViewModel
    {
        public PersonViewModel Person { get; set; }
        public int PersonId { get; set; }        
        public int EmployeeJobId { get; set; }
        public EmployeeJobViewModel EmployeeJob { get; set; }
        public int? ManagerId { get; set; }
        public EmployeeViewModel Manager { get; set; }       
        public int? NomineeId { get; set; }
        public PersonViewModel Nominee { get; set; }
        public PersonViewModel[] DependentPersons { get; set; }
        public string PanNumber { get; set; }
        public string CitNumber { get; set; }


    }
}
