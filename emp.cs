using System;
using System.Linq;  
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Net;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics.PerformanceData;
using System.Collections;

namespace Practice
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        public void Options()
        {
 //------------------------------------------------------------------------------------------------------------------------------<OPTIONS>
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-----------------------OPTIONS-------------------");
            Console.WriteLine("ENTER THE NUMBER TO CHOOSE YOUR OPTIONS : \n");
            Console.WriteLine("\t>1) ADDING EMPLOYEE DETAILS ");
            Console.WriteLine("\t>2) REMOVING EMPLOYEE DETAILS ");
            Console.WriteLine("\t->3) SELECTING EMPLOYEE DETAILS USING ID ");
            Console.WriteLine("\t->4) SELECTING EMPLOYEE DETAILS USING NAME ");
            Console.WriteLine("\t>5) EXITING THE PROMPT \n");
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("#) CHOOSE YOUR OPTION: \n");
            int Key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t");

            if (Key == 1) { empAdd(); }
            else if (Key == 2) { empRemove(); }
            else if (Key == 3) { empSelectById(); }
            else if (Key == 4) { empSelectByName(); }
            else if (Key == 5) { empExit(); }
            else { Console.WriteLine("--< WRONG OPTION  TRY AGAIN..!!>--"); Options(); }
           
        }
 //------------------------------------------------------------------------------------------------------------------------------<ADD>
        public void empAdd()
        {
            Employee emp = new Employee();
            Console.WriteLine("->ENTER YOUR ID: ");
            emp.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("->ENTER YOUR NAME : ");
            emp.Name = Console.ReadLine();
            employees.Add(emp);
            Options();
        }
 //------------------------------------------------------------------------------------------------------------------------------<FIND BY ID>
        public Employee FindEmployeeById(int EID) //a class can be used as a method
        {
           for (int i = 0; i < employees.Count; i++)
            {
                Employee emp = employees[i];

                if (emp.ID == EID)
                {
                    return emp;
                    
                }
               // break;
            }  
                   return null;
                
        }

//------------------------------------------------------------------------------------------------------------------------------<FIND BY NAME>
       public List<Employee> FindEmployeesByName(string ENAME,int Choice)
        {
            
            
            for (int i = 0; i < employees.Count; i++)
            {
                Employee emp = employees[i];

                
                         if (Choice == 1)
                         {
                            if (emp.Name.StartsWith(ENAME, StringComparison.OrdinalIgnoreCase)) 
                            {
                                for (int v = 0; v < employees.Count;v++)
                                  {
                                     string[] arr1 = {};
                                     //arr1[v] = employees[v].Name;

                                   arr1[v] = emp.Name;
                            
                                  }    
                            }
                    

                         }
                         
                
                          
                         
                         else if (Choice == 2)
                         {
                            if (emp.Name.Contains(ENAME)) {  }
                            //else { return null; };
                         }
            }
            return null;
        }
 //------------------------------------------------------------------------------------------------------------------------------<REMOVE>
        public void empRemove()
        {
             Console.WriteLine("->ENTER THE EMPLOYEE ID IN THE TABLE TO BE REMOVED :");
             int EID = Convert.ToInt32(Console.ReadLine());
            
            Employee x =   FindEmployeeById(EID);
            if (x != null) { Console.WriteLine("|<--Employee ID found-->|"); employees.Remove(x); }
            else { Console.WriteLine("EMPLOYEE NOT FOUND TO REMOVE"); }
            Options();
        }
 //------------------------------------------------------------------------------------------------------------------------------<SELECT>
        public void empSelectById() 
        {
           Employee emp = new Employee();
            Console.WriteLine("->ENTER THE EMPLOYEE ID TO BE ACCESSED : "); 
            int EID = Convert.ToInt32(Console.ReadLine());
           Employee y = FindEmployeeById(EID);
            if(y != null) {Console.WriteLine("|" + y.ID + "--" + y.Name + "|"); }
            else { Console.WriteLine("NOT FOUND..!!"); }
            Options();
           
        }
//------------------------------------------------------------------------------------------------------------------------------<FIND BY NAME>
        public void empSelectByName()
        {
            Employee emp = new Employee();

            Console.WriteLine("ENTER: \n\t(1)-SELECT BY NAME OCCURANCE \n\t(2)-SELECT BY CONTAINS");
            int Choice = Convert.ToInt32(Console.ReadLine()); //1

            Console.WriteLine("ENTER THE EMPLOYEE NAME TO BE ACCESSED ");
            string ENAME = Console.ReadLine(); //kou

           Employee a = FindEmployeesByName(ENAME, Choice);

            if (Choice == 1) {Console.WriteLine("|" + a.Name + "---" + a.ID + "|");}
            else if (Choice == 2) { Console.WriteLine("|" + a.Name + "---" + a.ID + "|");  }
            else { Console.WriteLine("WRONG CHOICE RE-TRY AGAIN : ");empSelectByName(); }
            Options();
        }
 //------------------------------------------------------------------------------------------------------------------------------<EXIT>
        public void empExit()
        {
            Environment.Exit(0);
        }
 //==============================================================================================================================<MAIN FUNCTION>
        public static void Main(string[] args)
        {
            Program em = new Program();
            em.Options();
        }
 //===========================================================================================================================================>
    }
}



//17:00

/*  Employee a = FindEmployeeByName(ENAME, Choice);
            
            
                if (a != null) 
                { 
                Console.WriteLine("|" + a.Name + "---" + a.ID + "|");
                Options();
                }
               else { Console.WriteLine("Wrong name");Options();}*/














//using employee id only as parameter object

/*if (k == 2)
            {
                if (DIS == 0)
                    for (int i = 0; i < employees.Count; i++)
                    {
                        Employee emp = employees[i];

                        if (emp.ID == EID)
                        {
                            employees.RemoveAt(i);
                            break;
                        }

                    }

                Options();

            }
            else if (k == 3)
            {
              if(EID == 0)
              { 
                bool empExists = false;
                for (int j = 0; j < employees.Count; j++)
                {
                    Employee emp = employees[j];
                    if (emp.ID == DIS)
                    {

                        Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");

                        empExists = true;
                        break;

                    }

                }
                   if (empExists == false) { Console.WriteLine("|--<NOT FOUND>--|"); }
                   Options();

              }
            }*/

/*
sprt - 16 * 4 = 64 

  2 B/G
  B - 8
  G - 8
1 - ST w 12 m CH
 ADD - die;
 Lck ele;
 puzz w ans;


random number generation: 

 */




/*public void empRemove()
        {
            int DIS = 0;
            Console.WriteLine("->ENTER THE EMPLOYEE ID IN THE TABLE TO BE REMOVED :");
            int EID = Convert.ToInt32(Console.ReadLine());
            Empall(2,EID,DIS);
        }

        public void empSelect() 
        {
            int EID = 0;
            Console.WriteLine("->ENTER THE EMPLOYEE ID TO BE ACCESSED : ");
            int DIS = Convert.ToInt32(Console.ReadLine());
            Empall(3,EID,DIS);
        }*/





/*Console.WriteLine("Enter the EMPLOYEE ID to be acessed : ");
            int DIS = Convert.ToInt32(Console.ReadLine());
            bool empExists = false;
            for (int j = 0; j < employees.Count; j++)
            {
                Employee emp = employees[j];
                if (emp.ID == DIS)
                {
                    
                    Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");
                    
                    empExists = true;
                    break;
                   
                }
                
            }
            if (empExists == false) { Console.WriteLine("not found"); }
            Options();*/


/* Console.WriteLine("Enter The EMPLOYEE ID of the table to be removed :");
 int EID = Convert.ToInt32(Console.ReadLine());
 for(int i = 0; i < employees.Count; i++) 
 {
     Employee emp = employees[i];
     if(emp.ID == EID) 
     {
      employees.RemoveAt(i);
         break;
     }



 }

     Options();*/




/*
 * 
 * 
 * 
 * 
 * public void EmployeData(int EID,int DIS)
        {
            if (EID > 0)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    Employee emp = employees[i];

                    if (emp.ID == EID)
                    {
                        employees.RemoveAt(i);
                        break;
                    }
                }
                Options();
                
            }
            else if(DIS > 0)
            {
                bool empExists = false;
                for (int j = 0; j < employees.Count; j++)
                {
                    Employee emp = employees[j];
                    if (emp.ID == DIS)
                    {

                        Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");
                        empExists = true;
                        break;

                    }

                }
               
                if (empExists == false) { Console.WriteLine("|--<NOT FOUND>--|"); }
                Options();
            }
             //else { Console.WriteLine("|--<NOT FOUND>--|"); Options(); }
        }
 * 
 * 
 * 
 */


/* if (EID != 0)
           {
               for (int i = 0; i < employees.Count; i++)
               {
                   Employee emp = employees[i];
                   if (emp.ID == EID)
                   {
                       employees.RemoveAt(i);
                       break;
                   }
               }
               Options();
           }
           else if (DIS != 0)
           {
               bool empExists = false;
               for (int j = 0; j < employees.Count; j++)
               {
                   Employee emp = employees[j];
                   if (emp.ID == DIS)
                   {
                       Console.WriteLine("--------");
                       Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");
                       Console.WriteLine("--------");
                       empExists = true;
                       break;
                   }
               }
               if (empExists == false) { Console.WriteLine("|--<NOT FOUND>--|"); }



Options();*/


/*public int FindEmployee(int x)
      {
          //for(int i = 0; i < employees.Count; i++) 
          //{
              //Employee emp = employees[i];
              //if (emp.ID == x)
              //{
                  return x = 1;
              //}

          //}

      }*/



//17-11-2023 AFTERNOON : 16:08
//Employee emp = new Employee();
//Program employees = new Program();

//if(employees.FindEmployee(EID) == null)
//{ Console.WriteLine("NOT FOUND");Options(); }
//Employee emp = new Employee();
//if (employees.FindEmployee(EID) != null)
//  Console.WriteLine("|" + emp.ID + "--" + emp.Name + "|");
//else Console.WriteLine("wrong code");
//null ->  not found //emp -> ("emp.ID" + " " + emp.Name")















/*bool empExists = false;
for (int j = 0; j < employees.Count; j++)
{
    Employee emp = employees[j];
    if (emp.ID == EID)
    {

        Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");
        empExists = true;
        //break;

    }

}
if (empExists == false)
{
    Console.WriteLine("|--<NOT FOUND>--|"); 
}
Options();*/



/* for (int i = 0; i < employees.Count; i++)
                {
                    Employee emp = employees[i];

                    if (emp.ID == EID)
                    {
                        employees.RemoveAt(i);
                        break;
                    }
                }*/

/* for (int i = 0; i < employees.Count; i++)
              {
                  Employee emp = employees[i];

                  if (emp.ID == EID)
                  {
                      employees.RemoveAt(i);
                      break;
                  }
              }*/
