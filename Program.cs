// See https://aka.ms/new-console-template for more information

var list = new List<string> { "rock", "paper", "scissors" };
Random r = new Random();
int index = r.Next(list.Count);
// Console.WriteLine($"Randomly selected sign is {list[index]}");
bool gameLoop = true;
while (gameLoop)
{

  Console.Write("Are you ready to play?(y/n) ");

  char answer = Console.ReadKey().KeyChar;

  if (answer == 'y')
  {
    Console.Write("\nChoose Rock, Paper, or Scissors after the count \n Ready? 1....2....3....go!   ");

    String sign = Console.ReadLine().ToLower();
    if (sign == "rock")
    {
      if (list[index] == "rock")
      {
        Console.WriteLine(@"it's a tie, bruv
 _   _      
| | (_)     
| |_ _  ___ 
| __| |/ _ \
| |_| |  __/
 \__|_|\___|
      ");

      }
      else if (list[index] == "paper")
      {
        Console.WriteLine(@" Computer chose paper, you're the
 _                     
| |                    
| | ___  ___  ___ _ __ 
| |/ _ \/ __|/ _ \ '__|
| | (_) \__ \  __/ |   
|_|\___/|___/\___|_|   
      ");
      }
      else
        Console.WriteLine(@"
          _                       
         (_)                      
__      ___ _ __  _ __   ___ _ __ 
\ \ /\ / / | '_ \| '_ \ / _ \ '__|
 \ V  V /| | | | | | | |  __/ |   
  \_/\_/ |_|_| |_|_| |_|\___|_| ");
    }
    else if (sign == "paper")
    {
      if (list[index] == "paper")
      {
        Console.WriteLine(@"it's a tie, bruv
 _   _      
| | (_)     
| |_ _  ___ 
| __| |/ _ \
| |_| |  __/
 \__|_|\___|
      ");

      }
      else if (list[index] == "scissors")
      {
        Console.WriteLine(@"Computer chose scissors, you're the
 _                     
| |                    
| | ___  ___  ___ _ __ 
| |/ _ \/ __|/ _ \ '__|
| | (_) \__ \  __/ |   
|_|\___/|___/\___|_|   ");

      }
      else
      {
        Console.WriteLine(@"
          _                       
         (_)                      
__      ___ _ __  _ __   ___ _ __ 
\ \ /\ / / | '_ \| '_ \ / _ \ '__|
 \ V  V /| | | | | | | |  __/ |   
  \_/\_/ |_|_| |_|_| |_|\___|_|  ");

      }
    }
    else if (sign == "scissors")
    {
      if (list[index] == "scissors")
      {
        Console.WriteLine(@"it's a tie, bruv
 _   _      
| | (_)     
| |_ _  ___ 
| __| |/ _ \
| |_| |  __/
 \__|_|\___|
      ");

      }
      else if (list[index] == "rock")
      {
        Console.WriteLine(@"Computer chose rock, you're the
 _                     
| |                    
| | ___  ___  ___ _ __ 
| |/ _ \/ __|/ _ \ '__|
| | (_) \__ \  __/ |   
|_|\___/|___/\___|_|   
      ");

      }
      else
      {

        Console.WriteLine(@"You win with Scissors
    _    _
   (_)  / )
     | (_/ 
    _+/  
   //|\
  // | )
 (/  |/   _                       
         (_)                      
__      ___ _ __  _ __   ___ _ __ 
\ \ /\ / / | '_ \| '_ \ / _ \ '__|
 \ V  V /| | | | | | | |  __/ |   
  \_/\_/ |_|_| |_|_| |_|\___|_| ");
      }
    }
    else
    {
      Console.WriteLine(@"Not a valid option
             _              _ _     _ 
            | |            | (_)   | |
 _ __   ___ | |___   ____ _| |_  __| |
| '_ \ / _ \| __\ \ / / _` | | |/ _` |
| | | | (_) | |_ \ V / (_| | | | (_| |
|_| |_|\___/ \__| \_/ \__,_|_|_|\__,_|
                                      ");
    }
  }

  Console.WriteLine("Do you want to play again?");
  String answer2 = Console.ReadLine().ToLower();
  if (answer2 == "no")
  {
    gameLoop = false;
  }
}