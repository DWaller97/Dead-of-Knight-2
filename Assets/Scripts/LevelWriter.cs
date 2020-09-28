using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System.Security.Cryptography;

public class LevelWriter
{


    public static void WriteTestLevel(string name)
    {
        string longBoi = "";
        string fullPath = "Assets/Levels/" + name + ".txt";
        Directory.CreateDirectory("Assets/Levels");
        if(!File.Exists(fullPath))
            File.Create(fullPath);
        FileStream file = File.OpenWrite(fullPath);
        for(int i =0; i < 50; i++)
        {
            for(int j = 0; j < 50; j++)
            {

                if (i == 0 || j == 0 || i == 49 || j == 49)
                    longBoi += "W";
                else
                    longBoi += "F";

                if (j == 49)
                    longBoi += '\n';
            }
        }
        byte[] bytes = Encoding.ASCII.GetBytes(longBoi);
        file.Write(bytes, 0, bytes.Length);
        file.Close();
        Debug.Log("Done");
    }
}
