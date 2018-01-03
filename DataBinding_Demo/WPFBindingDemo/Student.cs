using System;
using System.ComponentModel;

namespace WPFBindingDemo
{
    public class Student:INotifyPropertyChanged
    {
        private int m_ID;
        private string m_StudentName;
        private double m_Score;
        private DateTime m_birthDate;
        public DateTime BirthDate {
            get { return m_birthDate; }
            set
            {
                if(value!=m_birthDate)
                {
                    m_birthDate = value;
                    Notify("BirthDate");
                }


            }



        }

        public int ID
        {
            get { return m_ID; }
            set 
            {
                if (value != m_ID)
                {
                    m_ID = value;
                    Notify("ID");
                }
            }
        }

        public string StudentName
        {
            get { return m_StudentName; }
            set
            {
                if (value != m_StudentName)
                {
                    m_StudentName = value;
                    Notify("StudentName");
                }
            }
        }

        public double Score
        {
            get { return m_Score; }
            set 
            {
                if (value != m_Score)
                {
                    m_Score = value;
                    Notify("Score");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify(string propertyName)
        {            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}
