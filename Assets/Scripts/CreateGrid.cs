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
        LevelReader.ReadLevelTest("Assets/Levels/Level 1.txt");
        GridData.GetInstance().GenerateGrid(floorTile, objectTile, wallTile, 20, 20);       
    }

}
