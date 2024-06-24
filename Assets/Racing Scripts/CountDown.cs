using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject Countdown;
    public AudioSource MarioKart;
    public GameObject LapTimer;
    public AudioSource LevelMusic;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        MarioKart.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "1";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "GO!";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        LevelMusic.Play();
        LapTimer.SetActive(true);
    }
}
