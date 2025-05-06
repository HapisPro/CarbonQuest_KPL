using CarbonQuest.Main.Menus;
using System;

namespace CarbonQuest.Main
{
    public static class Navigator
    {
        public static void Navigate(CLIStateMachine stateMachine)
        {
            var currentState = stateMachine.GetCurrentState();

            switch (currentState)
            {
                case CLIState.Welcome:
                    WelcomeMenu.Show(stateMachine);
                    break;

                case CLIState.Login:
                    LoginMenu.Show(stateMachine);
                    break;

                case CLIState.Signup:
                    SignupMenu.Show(stateMachine);
                    break;

                case CLIState.Home:
                    HomeMenu.Show(stateMachine);
                    break;

                case CLIState.Calculator:
                    CalculatorMenu.Show(stateMachine);
                    break;

                case CLIState.Leaderboard:
                    LeaderboardMenu.Show(stateMachine);
                    break;

                case CLIState.ArticleList:
                    ArticleMenu.Show(stateMachine);
                    break;

                case CLIState.ArticleAdd:
                    AddArticleMenu.Show(stateMachine);
                    break;

                case CLIState.ArticleDetail:
                    ArticleDetailMenu.Show(stateMachine);
                    break;

                case CLIState.ArticleEdit:
                    ArticleEditMenu.Show(stateMachine);
                    break;

                case CLIState.ArticleDeleteConfirm:
                    ArticleDeleteMenu.Show(stateMachine);
                    break;

                default:
                    Console.WriteLine("State tidak dikenal.");
                    break;
            }
        }
    }
}