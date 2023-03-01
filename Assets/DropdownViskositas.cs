using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DropdownViskositas : MonoBehaviour
{
    public Image background;
    public GameObject Visko1, Visko2;
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
            Visko1.gameObject.SetActive(true);
            Visko2.gameObject.SetActive(false);
        }
        if (drop.value == 1)
        {
            Visko1.gameObject.SetActive(false);
            Visko2.gameObject.SetActive(true);
        }
        print(drop.options[drop.value].text);
    }
}
