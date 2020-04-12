using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    int level = 1;
    string password;
    string secretCode;
    enum Screen { MainMenu, Password, EasterEgg, SecretCode, Win };
    Screen currentScreen = Screen.MainMenu;

	// Use this for initialization
	void Start () {
		ShowMainMenu("Ben");
	}

    // MAIN MENU

	void ShowMainMenu(string greeting) {
		Terminal.ClearScreen();
		//var greeting = "Hello Ben";
		Terminal.WriteLine("Hello " + greeting);
		Terminal.WriteLine("What would you like to hack into?");
		Terminal.WriteLine("");
		Terminal.WriteLine("Press 1 for the Big Data");
		Terminal.WriteLine("Press 2 for the Russian Gangster");
		Terminal.WriteLine("Press 3 for the Kim Jong Un's Love Diary");
		Terminal.WriteLine("");
		Terminal.WriteLine("Enter Your Selection:");
	}

	void OnUserInput(string input){
		if(input == "main menu"){
			ShowMainMenu("Ben");
            currentScreen = Screen.MainMenu;
		}
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input); // Disambung ke RunMainMenu
        }
        else if(currentScreen == Screen.Password)
        {
            RunPassword(input); // Disambung ke RunPassword
        }
        else if(currentScreen == Screen.SecretCode)
        {
            Win(input); // Semestinya disambung ke SecretCode, namun bila menang, ya bagian ini menyatakan anda menang
        }
    }

    void RunMainMenu(string input) // Sambungan dari fungsi OnUserInput
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
            currentScreen = Screen.Password;
            password = "bitcoin";
            //RunSecret();
        }
        // atas ini dulu yg direvisi ya
        else if (input == "2")
        {
            level = 2;
            StartGame();
            currentScreen = Screen.Password;
            password = "blyatiful";
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
            currentScreen = Screen.Password;
            password = "cutedictator";
        }
        else if (input == "Hit List")
        {
            print("U Waidd Heree, Viktor Got Bunch of Makarov's Hit Lists Directives...We'll be Sending Soviet Gunz and Carz on Arrival....$$$EAZYY$$$");
            StartEasterEgg();
            currentScreen = Screen.EasterEgg;
        }
        else
        {
            print("Don'd Drink Vodka too Mutchh!!");
        }
    }

    void RunPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Congratulations on Cracking the system!");
            Terminal.WriteLine("Now try to crack the secret code: ");
            if(password == "bitcoin")
            {
                currentScreen = Screen.SecretCode;
                secretCode = "blockchain";
            }
            else if (password == "blyatiful")
            {
                currentScreen = Screen.SecretCode;
                secretCode = "vodkabear";
            }
            else if (password == "cutedictator")
            {
                currentScreen = Screen.SecretCode;
                secretCode = "kimjongun";
            }
            else
            {
                Terminal.WriteLine("Sorry, Wrong secret code bro");
            }
            //RunSecret();
        }
        else
        {
            Terminal.WriteLine("Wrong Password, Please Try Again eventhough you're already in the system :)");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("You have selected Level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }

    //Ketikanku dewe
    void StartEasterEgg()
    {
        Terminal.WriteLine("U Waidd Heree, Viktor Got Bunch of Makarov's Hit Lists Directives...We'll be Sending Soviet Gunz and Carz on Arrival....$$$EAZYY$$$");
    }

	// Update is called once per frame
	void Update () {
		
	}

    void Win(string input)
    {
        if(input == secretCode)
        {
            Terminal.WriteLine("Congratulations, You just Hacked into the System!");
            currentScreen = Screen.Win;
        }
        else
        {
            Terminal.WriteLine("Sorry, Wrong Secret Code, Please Try Again bro");
        }
    }
}
