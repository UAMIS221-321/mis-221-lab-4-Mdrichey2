// Start main 
int userChoice = GetUserChoice();

int number = GetRdm();

do {
    RouteEm(userChoice);
    userChoice = GetUserChoice();
} while (userChoice !=3);
// End Main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display half triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput) {
    if(userInput== "1" || userInput== "2" || userInput== "3") {
        return true;
    }
    return false;
}

static void FullTriangle() {
    int number = GetRdm();
    int x = RdmGen();
    for(int i = 0; i < x; i++) {
        for(int j = 0; j < i; j++) {
            System.Console.Write(number);
        }
        System.Console.WriteLine(number);
    }
    PauseAction();
}

static void HalfTriangle() {
    int x = RdmGen();
    int number = GetRdm();
    int p = number;
    for(int i = 0; i < x; i++) {
        for(int j = 0; j < i; j++) {
            number = GetRdm();
            if(number==p) {
                System.Console.Write(number);
            } 
            else System.Console.Write(" ");
        }
        System.Console.WriteLine(number);
    }
    PauseAction();
}

static void Exit() {
    System.Console.WriteLine();
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        FullTriangle();
    }
    else if(menuChoice==2) {
        HalfTriangle();
    }
    else if(menuChoice!=3) {
        InputInvalid();
    }
}

static void PauseAction() {
    System.Console.WriteLine("Press a key to continue");
    Console.ReadKey();
}

static int GetRdm() {
    Random rand = new Random();
    int number = rand.Next(2);
    return number;
}

static int RdmGen() {
    Random rand = new Random();
    int x = rand.Next(3,9);
    return x;
}

static void InputInvalid() {
    System.Console.WriteLine("Invalid input try again");
    PauseAction();
}