using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HukumBernoulliP1 : MonoBehaviour
{
    public InputField InputRho;

    public Text Hasil;

    public float rho;
    public TextMeshProUGUI textDisplay;
    public Animator anim;
    public Animator anim1;
    public GameObject Panel;
    public GameObject Simulasi;

    // Start is called before the first frame update
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetRhoInfo()
    {
        rho = float.Parse(InputRho.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = rho/ 2 * 40 * (240*240 - 200*200) /1000;
        if (tempHasil < 0)
        {
            Panel.SetActive(true);
            Simulasi.SetActive(false);
        }
        else
        {
            Hasil.text = "" + tempHasil;
            textDisplay.GetComponent<TMP_Text>().text = "Dengan luas sayap pesawat " + 40 + " m<sup>2</sup> , kecepatan aliran udara 240 dan 200" + " m/s, dan massa jenis udara " + rho + " kg/m<sup>3</sup> maka gaya angkat pesawat " + tempHasil + " kN ";

            if (tempHasil < 1000)
            {
                anim.Play("PesawatTerbang-turun");
                anim1.Play("hitungan-bernoulli-1");
            }
            else if (tempHasil > 1100)
            {
                anim.Play("PesawatTerbang-naik");
                anim1.Play("hitungan-bernoulli-2");
            }
            else
            {
                anim.Play("PesawatTerbang");
                anim1.Play("hitungan-bernoulli");
            }
        }
    }
}
