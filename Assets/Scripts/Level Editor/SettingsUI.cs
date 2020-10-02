using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SettingsUI : MonoBehaviour
{
    public TMP_InputField levelNameField;
    public Dropdown levelSizeDropdown;
    public TextMeshProUGUI labelError;
    string levelName;
    int levelSize;



    private void Start()
    {
    }

    public void Btn_Generate()
    {
        if (levelNameField.text == "")
        {
            labelError.text = "Error: Empty name field!";
            return;
        }
        else
            labelError.text = "";
        switch (levelSizeDropdown.value)
        {
            case 0:
                levelSize = 5;
                break;
            case 1:
                levelSize = 7;
                break;
            case 2:
                levelSize = 9;
                break;
            case 3:
                levelSize = 11;
                break;
            default:
                levelSize = 5;
                break;
        }
        levelName = levelNameField.text;
        Debug.Log($"{levelName} is {levelSize} big");

        GridData.GetInstance().GenerateEmptyGrid(levelSize);
        Camera cam = Camera.main;
        cam.gameObject.AddComponent<CameraController>();
        gameObject.SetActive(false);
    }


}
