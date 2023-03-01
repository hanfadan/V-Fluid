using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberCounterUpdater : MonoBehaviour
{
    public NumberCounter NumberCounter;
    public Text Hasil;
    public TMP_InputField InputField;

    public void SetValue()
    {
        int value;

        if (int.TryParse(Hasil.text, out value))
        {
            NumberCounter.Value = value;
        }
    }
}