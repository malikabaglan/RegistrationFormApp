using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace RegistrationForm
{
    public class CheckBoxLogic : INotifyPropertyChanged
    {

        public Command TappedCheckBoxMale { get; private set; }

        public Command TappedCheckBoxFemale { get; private set; }

        public Command TappedCheckBoxStudent { get; private set; }

        public Command TappedCheckBoxTechician { get; private set; }

        public Command TappedCheckBoxTechicianTraining { get; private set; } 


        /// <summary>
        /// The check box male.
        /// </summary>
        public string _CheckBoxMale = "checked.png";
        public string CheckBoxMale
        {
            get          
            {
                return _CheckBoxMale;
            }
            set
            {
                if (_CheckBoxMale != value)

                {
                    _CheckBoxMale = value;
                    NotifyPropertyChanged("CheckBoxMale");
                }
            }
        }
        /// <summary>
        /// The check box female.
        /// </summary>
        public string _CheckBoxFemale = "unchecked.png";
        public string CheckBoxFemale
        {
            get
            {
                return _CheckBoxFemale;
            }
            set
            {
                if (_CheckBoxFemale != value)

                {
                    _CheckBoxFemale = value;
                    NotifyPropertyChanged("CheckBoxFemale");
                }
            }
        }

        /// <summary>
        /// The check box student.
        /// </summary>
        public string _CheckBoxStudent = "unchecked.png";
        public string CheckBoxStrudent
        {
            get
            {
                return _CheckBoxStudent;
            }
            set
            {
                if (_CheckBoxStudent != value)

                {
                    _CheckBoxStudent = value;
                    NotifyPropertyChanged("CheckBoxStrudent");
                }
            }
        }
        /// <summary>
        /// The check box Technician.
        /// </summary>

        public string _CheckBoxTechician= "unchecked.png";
        public string CheckBoxTechnician
        {
            get
            {
                return _CheckBoxTechician;
            }
            set
            {
                if (_CheckBoxTechician!=value)
                {
                    _CheckBoxTechician = value;
                    NotifyPropertyChanged("CheckBoxTechnician");
                }
            }
        }
        /// <summary>
        /// The check box TechnicianTraining.
        /// </summary>

        public string _CheckBoxTechicianTraining = "unchecked.png";
        public string CheckBoxTechnicianTraining
        {
            get
            {
                return _CheckBoxTechicianTraining;
            }
            set
            {
                if (_CheckBoxTechicianTraining != value)
                {
                    _CheckBoxTechicianTraining = value;
                    NotifyPropertyChanged("CheckBoxTechnician");
                }
            }
        }


        public CheckBoxLogic()

        {
            TappedCheckBoxMale = new Command(TappedCheckBoxMaleImage);
            TappedCheckBoxFemale = new Command(TappedCheckBoxFemaleImage);
            TappedCheckBoxStudent = new Command(TappedCheckBoxStudentImage);
            TappedCheckBoxTechician = new Command(TappedCheckBoxTechicianImage);
            TappedCheckBoxTechicianTraining = new Command(TappedCheckBoxTechicianTrainingImage);
        }

        private void TappedCheckBoxMaleImage()
        {
            CheckBoxMale = "checked.png";
            CheckBoxFemale = "unchecked.png";
            CheckBoxStrudent = "unchecked.png";
            CheckBoxTechnician= "unchecked.png";
            CheckBoxTechnicianTraining= "unchecked.png";
        }

        private void TappedCheckBoxFemaleImage()
        {
            CheckBoxMale = "unchecked.png";
            CheckBoxFemale = "checked.png";
            CheckBoxStrudent = "unchecked.png";
            CheckBoxTechnician = "unchecked.png";
            CheckBoxTechnicianTraining = "unchecked.png";
        }


        private void TappedCheckBoxStudentImage()
        {
            CheckBoxMale = "unchecked.png";
            CheckBoxFemale = "unchecked.png";
            CheckBoxStrudent = "checked.png";
            CheckBoxTechnician = "unchecked.png";
            CheckBoxTechnicianTraining = "unchecked.png";
        }


        private void TappedCheckBoxTechicianImage()
        {
            CheckBoxMale = "unchecked.png";
            CheckBoxFemale = "unchecked.png";
            CheckBoxStrudent = "unchecked.png";
            CheckBoxTechnician = "checked.png";
            CheckBoxTechnicianTraining = "unchecked.png";
        }

        private void TappedCheckBoxTechicianTrainingImage()
        {
            CheckBoxMale = "unchecked.png";
            CheckBoxFemale = "unchecked.png";
            CheckBoxStrudent = "unchecked.png";
            CheckBoxTechnician = "unchecked.png";
            CheckBoxTechnicianTraining = "checked.png";
        }





        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
