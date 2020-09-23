using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tile : ScriptableObject
{
    public enum TileType
    {
        floor,
        obj,
        wall
    };
    public int ID;
    public Texture2D texture = null, icon;
    public TileType tileType;
}
