/*.NET 6 Development */
/* Decision */
/* Repition */
/* Sequence */

// Prototype - Defines the function (type, name and parameters)
// Definition - Codeblock
// Function Call - Make te function 
// DRY - Don't Repeat Yourself
// YAGNI - You Aren't Going To Need It

/* Variables Declarations en Object Types */
// int, string, double, float, char, bool
Console.WriteLine("Hello");
/* Calling Date and Time*/
DateUtil dateTime = new();
DateUtil.TimeOfDay();

// Console write message
Console.WriteLine("Enter your first name: ");

/* Declaration of Classes.cs */
Names names = new();

// Store Object
names.FirstName = Console.ReadLine();

/* Take userInput no Empty string allowed*/
// String Variable
Console.WriteLine("Enter your middle name: ");
string middleName = string.Empty;
middleName = Console.ReadLine();

Console.WriteLine("Enter your last name: ");
names.LastName = Console.ReadLine();

Console.WriteLine("Enter your age: ");
dateTime.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Hobby: ");
Hobbies hobby = new();
hobby.Hobby = (Console.ReadLine());

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"Hello {names.PersonID()}, Welcome to the Program.");
}
else if(!string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"Hello {names.PersonID(middleName)}, Welcome to the Program.");
}

Console.WriteLine($"You are {dateTime.Age} old. And born in {dateTime.BirthDate()}");

Console.WriteLine($"Your Hobby is: {hobby.Hobby}.");

/* Make a new list */
List<string> userInputs = new();

// Loop over the array and give output
for (int input = 0; input < userInputs.Count; input++)
{
    Console.WriteLine(userInputs[input]);
}

// Basic Assignment Operator

// Declare Size Array
int[] inputValues = new int[2];

Console.WriteLine($"Let's Calculated Something {names.FirstName}.");

Console.WriteLine("Enter two Numbers Please");

for (int num1 = 0; num1 < 1; num1++)
{
    // Allow userInput
    Console.Write("Choose a High Number: "); // Write to the console
    inputValues[num1] = Convert.ToInt32(Console.ReadLine());
}

for (int num2 = 1; num2 < inputValues.Length; num2++)
{
    Console.WriteLine("Choose a low Number: "); // Write to the console
    inputValues[num2] = Convert.ToInt32(Console.ReadLine());
}

//Print values in Fixed Array
Console.WriteLine($"Entered Numbers are: {inputValues[0]} and {inputValues[1]}");

if(int.MinValue != 0) OutputArithmeticOperators(inputValues[0], inputValues[1]);

// Void Functions - Completes a task and continues
void OutputArithmeticOperators(int num1, int num2)
{   
    /* Output Compound Assignment Arithmetic Operators */
    
    // Try - try block attempts an operation
    try
    {
        int addNum = num1 + num2;
        Console.WriteLine($"Addition: {num1} + {num2} = {addNum} ");
        num1 += num2;
        Console.WriteLine($"Compounded with += num1 Addition: {num1}");

        int subNum = num1 - num2;
        Console.WriteLine($"Subtraction: {num1} - {num2} = {subNum} ");
        num1 -= num2;
        Console.WriteLine($"Compounded with -= num1 Substraction:  {num1}");

        int multiNum = num1 * num2;
        Console.WriteLine($"Multiplication: {num1} * {num2} = {multiNum} ");
        num1 *= num2;
        Console.WriteLine($"Compounded with *= num1 Multiplication:   {num1}");

        int divNum = num1 / num2;
        Console.WriteLine($"Divide: {num1} / {num2} = {divNum} ");
        num1 /= num2;
        Console.WriteLine($"Compounded with /= num1 Divided:   {num1}");

        int modNum = num1 % num2;
        Console.WriteLine($"Modulus: {num1} % {num2} = {modNum} ");
        num1 %= num2;
        Console.WriteLine($"Compounded with %= num1 Modulus:    {num1}");

        List<int> returnedValues = new List<int>();

        foreach (int value in returnedValues) //  Iterate the List for the values
        {
            if(!int.Equals(value, 0))
            {
                returnedValues.Add(addNum);
                returnedValues.Add(subNum); 
                returnedValues.Add(multiNum); 
                returnedValues.Add(divNum); 
                returnedValues.Add(modNum);
            }
            Console.WriteLine(value);
        } 
    }
    // Catch - Catch any fatal errors or exception
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Illegal Operation. NullReference Operations: {ex.Message}");
    }
    catch (Exception)
    {
        // Throw - Kill execution of Program (CAREFULL!!)
        throw;
    }
    // Final - try or catch happend. Continue
    finally
    {
        Console.WriteLine("Continue Program");
    }
}