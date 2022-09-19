
Console.WriteLine("Enter a Number");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu


int result = userNum % 2;

//kui on paaris, siis on tulemus 0 ja on paaritu
//== märk tähendab, et on võrdne
//!= märk tähendab, et ei ole võrdne

if (result != 0) 
{
    Console.WriteLine("User number is odd.");
}else
{
    Console.WriteLine("User number is even.");
}