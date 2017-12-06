using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApplication1.Models;
using WpfApplication1.Models.Mapping;
using WpfApplication1.Repository;

namespace WpfApplication2
{
    public class ViewModel : ViewModelBase
    {
        private ICommand addCommand;

        private ICommand saveCommand;

        private ICommand deleteCommand;

        private ICommand openCommand;

        private List<Course> enrollments;

        private IRepository<Course> courseRepository;

        public IRepository<Course> CourseRepository
        {
            get
            {
                if (this.courseRepository == null)
                {
                    this.courseRepository = new Repository<Course>(this.objschool);
                }

                return this.courseRepository;
            }
        }

        public ICommand OpenCommand
        {
            get
            {
                if (this.openCommand == null)
                {
                    this.openCommand = new RelayCommand<object>(this.ExecuteOpen, this.CanExecuteOpen);
                }

                return openCommand;
            }
        }

        private bool CanExecuteOpen(object obj)
        {
            return true;
        }

        private void ExecuteOpen(object obj)
        {
            
        }

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

        public SCHOOLContext objschool;

        public ViewModel()
        {
            Enrollments = new List<Course>();
            objschool = new SCHOOLContext();
            Enrollments = objschool.Courses.ToList();
        }

        private bool CanExecuteDigit(object obj)
        {
            return true;
        }

        private void ExecuteDigit(object obj)
        {

            Course objCourse = new Course() {  ClassSize = 5, CourseId = 8, EndDate = DateTime.Now, InstructorId = 8, Name = "john", StartDate = DateTime.Now, Title = "JObjhj" };
            Enrollments.Add(objCourse);
            objschool.Courses.Add(objCourse);
            (obj as DataGrid).Items.Refresh();
        }

        private bool CanExecuteSave(object obj)
        {
            return true;
        }

        private void ExecuteSave(object obj)
        {
            //CourseRepository.Update();
            objschool.SaveChanges();
        }

        private bool CanExecuteDelete(object obj)
        {
            return true;
        }

        private void ExecuteDelete(object obj)
        {
            object[] parameterArray = (object[])obj;
            Course id = parameterArray[0] as Course;
            Enrollments.Remove(id);
            objschool.Courses.Remove(id);
            (parameterArray[1] as DataGrid).Items.Refresh();
        }

    }
}
