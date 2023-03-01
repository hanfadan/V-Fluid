using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LatihanSoal : MonoBehaviour
{
    public string[] soal, jawaban;

    public TextMeshProUGUI text_soal;

    public InputField input_jawaban;

    public GameObject feed_benar, feed_salah, bank_soal;
    public TextMeshProUGUI jawabanbenar;

    int soalKe;
    // Start is called before the first frame update
    void Start()
    {
        soalKe = soal.Length;

        soalKe = 0;
    }

    public void randomSoal()
    {
        soalKe = Random.Range(0, 3);
    }

    public void jawab()
    {
        
        if (soalKe < 2)
        {
            if (input_jawaban.text == jawaban[soalKe])
            {
                feed_benar.SetActive(true);
                feed_salah.SetActive(false);
                jawabanbenar.text = "Jawaban yang benar adalah " + jawaban[soalKe];
                StartCoroutine(HideText());
            }
            else
            {
                feed_salah.SetActive(true);
                feed_benar.SetActive(false);
            }

            input_jawaban.text = "";
        }
        }

    IEnumerator HideText()
    {
        yield return new WaitForSeconds(0.5f);
        jawabanbenar.text = "";
    }
    void Update()
    {
        text_soal.text = soal[soalKe];
    }
}
