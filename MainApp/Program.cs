


using Domain.Models;
using Infrastructure.Service;
var st1=new Student();
st1.Id=1;
st1.FirstName="Muhammad";
st1.LastName="Samadov";
st1.BirthDate=new DateTime(2006,02,04);
st1.PhoneNumber="112113939";
st1.Course="C#";
var st2=new Student();
st2.Id=2;
st2.FirstName="Sunatullo";
st2.LastName="Chillaev";
st2.BirthDate=new DateTime(2004,06,29);
st2.PhoneNumber="083952962";
st2.Course="JS";
var st3=new Student();
st3.Id=3;
st3.FirstName="Dovud";
st3.LastName="Ishratov";
st3.BirthDate=new DateTime(2000,09,07);
st3.PhoneNumber="919285307";
st3.Course="React";
var st4=new Student();
st4.Id=4;
st4.FirstName="Orzu";
st4.LastName="Panakov";
st4.BirthDate=new DateTime(2003,12,31);
st4.PhoneNumber="9865930183";
st4.Course="SQL";
var st5=new Student();
st5.Id=4;
st5.FirstName="bla";
st5.LastName="blablabla";
st5.BirthDate=new DateTime(1912,12,12);
st5.PhoneNumber="987384920";
st5.Course="Nichego";
var stservice1 = new StudentService();
stservice1.GetAll();
stservice1.GetById(st5);
stservice1.AddStudent(st1);
stservice1.AddStudent(st2);
stservice1.AddStudent(st3);
stservice1.AddStudent(st4);
stservice1.UpdateStudents(st5);

System.Console.WriteLine("To continue click the button");
System.Console.WriteLine("1: GetAll");

while(true)
{
    int command=Convert.ToInt32(Console.ReadLine());
    if(command==1)
    {
        foreach (var item in stservice1.GetAll())
        {
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.FirstName);
            System.Console.WriteLine(item.LastName);
            System.Console.WriteLine(item.BirthDate);
            System.Console.WriteLine(item.PhoneNumber);
            System.Console.WriteLine(item.Course);
        }
    }
}

