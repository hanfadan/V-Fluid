using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GayaArchimedes1 : MonoBehaviour
{
    public InputField InputVolume;

    public Text Hasil;
    public TextMeshProUGUI textDisplay;
    public Animator anim;
    public Animator anim1;
    public GameObject Panel;
    public GameObject Simulasi;

    public float rho = 1000f;
    public float v;
    public float g = 9.8f;
    public float mf = 250f;

    // Start is called before the first frame update
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetVolumeInfo()
    {
        v = float.Parse(InputVolume.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = 1000 * v * 9.8f;
        if (tempHasil < 0)
        {
            Panel.SetActive(true);
            Simulasi.SetActive(false);
        }
        else
        {
            Hasil.text = "" + tempHasil;
            textDisplay.GetComponent<TMP_Text>().text = "Dengan ρ<sub>f</sub> sebesar 1000 kg/m<sub>3</sub> , V<sub>bf</sub> " + v + " m<sup>3</sup>, dan g 9,8 m/s<sub>2</sub> maka menghasilkan gaya apung air " + tempHasil + " N ";

            if (tempHasil > 147000)
            {
                anim.Play("Kapal Mengapung");
                anim1.Play("archimedes");
            }
            else if (tempHasil == 147000)
            {
                anim.Play("Kapal Tengah");
                anim1.Play("archimedes-2");
            }
            else
            {
                anim.Play("Kapal Tenggelam");
                anim1.Play("archimedes-1");
            }
        }
    }
}
