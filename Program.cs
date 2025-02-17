

class Person
{
  string name = "aavash p";
  int age = 23;



  public static void Greet(List<Person> people)
  {
    Console.WriteLine("Select the person to greet:");
    for (int i = 0; i < people.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {people[i].name}");
    }
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice > 0 && choice <= people.Count)
    {
      Person selectedPerson = people[choice - 1];
      Console.WriteLine($"Hello, my name is {selectedPerson.name} and my age is {selectedPerson.age}");
    }
    else
    {
      Console.WriteLine("Invalid choice.");
    }
  }


  public void filter(List<Person> people)
  {
    for (int i = 0; i < people.Count; i++)
    {
      if (people[i].age > 20)
      {
        Console.WriteLine(people[i].name);
        
        
      }
    
    
  }
}




  static void Main(string[] args)
  {
    start:
    Console.WriteLine("\n\n1. Filter and display people above 20 \n2. Greet a specific person \n3.Exit");
    Console.WriteLine("Enter Your Choice");
    int choice = Convert.ToInt32(Console.ReadLine());

    Person p = new Person();


    // 2. Create a list of people:
    List<Person> people = new List<Person>
            {
                new Person { name = "aavash", age = 15 },
                new Person { name = "aayusha", age = 20 },
                new Person { name = "joseft", age = 25 },
                new Person { name = "aaryan", age = 30 },
                new Person { name = "matrika", age = 35 },
                new Person { name = "krisna", age = 40 }
            };


    switch (choice)
    {
      case 1:
      p.filter(people);
      goto start;  
      break;

      case 2:
     Greet(people);
      goto start;  
      break;


      case 3:
        break;


      default:
        // code block
        break;
    }








  }
  


  

}

