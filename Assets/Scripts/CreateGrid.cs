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

        GridData.GetInstance().GenerateGrid(floorTile, objectTile, wallTile, 20, 20);       
    }

}
