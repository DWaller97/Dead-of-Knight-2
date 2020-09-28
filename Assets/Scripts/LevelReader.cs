using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class LevelReader
{
    public static string ReadLevelTest(string filePath)
    {

        string file = File.ReadAllText(filePath);
        char currChar;
        for(int i = 0; i < 50; i++)
        {
            for(int j = 0; j < 50; j++)
            {
               currChar = file[i * j + j];
                Debug.Log(currChar);
            }
        }
        return null;
    }



}
