using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour
{
    public GameObject greenButton;
    public int cashValue;

    void Update()
    {
        cashValue = GlobalCash.TotalCash;
        if (cashValue >= 600)
        {
            greenButton.GetComponent<Button>().interactable = true;
        }
    }

    public void GreenUnlock()
    {
        greenButton.SetActive(false);
        cashValue -= 600;
        GlobalCash.TotalCash -= 600;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        PlayerPrefs.SetInt("GreenBought", 600);
    }
}
