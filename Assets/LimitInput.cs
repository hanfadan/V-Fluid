using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitInput : MonoBehaviour
{
    public InputField numberInput;
    [Range(0, 10)]
    public int range;
    [Min(0)]
    public int min;
}
