using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class GridData : MonoBehaviour
{
    private static GridData instance;
    public Material transparentMaterial;

    private void Awake()
    {
        instance = this;
    }

    public static GridData GetInstance()
    {
        return instance;
    }

    public FloorGrid GenerateGrid(FloorTile[] floorTiles, ObjectTile[] objectTiles, WallTile[] wallTiles, int width, int length)
    {
        for(int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Texture2D texture = null;
                    switch (k)
                    {
                        case 0:
                            texture = floorTiles[0].texture;
                            break;
                        case 1:
                            texture = objectTiles[0].texture;
                            break;
                        case 2:
                            texture = wallTiles[0].texture;
                            break;
                    }

                    GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    newObj.transform.position = new Vector3(i, k, j);
                    newObj.transform.localScale = Vector3.one * 0.8f;
                    MeshRenderer renderer = newObj.GetComponent<MeshRenderer>();
                    if (texture == null)
                        renderer.material = transparentMaterial;
                    else
                        renderer.material.mainTexture = texture;
                }
            }
        }
        return new FloorGrid(floorTiles, objectTiles, wallTiles);
    }
}
