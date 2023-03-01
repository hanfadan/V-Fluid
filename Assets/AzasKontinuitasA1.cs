using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AzasKontinuitasA1 : MonoBehaviour
{
    public InputField InputA1;

    public Text Hasil;

    public float A1;
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
    public void GetAInfo()
    {
        A1 = float.Parse(InputA1.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = Mathf.Round((A1 * 15 / 10 ) * 10.0f) * 0.1f;
        if (tempHasil < 0)
        {
            Panel.SetActive(true);
            Simulasi.SetActive(false);
        }
        else
        {
            Hasil.text = "" + tempHasil;
            textDisplay.GetComponent<TMP_Text>().text = "Dengan Luas penampang 1 " + A1 + " m<sup>2</sup> , Luas penampang 2 10 m<sup>2</sup>, dan Kecepatan fluida di luas penampang 1 10 m/s maka menghasilkan Kecepatan fluida di luas penampang 2 " + tempHasil + " m/s ";

            if (A1 < 10)
            {
                anim.Play("Air Mancur");
                anim1.Play("kontinuitas");
            }
            else if (A1 > 10)
            {
                anim.Play("Air Mancur cepat");
                anim1.Play("kontinuitas-1");
            }
        }

    }
}
