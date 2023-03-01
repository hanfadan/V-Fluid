using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpTextMassaJenis : MonoBehaviour
{

    public string Massa;
    public string Volume;
    public InputField inputMassa;
    public InputField inputVolume;
    public Text textDisplay;

    public void StoreName()
    {
        Massa = inputMassa.GetComponent<Text>().text = Massa.ToString();
        Volume = inputVolume.GetComponent<Text>().text = Volume.ToString();
        textDisplay.GetComponent<Text>().text = "Dengan massa minyak sebesar" + Massa + "dan volume " + Volume;
    }
}
