using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;

public class EX_OVR_Debug : MonoBehaviour
{
    public GameObject OVRCamera;
    public Canvas canvas;
    public TMP_Text Text;

    private void Start()
    {
        if (OVRCamera == null)
        {
            OVRCamera = GameObject.Find("OVRPlayerController/OVRCameraRig/TrackingSpace/CenterEyeAnchor");
        }
        if(canvas == null)
        {
            canvas = transform.Find("Canvas").GetComponent<Canvas>();
        }
        if(Text == null)
        {
            Text = transform.Find("Canvas/Panel/Text (TMP)").GetComponent<TMP_Text>();
        }
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        canvas.worldCamera = OVRCamera.GetComponent<Camera>();
    }

    public void Set_Message(string s)
    {
        print($"DEBUG: {s}");
        Text.text = s;
    }
}
