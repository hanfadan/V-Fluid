using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MassaJenis : MonoBehaviour
{
    public InputField InputVolume;
    public InputField InputMassa;

    public Text Hasil;
    public TextMeshProUGUI textDisplay;
    public Animator anim;
    public Animator anim1;
    public GameObject Panel;
    public GameObject Simulasi;

    public float volume;
    public float massa;
    // Start is called before the first frame update
    public void Start()
    {
        Hasil.text = "";
    }
    public void GetVolumeInfo()
    {
        volume = float.Parse(InputVolume.text);
    }
    public void GetMassaInfo()
    {
        massa = float.Parse(InputMassa.text);
    }
    public void CalculateHasil()
    {
        float tempHasil = Mathf.Round(massa / volume * 10.0f) *0.1f;
        if (tempHasil < 0)
        {
            Panel.SetActive(true);
            Simulasi.SetActive(false);
        }
        else
        {
            Hasil.text = "" + tempHasil;
            textDisplay.GetComponent<TMP_Text>().text = "Dengan massa minyak sebesar " + massa + " kg dan volume " + volume + " m<sup>3</sup> maka menghasilkan massa jenis " + tempHasil + " kg/m<sup>3</sup> ";
            if (tempHasil < 1000)
            {
                anim.Play("MinyakPisah");
                anim1.Play("massa jenis");
            }
            else
            {
                anim.Play("MinyakNyatu");
                anim1.Play("massa jenis-1");
            }
        }
    }


}
