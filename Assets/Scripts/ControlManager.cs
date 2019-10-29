using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ControlManager : MonoBehaviour
{
    public Controls currentControl = Controls.MoveCamera;
    private int max = Enum.GetValues(typeof(Controls)).Length - 1;

    public void ChangeControl(int changeTo) {
        changeTo = Mathf.Clamp(changeTo, 0, max);
        currentControl = (Controls)changeTo;
    }
}
