using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public float orthographicSize = 5;
    public float aspect = 1.3333f;

    // Use this for initialization
    void Start()
    {
        aspect = Camera.main.aspect;
        Camera.main.projectionMatrix = Matrix4x4.Ortho(
            -orthographicSize * aspect, orthographicSize * aspect,
            -orthographicSize, orthographicSize,
            Camera.main.nearClipPlane, Camera.main.farClipPlane
            );
    }
}