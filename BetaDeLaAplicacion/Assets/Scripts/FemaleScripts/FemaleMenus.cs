using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemaleMenus : MonoBehaviour
{
    //LegsButton
    public GameObject UpperArmorMenu;
    public GameObject BootsMenu;
    public GameObject SkirtsMenu;
    public GameObject PantsMenu;
    //
    //ArmsButton;

    public GameObject GlovesMenu;
    public GameObject GauntletsMenu;
    public GameObject ShouldersMenu;
    //
    //BodyButton
    public GameObject ArmorMenu;
    public GameObject TorsoMenu;
    public GameObject DressesMenu;
    public GameObject BAccesoriesMenu;
    public GameObject TopsMenu;
    //
   //HairButton 
    public GameObject HairMenu;
    public GameObject FrontHair;
    public GameObject BackHair;
    //
    //HeadButton
    public GameObject HatMenu;
    public GameObject EarsMenu;
    public GameObject EyesMenu;
    public GameObject HeadAccesories;
    public GameObject HairAccesories;
    //
   


    public void MostrarMenu(int MenuSelected)
    {
        switch (MenuSelected)
        {
            case 1://--------------------------1=HairMenus

                HideMenus();
                HairMenu.SetActive(true);
                FrontHair.SetActive(true);
                BackHair.SetActive(true);

                break;

            case 2://---------------------2=HeadMenus

                HideMenus();
                EyesMenu.SetActive(true);
                EarsMenu.SetActive(true);
                HairAccesories.SetActive(true);      
                HeadAccesories.SetActive(true);
                HatMenu.SetActive(true);


                break;
            case 3://---------------------3=BodyMenus

                HideMenus();
                ArmorMenu.SetActive(true);
                TopsMenu.SetActive(true);
                DressesMenu.SetActive(true);
                BAccesoriesMenu.SetActive(true);
                TorsoMenu.SetActive(true);
                break;
            case 4:

                HideMenus();
                GauntletsMenu.SetActive(true);
                ShouldersMenu.SetActive(true);
                GlovesMenu.SetActive(true);
                //-----HAIRHIDE

                break;
            case 5:

                HideMenus();
                UpperArmorMenu.SetActive(true);
                BootsMenu.SetActive(true);
                PantsMenu.SetActive(true);
                SkirtsMenu.SetActive(true);

                break;
            default:
                break;


        }
    }
    public void HideMenus()
    {
        //-----LEGSHIDE
        UpperArmorMenu.SetActive(false);
        BootsMenu.SetActive(false);
        PantsMenu.SetActive(false);
        SkirtsMenu.SetActive(false);
        //-----HAIRHIDE
        HairMenu.SetActive(false);
       FrontHair.SetActive(false);
        BackHair.SetActive(false);
        //-----BODYHIDE
        ArmorMenu.SetActive(false);
        TopsMenu.SetActive(false);
        TorsoMenu.SetActive(false);
        DressesMenu.SetActive(false);
        BAccesoriesMenu.SetActive(false);
        //------HEADHIDE
        EyesMenu.SetActive(false);
        EarsMenu.SetActive(false);
        HairAccesories.SetActive(false);
        HeadAccesories.SetActive(false);
        HatMenu.SetActive(false);
        //-----ARMHIDE
        GauntletsMenu.SetActive(false);
        ShouldersMenu.SetActive(false);
        GlovesMenu.SetActive(false);
    }
}
