using System.Security.Cryptography.X509Certificates;

class program
{
    public static void Main(String[] args)
    {
        List<dogs> alldogs = new List<dogs>();
        for (int i = 0; i < 3; i++)
        {
            dogs mydogs = Adddog();
            dogs temp = new dogs();
            alldogs.Add(mydogs);
        }

        for(int i = 0; i < alldogs.Count; i++)
        {
            alldogs[i].PrintInfo();
            Console.WriteLine("****************");
        }
       dograce(alldogs);
        
    }



    class dogs
    {
        int weight;
        int age;
        string name;
        string speed;
        int height;

        public dogs() {
        }

        public dogs(string name, int weight, int height, int age, string speed)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
            this.age = age;
        }

        public dogs(int weight, int age, string name, string speed, int height)
        {
            this.weight = weight;
            this.age = age;
            this.name = name;
            this.speed = speed;
            this.height = height;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("weight: " + weight);
            Console.WriteLine("height: " + height);
            Console.WriteLine("age: " + age);
            Console.WriteLine("--------------");
           
        }

        public string GetName() {
            return name;
        }
        
       
    }
    
    static dogs Adddog()
    {
        Console.WriteLine("your dogs name");
        string name = Console.ReadLine();
        Console.WriteLine("your dogs weight");
        int weight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("your dogs height");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("your dogs age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("what is your dogs speed");
        string speed= Console.ReadLine();
        dogs retreval = new dogs(name, weight, height, age, speed);
        return retreval;
    }
    
    static void dograce(List<dogs> alldogs)
    {
        Console.WriteLine("wich dogs would you like to race");
        Console.WriteLine("press 1, 2 or 3");
        int answer = Convert.ToInt32(Console.ReadLine());
        if (answer == 1)
        {

            Console.WriteLine(alldogs[0].GetName());
            Console.WriteLine("this is your dog");
        }
        else if(answer == 2)
        {
            Console.WriteLine(alldogs[1].GetName());
            Console.WriteLine("This is your dog");
        }
        else if( answer == 3)
        {
            Console.WriteLine(alldogs[2].GetName());
            Console.WriteLine("This is your dog");
            Console.WriteLine("------------");
        }
        Random rand1 = new Random();
        rand1.Next(1,3);
        if(rand1.Next(1,3) == 1)
        {
            Console.WriteLine("your going upp aginst");
            Console.WriteLine(alldogs[2]);
            if(rand1 = answer)
            {

            }
        }
        
        Console.WriteLine("Type Ready to race");
        string Start = Console.ReadLine();
 
        if (Start == "Ready")
        {
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("GOOOOOO!");
        }
        int sad = 4;
        int happy = 2;
        int ok = 3;
        int loved = 1;
        Random rand = new Random();
        rand.Next(1,4);
    }


}
