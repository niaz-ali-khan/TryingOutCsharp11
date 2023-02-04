// See https://;aka.ms/new-console-template for more information
Console.WriteLine("Hello, World from C Sharp 11!");
bool resultOKSimple = canRegister(20); 
bool resultNotOKSimple = canRegister(10);

bool resultOKOptimized = CanRegisterShort(20);
bool resultNotOKOptimized = CanRegisterShort(10);

Console.WriteLine("");


//This project is a toy project for someone who is just coming back after a long time  to visual studio and C#
//Trying out Just list
List<string> citiesList = new List<string>();
citiesList.Add("Helsinki");
citiesList.Add("Turku");
citiesList.Add("Tampere");
citiesList.Add(null);


List<int> primeNumbers= new List<int>();
primeNumbers.Add(1);
primeNumbers.Add(3);
primeNumbers.Add(5);
primeNumbers.Add(7);


// Before - More Code

bool canRegister(int age)
{
    if (age >= 18)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// After - Less Code


bool CanRegisterShort(int age) => age >= 18;

