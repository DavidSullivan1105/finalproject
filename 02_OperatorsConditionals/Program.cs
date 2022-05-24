//OPERATORS

//ARITHMETIC OPERATORS

//ADDITION
int intA = 22;
int intB = 13;

int sum = intA + intB;
sum += 7;
//console.WriteLine(sum);

//Subtraction
int difference = intA - intB;
difference -= -7;

//Console.WriteLine(difference);

//Multiplication
int product = intA * intB;
product *= 2;

//Console.WriteLine(product);

//Division
int quotient = intA / intB;
Console.WriteLine(quotient); // outcome is 1 because ints cant have decimal places

//Modulus

int remainder = intA % intB;

//Dates
DateTime today = DateTime.Now;
DateTime someOtherDay = new DateTime(1978, 1, 1);
TimeSpan timeSpan= today - someOtherDay;

//Console.WriteLine(timeSpan);

//Comparison Operators

int age = 25;
string userName = "Harry";

bool equals = age == 41; //false
bool isCorrectUserName = userName == "Lloyd"; //false

bool notEqual = age != 30; //true
bool isNotUser = userName != "Darryl";

bool greaterThan = age > 12;// true
bool lessThan = age < 98;// true
bool greaterThanOrEqual = age >= 2345;//false
bool lessThanOrEqual = age <= 1;//false

// || or
// && and

bool trueValue = true;
bool falseValue = false;

bool trueAndFalse = trueValue && falseValue; // false
bool trueOrTrue = trueValue || falseValue; // true

int xyz = 10;
int abc = 12;

if(xyz > 9 && abc < 14) {
    Console.WriteLine(true);

}


//CONDITIONALS

//IF STATEMENTS

bool isHungry = true;

if (isHungry == true){
    Console.WriteLine("Eat something");
}

if (isHungry && age >= 21){
    Console.WriteLine("eat something");
}


//IF ELSE STATEMENT

bool tpsReportsAreFinished = true;

if (tpsReportsAreFinished){
    Console.WriteLine("You dont need to work Saturday");
}
else {
    Console.WriteLine("We're gonna need you to come in on Saturday.");
}

//ELSE IF 

if (tpsReportsAreFinished){
    Console.WriteLine("You dont need to work Saturday");
} else if (age >= 21){
    Console.WriteLine("get slammered!!!");
}
else
 {
    Console.WriteLine("We're gonna need you to come in on Saturday.");
}


tpsReportsAreFinished = false;
bool bossDoesntCare = true;

if (tpsReportsAreFinished)
{
    Console.WriteLine("dont come in";)
}
else
{
    if(bossDoesntCare){
        Console.WriteLine("dont come in");
    }
    else
    {
        Console.WriteLine("come in stupid");
    }
}


//SWITCH CASES

int input= 1;

switch (input)
{
    case 1:
        Console.WriteLine("its a 1");
        break;
    case 2:
        Console.WriteLine("its a 2");
        break;
    case 3:
        Console.WriteLine("its a 3");
        break;
    default:
        Console.WriteLine("i dunno");
        break;
}


//TERNARIES

// bool Variable = Conditional ? output_if-true: output-if-false;

age = 35;

bool canDrinkAlcohol= (age >= 21) ? true : false;
string reaction = (age >= 21) ? "hooray" : "bummer";