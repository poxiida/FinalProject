using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HowToPlayManager : MonoBehaviour
{
    public GameObject howToPlayPanel;

    public void ShowHowToPlay()
    {
        howToPlayPanel.SetActive(true);
    }
}
