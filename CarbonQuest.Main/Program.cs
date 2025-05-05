using System;
using CarbonQuest.Main;

class Program
{
    static void Main(string[] args)
    {
        CLIStateMachine stateMachine = new CLIStateMachine();

        while (true)
        {
            // Navigasi berdasarkan state
            Navigator.Navigate(stateMachine);
        }
    }
}
