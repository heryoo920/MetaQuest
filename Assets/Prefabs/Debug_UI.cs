using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Debug_UI : MonoBehaviour
{
    public TMP_Text Text;

    public void Set_Message(string s)
    {
        Text.text = s;
    }
}
