using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("----------------- Luke's Social Network -----------------");
        Console.WriteLine("-----------------  Student ID 22206266 ------------------");
        Console.WriteLine("-------------- Buckinghamhshire University --------------");
        Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("Hello, Please type in your Username:");
String UserName = Console.ReadLine();

Console.WriteLine("1) To post a message");
Console.WriteLine("2) To post a picture");
Console.WriteLine("3) Display all posts");

String Menu = Console.WriteLine("Please enter what you would like to do:");
if(Conosle.ReadLine() = 1)
return(print(String, PostMsg));
else if (Console.ReadLine() = 2)
return(Print(String, PostPic));
else if(Console.ReadLine() = 3)
return(Print(String, Display));
{
String []PostMsg = new string[];

Console.WriteLine("Please Enter what message you would like to post:");
String Msg = Console.ReadLine();
Console.WriteLine(UserName + "Has Posted" + Msg);
LocalDataStoreSlot(PostMsg);

Console.WriteLine("would you like to go back to the menu?:");
Console.ReadLine();
if(yes)
return(print(Menu));
else if(No)
return(null);
Console.WriteLine("Would you like to post another message?:");
if(yes)
return(print(PostMsg));
else if(no)
return(null);
}
{
    String []PostPic = new string[];

Console.WriteLine("Please paste(CRTL + V) what picture you would like to post:");
String pic = Console.ReadLine();
Console.WriteLine(UserName + "Has Posted" + Msg);
LocalDataStoreSlot(PostPic);

Console.WriteLine("would you like to go back to the menu?:");
Console.ReadLine();
if(yes)
return(print(Menu));
else if(No)
return(null);
Console.WriteLine("Would you like to post another picture?:");
if(yes)
return(print(PostMsg));
else if(no)
return(null);
}
{
   
String Display = PostMsg + PostPic; 
}


String Display = PostMsg + PostPic;
    }}