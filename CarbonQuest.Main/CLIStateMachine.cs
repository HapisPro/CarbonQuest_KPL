using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public enum CLIState
{
    Welcome,
    Login,
    Signup,
    Home,
    Calculator,
    Leaderboard,
    ArticleList,
    ArticleAdd,
    ArticleDetail,
    ArticleEdit,
    ArticleDeleteConfirm
}

public enum CLITrigger
{
    Start,
    LoginSelected,
    SignupSelected,
    LoginSuccess,
    SignupSuccess,
    Logout,
    CalculatorSelected,
    LeaderboardSelected,
    ArticleSelected,
    ArticleAddSelected,
    ArticleDetailSelected,
    ArticleEditSelected,
    ArticleDeleteSelected,
    ArticleDeleteConfirmed,
    ArticleDeleteCanceled,
    BackToHome
}

public class StateTransition
{
    public CLIState CurrentState { get; }
    public CLITrigger Trigger { get; }
    public CLIState NextState { get; }

    public StateTransition(CLIState currentState, CLITrigger trigger, CLIState nextState)
    {
        Debug.Assert(Enum.IsDefined(typeof(CLIState), currentState), "Invalid Current State");
        Debug.Assert(Enum.IsDefined(typeof(CLITrigger), trigger), "Invalid Trigger");
        Debug.Assert(Enum.IsDefined(typeof(CLIState), nextState), "Invalid Next State");

        CurrentState = currentState;
        Trigger = trigger;
        NextState = nextState;
    }
}


namespace CarbonQuest.Main
{
    public class CLIStateMachine
    {
        private CLIState _currentState;

        private List<StateTransition> _transitions = new List<StateTransition>
    {
        new StateTransition(CLIState.Welcome, CLITrigger.LoginSelected, CLIState.Login),
        new StateTransition(CLIState.Welcome, CLITrigger.SignupSelected, CLIState.Signup),
        new StateTransition(CLIState.Login, CLITrigger.LoginSuccess, CLIState.Home),
        new StateTransition(CLIState.Signup, CLITrigger.SignupSuccess, CLIState.Home),
        new StateTransition(CLIState.Home, CLITrigger.CalculatorSelected, CLIState.Calculator),
        new StateTransition(CLIState.Home, CLITrigger.LeaderboardSelected, CLIState.Leaderboard),
        new StateTransition(CLIState.Home, CLITrigger.ArticleSelected, CLIState.ArticleList),
        new StateTransition(CLIState.ArticleList, CLITrigger.ArticleAddSelected, CLIState.ArticleAdd),
        new StateTransition(CLIState.ArticleList, CLITrigger.ArticleDetailSelected, CLIState.ArticleDetail),
        new StateTransition(CLIState.ArticleDetail, CLITrigger.ArticleEditSelected, CLIState.ArticleEdit),
        new StateTransition(CLIState.ArticleDetail, CLITrigger.ArticleDeleteSelected, CLIState.ArticleDeleteConfirm),
        new StateTransition(CLIState.ArticleDeleteConfirm, CLITrigger.ArticleDeleteConfirmed, CLIState.Home),
        new StateTransition(CLIState.ArticleDeleteConfirm, CLITrigger.ArticleDeleteCanceled, CLIState.ArticleDetail),
        new StateTransition(CLIState.ArticleEdit, CLITrigger.BackToHome, CLIState.Home),
        new StateTransition(CLIState.Leaderboard, CLITrigger.BackToHome, CLIState.Home),
        new StateTransition(CLIState.Calculator, CLITrigger.BackToHome, CLIState.Home),
        new StateTransition(CLIState.ArticleList, CLITrigger.BackToHome, CLIState.Home),
        new StateTransition(CLIState.ArticleAdd, CLITrigger.BackToHome, CLIState.Home),
        new StateTransition(CLIState.Home, CLITrigger.Logout, CLIState.Welcome),
    };

        public CLIStateMachine()
        {
            _currentState = CLIState.Welcome;
        }

        public CLIState GetCurrentState()
        {
            return _currentState;
        }

        public void ActivateTrigger(CLITrigger trigger)
        {
            var validTransition = _transitions.FirstOrDefault(t => t.CurrentState == _currentState && t.Trigger == trigger);

            Debug.Assert(validTransition != null, $"Tidak ada transisi valid dari state {_currentState} dengan trigger {trigger}");

            if (validTransition != null)
            {
                _currentState = validTransition.NextState;
                Console.WriteLine($"[DEBUG] State berubah ke: {_currentState}");
            }
            else
            {
                Console.WriteLine("[WARNING] Trigger tidak valid di state saat ini.");
            }
        }
    }

}
