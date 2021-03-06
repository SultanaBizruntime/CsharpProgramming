﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    [Serializable]
    class Serialize
    {

        private string Name;

        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        private string Phone;

        public string phone
        {
            get
            {
                return Phone;
            }

            set
            {
                Phone = value;
            }
        }

        private DateTime DoB;

        public DateTime dob
        {
            get
            {
                return DoB;
            }

            set
            {
                DoB = value;
            }
        }

        private string Department;

        public string department
        {
            get
            {
                return Department;
            }

            set
            {
                Department = value;
            }
        }

        private int Salary;
        private object textBoxName;
        private object textBoxPhone;
        private object dateTimePickerDoB;
        private object textBoxDepartment;
        private string additionalInfo;
        private object label6;
        private object textBoxSalary;
        private string i;

        public int salary
        {
            get
            {
                return Salary;
            }

            set
            {
                Salary = value;
            }
        }



        private void Serialize_Click(object sender, EventArgs e)
        {
            Serialize emp = new Serialize
            {
                name = (string)textBoxName,
                phone = (string)textBoxPhone,
                dob = Convert.ToDateTime(dateTimePickerDoB),
                department = (string)textBoxDepartment,
                salary = Convert.ToInt32(textBoxSalary),
                additionalInfo = "We don't want it to serialize"
            };

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream("employee.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {

                    bf.Serialize(fsout, emp);
                    Console.WriteLine(i = "Object Serialized");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(" an error has occured");
            }
        }


        private void Deserialize_Click(object sender, EventArgs e)
        {
            Serialize emp = new Serialize();

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsin = new FileStream("employee.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    emp = (Serialize)bf.Deserialize(fsin);
                    label6 = "Object Deserialized";

                    textBoxName = emp.name;
                    textBoxPhone = emp.phone;
                    dateTimePickerDoB = emp.dob;
                    textBoxDepartment = emp.department;
                    textBoxSalary = emp.salary.ToString();
                }
            }
            catch
            {
                label6 = "An error has occured";
            }
        }




    }
}
