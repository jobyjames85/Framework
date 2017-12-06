using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Controls;
using System.Windows.Input;
using WPFModel;

namespace WpfApplication2
{
    public class ViewModel : ViewModelBase
    {
        private ICommand addCommand;

        private ICommand saveCommand;

        private ICommand deleteCommand;

        private List<Course> enrollments;

        public ICommand DeleteCommand
        {
            get
            {
                if (this.deleteCommand == null)
                {
                    this.deleteCommand = new RelayCommand<object>(this.ExecuteDelete, this.CanExecuteDelete);
                }

                return deleteCommand;
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                if (this.saveCommand == null)
                {
                    this.saveCommand = new RelayCommand<object>(this.ExecuteSave, this.CanExecuteSave);
                }

                return saveCommand;
            }
        }

        public List<Course> Enrollments
        {
            get
            {
                return enrollments;
            }
            set
            {
                enrollments = value;
                OnPropertyChanged("Enrollments");
            }
        }

        public ICommand AddCommand
        {
            get
            {
                if (this.addCommand == null)
                {
                    this.addCommand = new RelayCommand<object>(this.ExecuteDigit, this.CanExecuteDigit);
                }

                return addCommand;
            }
        }

        //private System.Data.Services.Client.DataServiceQuery<AdventureWorksService.SalesOrderHeader> salesQuery;
        //private CollectionViewSource ordersViewSource;

        public ViewModel()
        {
            Enrollments = new List<Course>();
            BasicHttpBinding basicHttpbinding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            basicHttpbinding.Name = "BasicHttpBinding_ICourse";
            basicHttpbinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            basicHttpbinding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;

            EndpointAddress endpointAddress = new EndpointAddress("http://localhost:59178/CourseService.svc");
            ServiceReference1.CourseClient courseClient = new ServiceReference1.CourseClient(basicHttpbinding, endpointAddress);
            var Data = courseClient.GetCourse();

            foreach (var item in Data.ToList())
            {
                Enrollments.Add(new Course() { CourseId = item.CourseId, ClassSize = item.ClassSize, EndDate = item.EndDate, InstructorId = item.InstructorId, Name = item.Name, NickName = item.NickName, StartDate = item.StartDate, Title = item.Title });
            }
        }

        private bool CanExecuteDigit(object obj)
        {
            return true;
        }

        private void ExecuteDigit(object obj)
        {
            //Course objCourse = new Course() {  ClassSize = 5, CourseId = 8, EndDate = DateTime.Now, InstructorId = 8, Name = "john", StartDate = DateTime.Now, Title = "JObjhj" };
            //Enrollments.Add(objCourse);
            //objschool.Courses.Add(objCourse);
            //(obj as DataGrid).Items.Refresh();
        }

        private bool CanExecuteSave(object obj)
        {
            return true;
        }

        private void ExecuteSave(object obj)
        {
            //CourseRepository.Update();
            //objschool.SaveChanges();
        }

        private bool CanExecuteDelete(object obj)
        {
            return true;
        }

        private void ExecuteDelete(object obj)
        {
            //object[] parameterArray = (object[])obj;
            //Course id = parameterArray[0] as Course;
            //Enrollments.Remove(id);
            //objschool.Courses.Remove(id);
            //(parameterArray[1] as DataGrid).Items.Refresh();
        }

    }
}
