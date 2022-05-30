using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Homework.Control_Work.CW2.Event1;
using Homework.Control_Work.CW2.Event2;
using Homework.Control_Work.CW2.Reflection;
using Homework.Control_Work.CW2;
using Homework._2_Semester_Hw._28._02___7;



namespace Homework
{
     public class Program
    {
        static void Main()
        {
            var patients = new List<Patient>
            {
                new Patient("Кира", 1, 1, 19),
                new Patient("Макс",2, 2, 21),
                new Patient("Дима",3, 1, 15),
                new Patient("Ира",4, 3, 30),
                new Patient("Николь",5, 1, 10),
                new Patient("Даня",6, 4, 20),
                new Patient("Олеся",7, 2, 18),
                new Patient("Глеб",8, 3, 15),
                new Patient("Рома",9, 4, 22),
                new Patient("Ильдар",10, 1, 25),
            };

            var doctors = new List<Doctor>
            {
                new Doctor("Аркадий","Терапевт", 1),
                new Doctor("Светлана","ЛОР", 2),
                new Doctor("Динара","Дерматолог", 3),
                new Doctor("Захрипа-опа","Орнитолог", 4),
                new Doctor("Игорь","Окулист", 5),
            };

            var pL = new List<PatientList>();
            pL.Add(new PatientList(patients[0], doctors[0]));
            pL.Add(new PatientList(patients[1], doctors[1]));
            pL.Add(new PatientList(patients[2], doctors[0]));
            pL.Add(new PatientList(patients[3], doctors[2]));
            pL.Add(new PatientList(patients[4], doctors[4]));
            pL.Add(new PatientList(patients[5], doctors[3]));
            pL.Add(new PatientList(patients[6], doctors[1]));
            pL.Add(new PatientList(patients[7], doctors[2]));
            pL.Add(new PatientList(patients[8], doctors[3]));
            pL.Add(new PatientList(patients[9], doctors[0]));

            //Вывести список имя пациента, имя врача, специализация врача(без циклов foreach/for/while)
            pL.ForEach(x => Console.WriteLine($"Имя пациента {x.Patient.Name} имя врача{x.Doc.Name} специализация врача{x.Doc.Prof}"));

            //Вывести список имя врача, количество пациентов, средний возраст пациентов, которых он лечит
            pL.);
        }

        public class Patient
        {
            public string Name;
            public int PatientId;
            public int DocId;
            public int Age;
            public Patient(string name, int patientId, int docId, int age)
            {
                Name = name;
                PatientId = patientId;
                DocId = docId;
                Age = age;
            }
        }
        public class Doctor
        {
            public string Name;
            public string Prof;
            public int DocId;

            public Doctor(string name, string prof, int docId)
            {
                this.Name = name;
                this.Prof = prof;
                this.DocId = docId;
            }
        }

        public class PatientList
        {

            public Patient Patient;
            public Doctor Doc;

            public PatientList(Patient patient, Doctor doc)
            {
                Patient = patient;
                Doc = doc;
            }
        }
    }
}
