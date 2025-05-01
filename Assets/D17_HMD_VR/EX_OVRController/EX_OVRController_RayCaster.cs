using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class EX_OVRController_RayCaster : MonoBehaviour
{
    //public Transform EyeAnchor;
    public Transform Controller;
    public bool isDrawLine = true;
    public int rayLength = 100; // ray가 도달하는 거리

    LineRenderer LineRenderer;
    Color LineColor;
    public Color DefaultColor, HitColor;
    public Material LineMaterial;

    Vector3 LineStartPoint, LineEndPoint;
    float lineRendererOffset = 0.1f; // distance from the controller
    public Transform HitPointMarker;

    RaycastHit RayHit;

    private void Start()
    {
        if(Controller == null)
        {
            Controller = GameObject.Find("OVRPlayerController/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRControllerPrefab").transform;
        }
        LineRenderer = GetComponent<LineRenderer>();
        LineRenderer.material = LineMaterial;
        LineRenderer.material.SetColor("_EmissionColor", DefaultColor);
        LineRenderer.startWidth = 0.005f;
        LineRenderer.endWidth = 0.005f;
    }

    void Update()
    {
        RaycastHit hit;
        // https://docs.unity3d.com/2022.3/Documentation/ScriptReference/Physics.Raycast.html
        if (Physics.Raycast(Controller.position, Controller.forward, out hit, rayLength))
        {
            LineColor = HitColor;
            LineEndPoint = hit.point;
            DisplayHitPointMarker(true);
        }
        else
        {
            LineColor = DefaultColor;
            LineEndPoint = Controller.transform.position + Controller.transform.forward * rayLength;
            DisplayHitPointMarker(false);
        }

        if (isDrawLine)
        {
            DrawLine();
        }
        RayHit = hit;
    }

    void DrawLine()
    {
        LineStartPoint = Controller.transform.position + Controller.transform.forward * lineRendererOffset;
        LineRenderer.material.SetColor("_EmissionColor", LineColor);
        LineRenderer.SetPosition(0, LineStartPoint);
        LineRenderer.SetPosition(1, LineEndPoint);
    }

    void DisplayHitPointMarker(bool isDisplay)
    {
        if (isDisplay)
        {
            HitPointMarker.gameObject.SetActive(true);
            HitPointMarker.position = RayHit.point;
            HitPointMarker.up = RayHit.normal;
        }
        else
        {
            HitPointMarker.gameObject.SetActive(false);
        }
    }

    public RaycastHit Get_RayHit()
    {
        return RayHit;
    }
}
