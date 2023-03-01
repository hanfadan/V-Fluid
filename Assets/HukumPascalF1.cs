using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HukumPascalF1 : MonoBehaviour
{
    public InputField InputF2;
    public InputField InputA1;
    public InputField InputA2;

    public Text Hasil;

    public float f2;
    public float a1;
    public float a2;

    // Start is called before the first frame update
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetF2Info()
    {
        f2 = float.Parse(InputF2.text);
    }
    public void GetA1Info()
    {
        a1 = float.Parse(InputA1.text);
    }
    public void GetA2Info()
    {
        a2 = float.Parse(InputA2.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = (a1 * f2) / a2;

        Hasil.text = "(" + tempHasil + ")";
    }
}
