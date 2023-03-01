using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
      Panel.SetActive(true);
    }
    public void ClosePanel()
    {
        Panel.SetActive(false);
    }
}
