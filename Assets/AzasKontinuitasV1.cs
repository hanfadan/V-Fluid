using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AzasKontinuitasV1 : MonoBehaviour
{
    public InputField InputA1;
    public InputField InputA2;
    public InputField InputV2;

    public Text Hasil;

    public float a1;
    public float a2;
    public float v2;

    // Start is called before the first frame update
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetA1Info()
    {
        a1 = float.Parse(InputA1.text);
    }
    public void GetA2Info()
    {
        a2 = float.Parse(InputA2.text);
    }
    public void GetV2Info()
    {
        v2 = float.Parse(InputV2.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = a2 * v2 / a1;

        Hasil.text = "(" + tempHasil + ")";
    }
}
