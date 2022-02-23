using System;
using System.Collections.Generic;
using System.Text;

class SelectionSort
{
    static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparision)
    {
        bool swapped = true;
        do
        {
            int position, i, j;
            swapped = false;
            for (i = 0; i < sortArray.Count - 1; i++)
            {
                position = i;
                for (j = i; j < sortArray.Count; j++)
                {
                    if (comparision(sortArray[position], sortArray[j]))
                    {
                        position = j;
                    }
                }

                if (position != i)
                {
                    T temp = sortArray[i];
                    sortArray[i] = sortArray[i + 1];
                    sortArray[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }
}
public enum Designations
{
    CEO = 3,
    CFO = 9,
    sde = 6,
    ba = 1,
    pm = 5
}

class Employee
{
    int empid;
    float salary;
    public string name;
    Designations designation;

    public Employee(int EmpId, float Salary, string NAme, Designations design)
    {
        this.empid = EmpId;
        this.salary = Salary;
        this.name = NAme;
        this.designation = design;

    }

    internal static bool CompareSalary(Employee e1, Employee e2)
    {
        return e1.salary < e2.salary;
    }

    internal static bool CompareNames(Employee e1, Employee e2)
    {
        if (e1.name.CompareTo(e2.name) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    internal static bool CompareDesignations(Employee e1, Employee e2)
    {
        return e1.designation < e2.designation;
    }
}


public class GenericMethods
{
    public static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>(30);
        employeeList.Add(new Employee(1111, 230000, "Jean", Designations.CFO));

        employeeList.Add(new Employee(2222, 11000000, "Aramin", Designations.CEO));

        employeeList.Add(new Employee(3333, 451000, "Conny", Designations.sde));

        employeeList.Add(new Employee(4444, 29999, "Mikasa", Designations.CEO));

        employeeList.Add(new Employee(55555, 75000, "Shasha", Designations.sde));

        employeeList.Add(new Employee(6666, 800000, "Annie", Designations.CFO));


        SelectionSort.Sort<Employee>(employeeList, Employee.CompareSalary);

        foreach (Employee e1 in employeeList)
        {
            Console.WriteLine(e1.name);
        }
    }
}