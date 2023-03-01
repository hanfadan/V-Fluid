using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Viskositas1 : MonoBehaviour
{
    public InputField Inputluas;
    public InputField Inputkelajuan;
    public InputField Inputjarak;

    public Text Hasil;
    public TextMeshProUGUI Koefisien;

    public float a;
    public float v;
    public float l;
    public float n;

    // Start is called before the first frame update
    public void BackgroundDrop(int val)
    {
        if (val == 0)
        {
            Koefisien.text = "1";
        }
        if (val == 1)
        {
            Koefisien.text = "4";
        }

        if (val == 2)
        {
            Koefisien.text = "0.018";
        }

        if (val == 3)
        {
            Koefisien.text = "10";
        }
    }
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetluasInfo()
    {
        a = float.Parse(Inputluas.text);
    }
    public void GetkoefisienInfo()
    {
        n = float.Parse(Koefisien.text);
    }
    public void GetkelajuanInfo()
    {
        v = float.Parse(Inputkelajuan.text);
    }
    public void GetjarakInfo()
    {
        l = float.Parse(Inputjarak.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = n * a * (v / l);

        Hasil.text = "(" + tempHasil + ")";
    }
}
