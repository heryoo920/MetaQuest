using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_OVRController_RayCasterButton : MonoBehaviour
{
    public EX_OVRController_RayCaster RayCaster;
    RaycastHit RayHit, ButtonHit;

    private void Start()
    {
        print("Point and Press LIndexTrigger to print Target Name");
    }
    private void Update()
    {
        RayHit = RayCaster.Get_RayHit();

        if (RayHit.collider != null)
        {
            if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
            {
                ButtonHit = RayHit;
                print($"Pointed and Clicked {RayHit.collider.name}");
            }
            if (OVRInput.GetUp(OVRInput.RawButton.LIndexTrigger))
            {
                ButtonHit = new RaycastHit();
            }
        }
        else
        {
            ButtonHit = new RaycastHit();
        }            
    }

    public RaycastHit Get_RayHit()
    {
        return RayHit;
    }

    public RaycastHit Get_ButtonHit()
    {
        return ButtonHit;
    }
}
