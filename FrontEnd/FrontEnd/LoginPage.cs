using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;

namespace FrontEnd
{
    internal class LoginPage
    {
        private user currentUser;
        private ForumPage forums;
        private transitionLogin.State currentState = transitionLogin.State.START;
        

        public LoginPage()
        {
            this.currentUser = null;
            this.forums = new ForumPage();
        }

        public void Display()
        {
            while (currentState != transitionLogin.State.LOGGEDOUT)
            {
                Console.Clear();
                DisplayMenu(currentState);

                if (currentState == transitionLogin.State.START)
                {
                    string input = Console.ReadLine()?.ToUpper();
                    HandleStartInput(input);
                }

                switch (currentState)
                {
                    case transitionLogin.State.LOGIN:
                        HandleLoginInput(null);
                        break;
                    case transitionLogin.State.REGISTER:
                        HandleRegisterInput(null);
                        break;
                    case transitionLogin.State.LOGGEDIN:
                        if (currentUser.role == transitionLogin.getRole(transitionLogin.Role.USER).ToLower())
                        {
                            forums.display();
                            currentState = transitionLogin.getNextState(currentState, transitionLogin.Trigger.LOGOUT);
                            break;
                        }else if (currentUser.role == transitionLogin.getRole(transitionLogin.Role.ADMIN).ToLower())
                        {
                            forums.display();
                            currentState = transitionLogin.getNextState(currentState, transitionLogin.Trigger.LOGOUT);
                            break;
                        }
                        break;
                }
            }
        }


        private void DisplayMenu(transitionLogin.State state)
        {
            Console.WriteLine(currentState.ToString());
            switch (state)
            {
                case transitionLogin.State.START:
                    Console.WriteLine("Welcome to the application!");
                    Console.WriteLine(" - LOGIN: Log in to your account");
                    Console.WriteLine(" - REGISTER: Register a new account");
                    Console.WriteLine(" - EXIT: Exit the program");
                    Console.WriteLine("Please enter your choice:");
                    break;
                case transitionLogin.State.LOGIN:
                    Console.WriteLine("Please enter your login credentials:");
                    break;
                case transitionLogin.State.REGISTER:
                    Console.WriteLine("Please enter your registration details:");
                    break;
                case transitionLogin.State.LOGGEDIN:
                    Console.WriteLine("Welcome, {0}!", currentUser.username);
                    forums.display();
                    break;
            }
        }

        private void HandleStartInput(string input)
        {
            switch (input)
            {
                case "LOGIN":
                    currentState = transitionLogin.State.LOGIN;
                    break;
                case "REGISTER":
                    currentState = transitionLogin.State.REGISTER;
                    break;
                case "EXIT":
                    currentState = transitionLogin.State.END;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        private void HandleLoginInput(string input)
        {
            if (currentUser != null)
            {
                Console.WriteLine("You are already logged in.");
                return;
            }

            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            user result = Login(username, password);
            if (result != null)
            {
                currentUser = result;
              
                Console.WriteLine("Login successful! Welcome, {0}", currentUser.username);
                currentState = transitionLogin.getNextState(currentState,transitionLogin.Trigger.LOGIN);
            }
            else
            {
                Console.WriteLine("Login failed. Please try again.");
            }
        }

        private void HandleRegisterInput(string input)
        {
            if (currentUser != null)
            {
                Console.WriteLine("You are already logged in.");
                return;
            }

            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Role :" );
             string role = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Confirm Password: ");
            string confirmPassword = Console.ReadLine();

            if (!password.Equals(confirmPassword))
            {
                Console.WriteLine("Passwords do not match. Please try again.");
                return;
            }



            user result = Register(username, password,role);
            if (result != null)
            {
                currentUser = result;
                currentState = transitionLogin.State.START;
            }
            else
            {
                Console.WriteLine("Registration failed. Please try again.");
            }
        }



        public user Login(String username, String password)
        {
            client<user> client = new client<user>();
            var rsult = client.Post("https://localhost:7238/api/User/Login", new user { username = username, password = password }); // fetch in clinet

            try
            {
                if (rsult != null)
                {
                    this.currentUser = JsonConvert.DeserializeObject<user>(rsult);
                    return currentUser;
                }
            } catch (Exception e)
            {
                return null;
            }
          
            return null;
        }

        public user Register(String username, String password, String role)
        {
            client<user> client = new client<user>();
            string rsult = client.Post("https://localhost:7238/api/User/Register", new user { username = username, password = password, role = role }); // fetch in clinet
            try
            {
                if (rsult != null)
                {
                    this.currentUser = JsonConvert.DeserializeObject<user>(rsult);
                    return currentUser;
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;
        }
    }
}
