using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour
{
    public FloorTile[] floorTile;
    public ObjectTile[] objectTile;
    public WallTile[] wallTile;

    void Start()
    {
        //LevelWriter.WriteTestLevel("Level 1");
        //LevelReader.ReadLevelTest("Assets/Levels/Level 1.txt");
        StartCoroutine(GridData.GetInstance().GenerateGridFromFile(floorTile, objectTile, wallTile, "Assets/Levels/Level 1.txt"));       
    }

}
