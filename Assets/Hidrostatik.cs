using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hidrostatik : MonoBehaviour
{
    public InputField InputTinggi;

    public Text Hasil;
    public TextMeshProUGUI textDisplay;
    public Animator anim;
    public Animator anim1;
    public GameObject Panel;
    public GameObject Simulasi;

    public float massajenis = 1000f;
    public float gravitasi = 9.8f;
    public float tinggi;

    // Start is called before the first frame update
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetTinggiInfo()
    {
        tinggi = float.Parse(InputTinggi.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = 1000 * tinggi * 9.8f;
        if (tempHasil < 0)
        {
            Panel.SetActive(true);
            Simulasi.SetActive(false);
        }
        else
        {
            Hasil.text = "" + tempHasil;
            textDisplay.GetComponent<TMP_Text>().text = "Dengan massa jenis air sebesar 1000 kg/m<sup>3</sup> , gaya gravitasi 9,8 m<sup>3</sup> dan tinggi air " + tinggi + " m maka menghasilkan tekanan hidrostatik " + tempHasil + " Pa ";

            if (tempHasil < 29400)
            {
                anim.Play("TidakBocor");
                anim1.Play("hidrostatik");
            }
            else if (tempHasil >= 49000)
            {
                anim.Play("Bocor2");
                anim1.Play("hidrostatik-2");
            }
            else
            {
                anim.Play("Bocor");
                anim1.Play("hidrostatik-1");
            }
        }
    }
}
