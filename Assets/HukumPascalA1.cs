using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HukumPascalA1 : MonoBehaviour
{
    public InputField InputA1;

    public Text Hasil;
    public TextMeshProUGUI textDisplay;
    public Animator anim;
    public Animator anim1;
    public GameObject Panel;
    public GameObject Simulasi;

    public float f2 = 13300f;
    public float a2 = 15f;
    public float a1;

    // Start is called before the first frame update
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetA1Info()
    {
        a1 = float.Parse(InputA1.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = Mathf.Round((13300 * a1) / 15 * 10.0f) * 0.1f;
        if (tempHasil < 0)
        {
            Panel.SetActive(true);
            Simulasi.SetActive(false);
        }
        else
        {
            Hasil.text = "" + tempHasil;
            textDisplay.GetComponent<TMP_Text>().text = "Dengan F2 sebesar 13300 N , A1 " + a1 + " m<sup>2</sup>, dan A2 15 N maka menghasilkan gaya pada penampang 1 " + tempHasil + " N ";

            if (a1 < 15)
            {
                anim.Play("Dongkrak");
                anim1.Play("pascal-1");
            }
            else if (a1 > 15)
            {
                anim.Play("DongkrakJatuh");
                anim1.Play("pascal");
            }
        }
    }
}
