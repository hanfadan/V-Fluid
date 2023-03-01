using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DropDownKontinuitas : MonoBehaviour
{
    public Image background;
    public GameObject a1, a2,v1, v2;
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
            v1.gameObject.SetActive(false);
            v2.gameObject.SetActive(false);
        }
        if (drop.value == 1)
        {
            a1.gameObject.SetActive(false);
            a2.gameObject.SetActive(true);
            v1.gameObject.SetActive(false);
            v2.gameObject.SetActive(false);
        }
        if (drop.value == 2)
        {
            a1.gameObject.SetActive(false);
            a2.gameObject.SetActive(false);
            v1.gameObject.SetActive(true);
            v2.gameObject.SetActive(false);
        }
        if (drop.value == 3)
        {
            a1.gameObject.SetActive(false);
            a2.gameObject.SetActive(false);
            v1.gameObject.SetActive(false);
            v2.gameObject.SetActive(true);
        }
        print(drop.options[drop.value].text);
    }
}
