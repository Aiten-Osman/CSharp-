

int failedTimes = int.Parse(Console.ReadLine());

int evolationSum = 0;   
int evoluationCount = 0;    
int failedCount = 0;    

string input= Console.ReadLine();
string lastExercise = string.Empty;
int evolation;

while (input != "Enough")
{
    lastExercise = input;
    evolation = int.Parse(Console.ReadLine());


    if (evolation<=4)
    {
        failedCount++;

        if (failedCount == failedTimes)
        {
            Console.WriteLine($"You need a break, {failedCount} poor grades.");
            break;
        }
    }

    evoluationCount++;
    evolationSum += evolation;

    input= Console.ReadLine();  

}

if (input== "Enough")
{
    Console.WriteLine($"Average score: {(double)evolationSum / evoluationCount:f2}");
    Console.WriteLine($"Number of problems: {evoluationCount}");
    Console.WriteLine($"Last problem: {lastExercise}");
}