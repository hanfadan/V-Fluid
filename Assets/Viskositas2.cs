using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Viskositas2 : MonoBehaviour
{

    public Text Hasil;
    public Text Koefisien;
    public TextMeshProUGUI textDisplay;
    public Animator anim;
    public Animator anim1;
    public GameObject Panel;
    public GameObject Simulasi;

    public float n;

    // Start is called before the first frame update
    public void BackgroundDrop(int val)
    {
        if (val == 1)
        {
            Koefisien.text = "1.8";
        }
        if (val == 2)
        {
            Koefisien.text = "4";
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
    public void GetkoefisienInfo()
    {
        n = float.Parse(Koefisien.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = 6 * n * 1 * 5;
        if (tempHasil < 0)
        {
            Panel.SetActive(true);
            Simulasi.SetActive(false);
        }
        else
        {
            Hasil.text = "" + tempHasil;
            textDisplay.GetComponent<TMP_Text>().text = "Dengan koefisien sebesar " + n + " Pa , Jari-jari 1 m, dan kelajuan 5 m/s maka menghasilkan gaya tekan " + tempHasil + " N ";

            if (n == 1.8f)
            {
                anim.Play("KueJatuh-Air");
                anim1.Play("viskositas-1");
            }
            else if (n == 4f)
            {
                anim.Play("KueJatuh-Darah");
                anim1.Play("viskositas-2");
            }
            else if (n == 10f)
            {
                anim.Play("KueJatuh");
                anim1.Play("viskositas");
            }
        }
    }
}
