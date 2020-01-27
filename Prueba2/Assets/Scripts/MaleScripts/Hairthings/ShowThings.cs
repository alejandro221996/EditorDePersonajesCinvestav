using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowThings : MonoBehaviour
{
    public GameObject InventoryMenu;
    public GameObject HairTitle;
    public GameObject HairButton;
    public GameObject AccesoriesMenu;
    public GameObject AccesoriesTitle;

    public void ShowHairMenus()
    {
        if(HairButton!=null)
        {
            HairTitle.SetActive(true);
            AccesoriesMenu.SetActive(true);
            InventoryMenu.SetActive(true);
            AccesoriesTitle.SetActive(true);
        }
    }
}
