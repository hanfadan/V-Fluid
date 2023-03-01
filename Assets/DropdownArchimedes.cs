using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DropdownArchimedes : MonoBehaviour
{
    public Image background;
    public GameObject rumus, rumus1;
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
            rumus.gameObject.SetActive(true);
            rumus1.gameObject.SetActive(false);
        }
        if (drop.value == 1)
        {
            rumus.gameObject.SetActive(false);
            rumus1.gameObject.SetActive(true);
        }
        print(drop.options[drop.value].text);
    }
}
