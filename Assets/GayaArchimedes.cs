using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GayaArchimedes : MonoBehaviour
{
    public InputField Inputmf;
    public InputField Inputg;

    public Text Hasil;

    public float mf;
    public float g;

    // Start is called before the first frame update
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetmfInfo()
    {
        mf = float.Parse(Inputmf.text);
    }
    public void GetgInfo()
    {
        g = float.Parse(Inputg.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = mf * g;

        Hasil.text = "(" + tempHasil + ")";
    }
}
