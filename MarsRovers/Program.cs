using MarsRovers.Constants;
using MarsRovers.Models;

public class Program
{
    public static void Main()
    {
        Console.Clear();

        string command;
        Command commandType = Command.Setup;

        List<string> results = new List<string>();
        Plataeu currentPlataeu = new Plataeu();
        RoverSquad currentRoverSquad = new RoverSquad();

        do
        {
            command = Console.ReadLine();
            try
            {
                if (String.IsNullOrEmpty(command))
                {
                    continue;
                }
                string[] commands;
                switch(commandType)
                {
                    case Command.Setup:
                        {
                            commands = command.Split(" ");
                            currentPlataeu = new Plataeu(int.Parse(commands[0]), int.Parse(commands[1]));
                            commandType = Command.RoverSquad;
                            break;
                        }
                    case Command.RoverSquad:
                        {
                            commands = command.Split(" ");
                            currentRoverSquad = new RoverSquad(currentPlataeu);
                            currentRoverSquad.MoveRover(int.Parse(commands[0]), int.Parse(commands[1]), Enum.Parse<Direction>(commands[2]));
                            commandType = Command.Movements;
                            break;
                        }
                    case Command.Movements:
                        {
                            foreach (char move in command)
                            {
                                currentRoverSquad.CurrentRover.Move(Enum.Parse<Movement>(move.ToString()));
                            }
                            string result = String.Format("{0} {1} {2}", currentRoverSquad.CurrentRover.X, currentRoverSquad.CurrentRover.Y, currentRoverSquad.CurrentRover.Direction);

                            results.Add(result);
                            commandType = Command.RoverSquad;
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{command}'");
                Environment.Exit(0);
            }

        } while (!String.IsNullOrEmpty(command));

        foreach(string result in results){
            Console.WriteLine(result);
        }
    }
}
