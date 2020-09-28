using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.XR.WSA.Input;
using System.IO;

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

    public IEnumerator GenerateGridFromFile(FloorTile[] floorTiles, ObjectTile[] objectTiles, WallTile[] wallTiles, string filePath)
    {
        string file = File.ReadAllText(filePath);
        char currChar;
        Texture2D texture;

        for (int charPos = 0, x = 0, z = 0; charPos < file.Length; charPos++, x++)
        {
            texture = null;
            currChar = file[charPos];
            if (currChar == '\n')
            {
                z++;
                x = -1;

            }
            else {
                switch (currChar)
                {
                    case 'W':
                        texture = wallTiles[0].texture;
                        break;
                    case 'F':
                        texture = floorTiles[0].texture;
                        break;
                }
                GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                newObj.transform.position = new Vector3(z, 0, x);
                newObj.transform.localScale = Vector3.one;
                MeshRenderer renderer = newObj.GetComponent<MeshRenderer>();
                if (texture == null)
                    renderer.material = transparentMaterial;
                else
                    renderer.material.mainTexture = texture;
            }
            yield return new WaitForSeconds(0.0002f);

        }

        
        //return new FloorGrid(floorTiles, objectTiles, wallTiles);
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
