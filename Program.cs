/*Rafael Manzo
Mini 6 push to GitHub.
10/20/2022*/


int number01;
int number02;
bool playover = true;


while (playover)
{
    Console.WriteLine("Hello, enter a number.");
    string userinput = Console.ReadLine();
    bool anumber = Int32.TryParse(userinput, out number01);
    if (anumber)
    {
        if (number01 % 2 == 0)
        {
            Console.WriteLine("your number is even.");
        }
        else
        {
            Console.WriteLine("this one is odd... hmm.");
        }
        Console.WriteLine("would you like to play again? type no to quit or any key to play again.");
        string answer01 = Console.ReadLine();
        if (answer01 == "no")
        {
            playover = false;
        }
    }
    else
    {
        Console.WriteLine("doesn't work, try again.");
    }
}