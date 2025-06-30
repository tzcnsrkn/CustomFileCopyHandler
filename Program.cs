string[] fileNames = {"FileA.txt", "FileB.txt", "FileC.txt"};
string targetPath = @"/mnt/destination";

foreach (var fileName in fileNames)
{
    File.Copy(@$"files/{fileName}", @$"{targetPath}/{fileName}", true);
}
Console.WriteLine("Files are succesfully copied.");

Thread.Sleep(300000);