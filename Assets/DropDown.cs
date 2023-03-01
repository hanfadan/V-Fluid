using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    public Image background;
    public GameObject a1, a2, f1, f2;
    public void PrintData(string text)
    {
        print(text);
    }

    public void GetValueFromSlide(Slider sli)
    {
        print(sli.value);
    }

    public void BackgroundDrop(TMP_Dropdown drop)
    {
        if (drop.value == 0)
        {
            a1.gameObject.SetActive(true);
            a2.gameObject.SetActive(false);
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(false);
        } 
        if (drop.value == 1)
        {
            a1.gameObject.SetActive(false);
            a2.gameObject.SetActive(true);
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(false);
        }

        if (drop.value == 2)
        {
            a1.gameObject.SetActive(false);
            a2.gameObject.SetActive(false);
            f1.gameObject.SetActive(true);
            f2.gameObject.SetActive(false);
        }

        if (drop.value == 3)
        {
            a1.gameObject.SetActive(false);
            a2.gameObject.SetActive(false);
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(true);
        }
        print(drop.options[drop.value].text);
    }
}
