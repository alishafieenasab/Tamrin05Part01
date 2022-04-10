using System.IO;
string? filePath = @"C:\Users\Ali\source\repos\Tamrin05Part01";
string? destFilePath = @"C:\Users\Ali\source\repos\Tamrin05Part01\Archive";
try
{
    File.Copy(filePath, destFilePath, false);
    Console.WriteLine("File Copied Successfully!");
    Console.WriteLine("Do you want to make your file secure from writing?y/n");
    var op = Console.ReadLine();
    if (op == "y")
    {
        File.SetAttributes(destFilePath, (new FileInfo(destFilePath)).Attributes | FileAttributes.ReadOnly);
    }
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine("The Directory Doesn't Found!");
}
catch (IOException ex)
{
    Console.WriteLine("The File already exist");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Unable To Write on The File");
}
catch
{
    Console.WriteLine("There is an Unknowen Error!");
}