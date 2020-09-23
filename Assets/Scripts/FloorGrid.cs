using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGrid
{
    FloorTile[] floorTiles;
    ObjectTile[] objectTiles;
    WallTile[] wallTiles;

    public FloorGrid(FloorTile[] _floorTiles, ObjectTile[] _objectTiles, WallTile[] _wallTiles)
    {
        floorTiles = _floorTiles;
        objectTiles = _objectTiles;
        wallTiles = _wallTiles;
    }
}
