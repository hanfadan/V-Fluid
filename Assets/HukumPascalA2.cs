using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HukumPascalA2 : MonoBehaviour
{
    public InputField InputF1;
    public InputField InputF2;
    public InputField InputA1;

    public Text Hasil;

    public float f1;
    public float f2;
    public float a1;

    // Start is called before the first frame update
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetF1Info()
    {
        f1 = float.Parse(InputF1.text);
    }
    public void GetF2Info()
    {
        f2 = float.Parse(InputF2.text);
    }
    public void GetA1Info()
    {
        a1 = float.Parse(InputA1.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = (f2*a1)/f1 ;

        Hasil.text = "(" + tempHasil + ")";
    }
}
