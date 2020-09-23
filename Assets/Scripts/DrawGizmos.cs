using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    private float mousePosX, mousePosZ;
    public Camera mainCamera;

    private void OnEnable()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
    }


    private void OnDrawGizmos()
    {

        if (mainCamera != null)
        {
            Vector3 mousePos = Input.mousePosition;
            float y = mousePos.y;
            Gizmos.DrawRay(mainCamera.ScreenPointToRay(mousePos));
        }
    }
}
