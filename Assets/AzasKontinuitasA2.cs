using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AzasKontinuitasA2 : MonoBehaviour
{
    public InputField InputA1;
    public InputField InputV1;
    public InputField InputV2;

    public Text Hasil;

    public float a1;
    public float v1;
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
    public void GetV1Info()
    {
        v1 = float.Parse(InputV1.text);
    }
    public void GetV2Info()
    {
        v2 = float.Parse(InputV2.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = a1 * v1 / v2;

        Hasil.text = "(" + tempHasil + ")";
    }
}
