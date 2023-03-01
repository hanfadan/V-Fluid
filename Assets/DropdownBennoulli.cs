using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DropdownBennoulli : MonoBehaviour
{
    public Image background;
    public GameObject Rumus1, Rumus2;
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
            Rumus1.gameObject.SetActive(true);
            Rumus2.gameObject.SetActive(false);
        }
        if (drop.value == 1)
        {
            Rumus1.gameObject.SetActive(false);
            Rumus2.gameObject.SetActive(true);
        }
    }
}
