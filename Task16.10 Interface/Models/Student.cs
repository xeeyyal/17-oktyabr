using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task16._10_Interface.Interfaces;

namespace Task16._10_Interface.Models
{
    //internal class Student : ICodeAcademy
    //{
    //    public static int Count { get; private set; } = 0;
    //    public int Id { get; }
    //    public string Name { get; }
    //    public string Surname { get; }
    //    public string CodeEmail { get; private set; }

    //    public Student(string name, string surname)
    //    {
    //        if (CheckName(name, surname))
    //        {
    //            Name = name;
    //            Surname = surname;
    //            Id = ++Count;
    //            GenerateEmail();
    //        }
    //    }
    //    public static bool CheckName(string name, string surname)
    //    {
    //        if (name.Length < 3 || name.Length > 25 && surname.Length < 3 || surname.Length > 25)
    //            return false;

    //        foreach (char a in name)
    //        {
    //            if (!char.IsLetter(a))
    //                return false;
    //        }

    //        foreach (char a in surname)
    //        {
    //            if (!char.IsLetter(a))
    //                return false;
    //        }

    //        return true;
    //    }
    //    public void GenerateEmail()
    //    {
    //        string email = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
    //        CodeEmail = email;
    //    }

    //    public void ICodeAcademy()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
