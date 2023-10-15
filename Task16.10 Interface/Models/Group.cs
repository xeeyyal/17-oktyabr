using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task16._10_Interface.Models
{
    //TASK-3
    //internal class Group
    //{
    //    public static Group[] Groups { get; private set; }
    //    public static int GroupCount { get; private set; }

    //    public int GroupId { get; }
    //    public string GroupName { get; set; }
    //    public Student[] Students { get; private set; }

    //    public Group(string groupName)
    //    {
    //        GroupId = ++GroupCount;
    //        GroupName = groupName;
    //        Students = new Student[4];
    //        if (Groups == null)
    //        {
    //            Groups = new Group[2];
    //        }
    //        Groups[GroupId - 1] = this;
    //    }

    //    public void GetGroupInfo()
    //    {
    //        Console.WriteLine($"Group ID: {GroupId}, Group Name: {GroupName}, Student Count: {Students.Length}");
    //    }

    //    public Student GetStudent(int id)
    //    {
    //        foreach (var student in Students)
    //        {
    //            if (student != null && student.Id == id)
    //            {
    //                return student;
    //            }
    //        }
    //        return null;
    //    }

    //    public void AddStudent(Student student)
    //    {
    //        for (int i = 0; i < Students.Length; i++)
    //        {
    //            if (Students[i] == null)
    //            {
    //                Students[i] = student;
    //                break;
    //            }
    //        }
    //    }

    //    public void Search(string searchStr)
    //    {
    //        Console.WriteLine($"Searching for '{searchStr}' in Group {GroupName}:");
    //        foreach (var student in Students)
    //        {
    //            if (student != null && (student.Name.Contains(searchStr) || student.Surname.Contains(searchStr)))
    //            {
    //                student.GetInfo();
    //            }
    //        }
    //    }

    //    public void RemoveStudent(int id)
    //    {
    //        for (int i = 0; i < Students.Length; i++)
    //        {
    //            if (Students[i] != null && Students[i].Id == id)
    //            {
    //                Students[i] = null;
    //                break;
    //            }
    //        }
    //    }

    //    public void ShowStudents()
    //    {
    //        Console.WriteLine($"Students in Group {GroupName}:");
    //        foreach (var student in Students)
    //        {
    //            if (student != null)
    //            {
    //                student.GetInfo();
    //            }
    //        }
    //    }

    //    public static void ShowAllGroups()
    //    {
    //        Console.WriteLine("All Groups:");
    //        foreach (var group in Groups)
    //        {
    //            if (group != null)
    //            {
    //                group.GetGroupInfo();
    //            }
    //        }
    //    }

    //    public static void AddGroup(Group group)
    //    {
    //        if (GroupCount < 2)
    //        {
    //            Groups[GroupCount] = group;
    //        }
    //    }
    //}
}
