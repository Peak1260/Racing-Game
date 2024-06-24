using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int CarType;
    public GameObject TrackWindow;

    public void RedCar()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void PurpleCar()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }

    public void GreenCar()
    {
        CarType = 3;
        TrackWindow.SetActive(true);
    }
}
