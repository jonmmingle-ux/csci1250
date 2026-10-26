/*
* Name: jonathan mingle
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

Random rng = new Random(4000);
int choice;
// the entire do while statement for pretty much everything 
do
{
    System.Console.WriteLine("");
    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All three");
    System.Console.WriteLine("5. Quit");
    System.Console.Write("Pick 1 through 5: ");

    choice = Convert.ToInt32(Console.ReadLine());

// the loop for if its less than or more than 5 

    while (choice < 1 || choice > 5)
    {
        System.Console.WriteLine("Choose a number from 1 to 5.");
        System.Console.Write("Pick 1 through 5: ");
       choice = Convert.ToInt32(Console.ReadLine());
    } 
    // for first choice to tell what grade is its letter grade

    if (choice == 1 || choice == 4)
    {
        System.Console.WriteLine("=== The Grade Checker ===");
        int score = 0;
        do
        {
            System.Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            if (score < 0 || score > 100)
            {
                System.Console.WriteLine("Score must be a number between 0 and 100.");
            }
            // gives out the letter grade

        } while (score < 0 || score > 100);
        if (score >= 93 && score <= 100)
        {
            System.Console.WriteLine($"{score} earns an A");
        }
        if (score >= 83 && score <= 92)
        {
            System.Console.WriteLine($"{score} earns a B");
        }
        if (score >= 73 && score <= 82)
        {
            System.Console.WriteLine($"{score} earns a C");
        }
        if (score >= 64 && score <= 72)
        {
            System.Console.WriteLine($"{score} earns a D");
        }
        if (score >= 0 && score <= 63)
        {
            System.Console.WriteLine($"{score} earns an F");
        }


    }

    //for if you chose 2 will roll dice
    if (choice == 2 || choice == 4)
    {
        string rollAgain;
        int rollnum = 1;
        int winnum = 0;
        System.Console.WriteLine("=== The Dice Table ===");
        do
        {
            int roll1 = rng.Next(1, 7);
            int roll2 = rng.Next(1, 7);
            int total = roll1 + roll2;
            string specialTotal = "";

// gives something its special attribute at the end if it needs it
            if (roll1 == roll2)
            {
                specialTotal = "Doubles!";
            }

            if (roll1 == 1 && roll2 == 1)
            {
                specialTotal = "Snake eyes.";
            }

            if (total == 7 || total == 11)
            {
                specialTotal = "A winner.";
                winnum++;
            }

            System.Console.WriteLine($"Roll {rollnum}: {roll1}, and {roll2}, total {total}. {specialTotal}");
            System.Console.Write("Roll again (y/n): ");
            rollAgain = Console.ReadLine();
            rollnum++;
        } while (rollAgain == "y" || rollAgain == "Y");

        System.Console.WriteLine($"You rolled {rollnum} times and won {winnum}");
        //I hope this is acceptable for it instead of using tolower on it and also not adding anything extra for if its n or not because either way it exits the program for me, if it is not add a comment to me to let me know to do more detail in future
    }

    // for if you chose 3 to get the 5 scores 
    if (choice == 3 || choice == 4)
    {
        System.Console.WriteLine("=== The Score Report ===");
        int[] scores = new int[5];
        for (int i = 0; i < scores.Length; i++)
        {
            System.Console.Write($"Score {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

    double total = 0;
    int highestScore = scores[0];
    int passingScores = 0;
    // to find the highest score and how many are passing
    foreach (int score in scores)
        {
            total += score;
            if (score > highestScore)
            {
                highestScore = score;
            }
            if(score >= 63)
            {
                passingScores++;
            }
        }
        double averageScores = total / scores.Length;
        System.Console.WriteLine("");
        System.Console.WriteLine($"Scores entered: {scores.Length}");
        System.Console.WriteLine($"Total: {total}");
        System.Console.WriteLine($"Average: {averageScores}");
        System.Console.WriteLine($"Highest: {highestScore}");
        System.Console.WriteLine($"Passing: {passingScores} of {scores.Length}");
    }


    System.Console.WriteLine("");

} while (choice != 5);



System.Console.WriteLine("Goodbye!");