using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_Teleport : MonoBehaviour
{
    public Transform OVRPlayer;
    public EX_OVRController_RayCaster RayCaster;
    Vector3 HitPoint, TeleportPoint;
    bool isTeleport = false;

    private void Start()
    {
        if(OVRPlayer == null)
        {
            OVRPlayer = GameObject.Find("OVRPlayerController").transform;
        }       
    }

    private void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            RaycastHit RayHit = RayCaster.Get_RayHit();
            if (RayHit.collider != null && RayHit.collider.gameObject.tag == "Teleportable")
            {
                HitPoint = RayHit.point;
                TeleportPoint = HitPoint + Vector3.up;
                float dist = Vector3.Distance(OVRPlayer.position, TeleportPoint);
                if (dist > 1)
                {
                    isTeleport = true;
                }
            }
            
        }

        if (isTeleport)
        {
            var player = OVRPlayer.GetComponent<OVRPlayerController>();
            player.enabled = false;
            OVRPlayer.position = Vector3.Lerp(OVRPlayer.position, TeleportPoint, 0.02f);
            float dist = Vector3.Distance(OVRPlayer.position, TeleportPoint);
            if(dist < 0.5f)
            {
                isTeleport = false;
                player.enabled = true;
            }
        }
    }
}
