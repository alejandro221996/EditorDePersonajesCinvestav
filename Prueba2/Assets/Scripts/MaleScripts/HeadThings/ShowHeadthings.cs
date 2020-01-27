using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHeadThings : MonoBehaviour
{
    public GameObject HatMenu;
    public GameObject EarsMenu;
    public GameObject EyesMenu;
    public GameObject HelmetMenu;
    public GameObject HeadButton;
    public GameObject FacilHair;
    public GameObject HeadAccesories;

    public void ShowHairMenus()
    {
        if (HeadButton != null)
        {
            EarsMenu.SetActive(true);
            EyesMenu.SetActive(true);
            HatMenu.SetActive(true);
            HelmetMenu.SetActive(true);
            FacilHair.SetActive(true);
            HeadAccesories.SetActive(true);
        }
    }
}
