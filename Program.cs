// Coding Task:
// Objective: Manage a list of people and filter by age.


class Person
{
     string name="aavash p";
     int age=23;
    
    public void Greet( Person p)   // method
  {

                Console.WriteLine($"Hello, my name is {p.name} and my age is  {p.age}");

  }
   



    static void Main(string[] args)
  {
            Person p = new Person();
            p.Greet(p);



  }

}

