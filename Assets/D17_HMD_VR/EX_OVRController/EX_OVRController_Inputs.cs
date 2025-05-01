using Meta.WitAi.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_OVRController_Inputs : MonoBehaviour
{
    string message = "";

    void Update()
    {
        message = "Quest2 Controller:\n";

        // Left Controller
        bool X = OVRInput.Get(OVRInput.RawButton.X);
        if (X) message += $"\n{OVRInput.RawButton.X}";

        bool Y = OVRInput.Get(OVRInput.RawButton.Y);
        if (Y) message += $"\n{OVRInput.RawButton.Y}";

        bool LIndexTrigger = OVRInput.Get(OVRInput.RawButton.LIndexTrigger);
        if (LIndexTrigger) message += $"\n{OVRInput.RawButton.LIndexTrigger}";

        float LIndexAxis = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
        if (LIndexAxis != 0) message += $" = {OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger)}\n";

        bool LHandTrigger = OVRInput.Get(OVRInput.RawButton.LHandTrigger);
        if (LHandTrigger) message += $"\n{OVRInput.RawButton.LHandTrigger}"; 

        float LHandAxis = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger);
        if (LHandAxis != 0) message += $" = {OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger)}\n";

        bool LThumbstick = OVRInput.Get(OVRInput.RawButton.LThumbstick);
        if (LThumbstick) message += $"\n{OVRInput.RawButton.LThumbstick} ";

        Vector2 LThumbAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        if(LThumbAxis != new Vector2(0, 0)) message+= $" = {OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick)}\n";


        // Right Controller
        bool A = OVRInput.Get(OVRInput.RawButton.A);
        if (A) message += $"\n{OVRInput.RawButton.A}";

        bool B = OVRInput.Get(OVRInput.RawButton.B);
        if (B) message += $"\n{OVRInput.RawButton.B}";

        bool RIndexTrigger = OVRInput.Get(OVRInput.RawButton.RIndexTrigger);
        if (RIndexTrigger) message += $"\n{OVRInput.RawButton.RIndexTrigger}";

        float RIndexAxis = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
        if (RIndexAxis != 0) message += $" = {OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger)}\n";

        bool RHandTrigger = OVRInput.Get(OVRInput.RawButton.RHandTrigger);
        if (RHandTrigger) message += $"\n{OVRInput.RawButton.RHandTrigger}";

        float RHandAxis = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
        if (RHandAxis != 0) message += $" = {OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger)}\n";

        bool RThumbstick = OVRInput.Get(OVRInput.RawButton.RThumbstick);
        if (RThumbstick) message += $"\n{OVRInput.RawButton.RThumbstick}";

        Vector2 RThumbAxis = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        if (RThumbAxis != new Vector2(0, 0)) message += $" = {OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick)}\n";

        //DEBUG.Set_Message(message);
    }

    public string Get_Message()
    {
        return message;
    }
}
