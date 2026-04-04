
//030426
Console.WriteLine("Hello World !");
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("you wrote your first lines of code.");
Console.WriteLine("This is the first line.");
Console.WriteLine("This is the seconds line.");

Console.WriteLine('b');
Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);

string firstname;
firstname = "Bob";
Console.WriteLine(firstname);
firstname = "Liem";
Console.WriteLine(firstname);
firstname = "Isabella";
Console.WriteLine(firstname);
firstname = "Yasmin";
Console.WriteLine(firstname);

firstname = "Bob";
int ms = 3;
decimal tmp = 34.4m;
Console.Write("Hello ");
Console.Write(firstname);
Console.Write(" You have ");
Console.Write(ms);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(tmp);
Console.Write(" Celsius.");
//040426
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoice");
Console.WriteLine(@"c\source\repos
(this is where your file goes)");

firstname = "Bob !";
string greeting = "Hello ";
string ms1 = greeting + firstname;
Console.WriteLine(ms1);
Console.WriteLine(greeting + firstname);

int version = 11;
string updateText = "Update to Windows";
string ms2 = $"{updateText}{version}";
Console.WriteLine(ms2);
Console.WriteLine($"{updateText}{version}!");
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

projectName = "ACME";
Console.WriteLine("View English output :");
Console.WriteLine($@"C:\Exercise\{projectName}\data.txt");

string englishLocation = $@"C:\Exercise\{projectName}data.txt";
string englishoutput = "View english output :";
Console.WriteLine(englishoutput + englishLocation);