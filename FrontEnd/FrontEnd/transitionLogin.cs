using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FrontEnd.Kalender;

namespace FrontEnd
{
    public class transitionLogin
    {
        public enum State { START, LOGIN, LOGOUT,GUEST, LOGGEDIN, LOGGEDOUT, END, REGISTER };
        public enum Trigger { START, LOGIN, LOGOUT, LOGGEDIN, LOGGEDOUT,REGISTER,REGISTERED, END };

        public enum Role { GUEST, USER, ADMIN, TEST };



        public State prevState;
        public State nextState;
        public Trigger trigger;
        public transitionLogin(State prevState, State nextState, Trigger trigger)
        {
            this.prevState = prevState;
            this.nextState = nextState;
            this.trigger = trigger;
        }

        public static State getNextState(State currentState, Trigger trigger)
        {
            transitionLogin[] transitions =
            {
            new transitionLogin(State.START, State.LOGIN, Trigger.LOGIN),
            new transitionLogin(State.START, State.REGISTER, Trigger.REGISTER),
            new transitionLogin(State.START, State.END, Trigger.END),
            new transitionLogin(State.LOGIN, State.LOGGEDIN, Trigger.LOGIN),
            new transitionLogin(State.LOGIN, State.LOGGEDOUT, Trigger.LOGGEDOUT),
            new transitionLogin(State.REGISTER, State.LOGIN, Trigger.REGISTER),
            new transitionLogin(State.REGISTER, State.LOGGEDOUT, Trigger.LOGGEDOUT),
            new transitionLogin(State.LOGGEDIN, State.LOGOUT, Trigger.LOGOUT),
            new transitionLogin(State.LOGGEDOUT, State.LOGOUT, Trigger.LOGOUT),
            new transitionLogin(State.LOGOUT, State.LOGGEDOUT, Trigger.LOGGEDOUT),
            new transitionLogin(State.LOGOUT, State.LOGGEDIN, Trigger.LOGGEDIN),
            new transitionLogin(State.LOGOUT, State.END, Trigger.END),
            new transitionLogin(State.LOGGEDIN, State.END, Trigger.END),
            new transitionLogin(State.LOGGEDOUT, State.END, Trigger.END),
        };
            foreach (transitionLogin transition in transitions)
            {
                if (transition.prevState == currentState && transition.trigger == trigger)
                {
                    return transition.nextState;
                }
            }
            return currentState;
        }
        public static State getState(String input) { 
            switch (input)
            {
                case "LOGIN":
                    return State.LOGIN;
                case "REGISTER":
                    return State.REGISTER;
                case "EXIT":
                    return State.END;
        
            }
            return State.END;
        }

        public static String getRole(Role input)
        {
            String[] roles = { "GUEST", "USER", "ADMIN" };
            try
            {
                return roles[(int)input];
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
