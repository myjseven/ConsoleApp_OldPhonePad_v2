// See https://aka.ms/new-console-template for more information
using ConsoleApp_OldPhonePad_v2.Classes;

HelperClass helpers = new HelperClass();

string output = helpers.OldPhonePad("33#");
Console.WriteLine(output);

output = helpers.OldPhonePad("227*#");
Console.WriteLine(output);

output = helpers.OldPhonePad("4433555 555666#");
Console.WriteLine(output);

output = helpers.OldPhonePad("8 88777444666*664#");
Console.WriteLine(output);

output = helpers.OldPhonePad("222 2 22#");
Console.WriteLine(output);

output = helpers.OldPhonePad("77777777777777 7#");
Console.WriteLine(output);