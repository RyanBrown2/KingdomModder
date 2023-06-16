using System;
using System.IO;

/// <summary>
/// Summary description for Class1
/// </summary>
public class FileHandler
{

	public FileHandler()
	{
	}

	public void openFile(string fileDir)
	{
		byte[] data = File.ReadAllBytes(fileDir);
		Console.Write(data);
    }
}
