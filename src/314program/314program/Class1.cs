using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _314program
{
    class Student
    {
        private  int id;
        private string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("{0}     {1}",id,name);
        }
    }
}
