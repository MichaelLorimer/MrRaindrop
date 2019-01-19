using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public float orthographicSize = 5;
    public float aspect = 1.3333f;

    public static Vector3 CamPos;

    // Use this for initialization
    void Start()
    {
        //CamPos = Camera.main.tr

        aspect = Camera.main.aspect;
        Camera.main.projectionMatrix = Matrix4x4.Ortho(
            -orthographicSize * aspect, orthographicSize * aspect,
            -orthographicSize, orthographicSize,
            Camera.main.nearClipPlane, Camera.main.farClipPlane
            );
    }
}