using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_OVRController_RayCasterButton_Debug : MonoBehaviour
{
    public EX_OVRController_RayCaster RayCaster;
    public EX_OVRController_RayCasterButton RayCasterButton;
    public EX_OVR_Debug DEBUG;

    private void Update()
    {
        RaycastHit buttonHit = RayCasterButton.Get_ButtonHit();
        if(buttonHit.collider != null)
        {
            DEBUG.Set_Message(buttonHit.collider.name);
        }
        else
        {
            DEBUG.Set_Message("Point and Press LIndexTrigger to print Target Name");
        }

            RaycastHit rayHit = RayCaster.Get_RayHit();
        if(rayHit.collider == null)
        {
            DEBUG.Set_Message("Point and Press LIndexTrigger to print Target Name");
        }
    }
}
