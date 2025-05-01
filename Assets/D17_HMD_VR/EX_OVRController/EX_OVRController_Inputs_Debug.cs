using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_OVRController_Inputs_Debug : MonoBehaviour
{
    public EX_OVR_Debug DEBUG;
    public EX_OVRController_Inputs Inputs;

    private void Update()
    {
        string messagee = Inputs.Get_Message();
        DEBUG.Set_Message(messagee);
    }
}
