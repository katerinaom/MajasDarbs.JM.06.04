// See https://aka.ms/new-console-template for more information

string greeting = "Hello, World my name is Jekaterina with variable";
int number = 555;
double decimalNumber = 15.78;
char simbol = '@';
bool answer = true;


Console.WriteLine(greeting);
Console.WriteLine(number);
Console.WriteLine(decimalNumber);
Console.WriteLine(simbol);
Console.WriteLine(answer);


Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();


int num1 = 5;
int num2 = 2;

int sum = num1 + num2;
int diff = num1 - num2;
int multiply = num1 * num2;
double divide = num1 / (double)num2;
int leftafter = num1 % num2;
num1++;
num2--;
Console.WriteLine(sum);
Console.WriteLine(diff);
Console.WriteLine(multiply);
Console.WriteLine(divide);
Console.WriteLine(leftafter);
Console.WriteLine(num1);
Console.WriteLine(num2);



Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

int num3 = 9;
int num4 = 9;



bool isEqual = num3 == num4;
bool isNotEqual = num3 != num4;
bool isLarger = num3 > num4;
bool isSmaller = num3 < num4;
bool isLargerEqual = num3 >= num4;
bool isSmallerEqual = num3 <= num4;


Console.WriteLine(isEqual);
Console.WriteLine(isNotEqual);
Console.WriteLine(isLarger);
Console.WriteLine(isSmaller);
Console.WriteLine(isLargerEqual);
Console.WriteLine(isSmallerEqual);


Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();



bool isTrue = true;
bool isFalse = false;


bool isBoth = isTrue && isFalse;
bool isEitherOne = isTrue || isFalse;
bool converted = !isTrue;


Console.WriteLine(isBoth);
Console.WriteLine(isEitherOne);
Console.WriteLine(converted);


Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();


int num5 = 5;

num5 += 2;

Console.WriteLine(num5);


num5 -= 2;

Console.WriteLine(num5);



Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();


//// 1. Pajautāt lietotjājam ievadīt savu vārdu
//Console.WriteLine("Ievadi savu vārdu ?");

//// 2. Sagaidīt lietotāja ievadi viņa vārdu
//string userName = Console.ReadLine();

//// 3. Sasveicināties ar lietotāju izmantojot viņa vārdu
//string userGreeting = "Sveiks " + userName + "!";
//Console.WriteLine(userGreeting);


//// 1. Pajautāt lietotājam ievadīt skaitli
//Console.WriteLine("Lūdzu ievadi skaitli ?");

//// 2. Sagaidīt lietotāja skaitļa ievādi
//string userNumberText = Console.ReadLine();
//int userNumber = int.Parse(userNumberText);

//// 3. Formatētā tekstā izvadīt lietotāja skaitli palilelinātu par 2
//int result = userNumber + 2;
//Console.WriteLine("Tavs skaitlis palielināts par 2: " + result);

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();


int x = -4;
int y = 9;

int absoluteNumber = Math.Abs(x);
int largest = Math.Max(x, y);
int smallest = Math.Min(x, y);

double toRound = 45.856;
double rounded = Math.Round(toRound, 2);
Console.WriteLine(absoluteNumber);
Console.WriteLine(largest);
Console.WriteLine(smallest);
Console.WriteLine(rounded);



Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

string name = "Jekaterina";
int age = 40;
Console.WriteLine("Sveiks " + name +"sveiciens dzimšanas dienā tavos" + age + "gados");
Console.WriteLine($"Sveiks {name} sveiciens dimšanas diena tavos {age} gados!");
