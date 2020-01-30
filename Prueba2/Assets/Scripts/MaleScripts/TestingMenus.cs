using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMenus : MonoBehaviour
{
    public GameObject BootsMenu;
    public GameObject PantsMenu;
    //public GameObject LegsButton;
    public GameObject BeltMenu;
    public GameObject UpperArmorMenu;
    public GameObject GauntletsMenu;
    public GameObject ShouldersMenu;
    
    //public GameObject ArmsButton;
    public GameObject ArmorMenu;
    public GameObject TopMenu;
    public GameObject OuterMenu;
    public GameObject AccesoriesMenu;
    
    //public GameObject BodyButton;
    public GameObject HairMenu;
    //public GameObject HairTitle;
    //public GameObject HairButton;
    public GameObject AccesoriesHMenu;
    
    //public GameObject AccesoriesTitle;
    public GameObject HatMenu;
    public GameObject EarsMenu;
    public GameObject EyesMenu;
    public GameObject HelmetMenu;
    //public GameObject HeadButton;
    public GameObject FacialHairMenu;
    public GameObject HeadAccesories;


    public void MostrarMenu(int MenuSelected)
    {
        switch (MenuSelected)
        {
            case 1://--------------------------1=Male

                HideMenus();
                HairMenu.SetActive(true);
                AccesoriesHMenu.SetActive(true);

                break;

            case 2://---------------------2=Female

                HideMenus();
                EyesMenu.SetActive(true);
                EarsMenu.SetActive(true);
                HelmetMenu.SetActive(true);
                FacialHairMenu.SetActive(true);
                HeadAccesories.SetActive(true);
                HatMenu.SetActive(true);


                break;
            case 3:

                HideMenus();
                ArmorMenu.SetActive(true);
                TopMenu.SetActive(true);
                OuterMenu.SetActive(true);
                AccesoriesMenu.SetActive(true);
                break;
            case 4:

                HideMenus();
                GauntletsMenu.SetActive(true);
                ShouldersMenu.SetActive(true);
                //-----HAIRHIDE

                break;
            case 5:

                HideMenus();
                UpperArmorMenu.SetActive(true);
                BootsMenu.SetActive(true);
                PantsMenu.SetActive(true);
                BeltMenu.SetActive(true);

                break;
            default:
                break;


        }
    }
        public void HideMenus()
    {
        UpperArmorMenu.SetActive(false);
        BootsMenu.SetActive(false);
        PantsMenu.SetActive(false);
        BeltMenu.SetActive(false);
        //-----HAIRHIDE
        HairMenu.SetActive(false);
        AccesoriesHMenu.SetActive(false);
        //-----BODYHIDE
        ArmorMenu.SetActive(false);
        TopMenu.SetActive(false);
        OuterMenu.SetActive(false);
        AccesoriesMenu.SetActive(false);
        //------HEADHIDE
        EyesMenu.SetActive(false);
        EarsMenu.SetActive(false);
        HelmetMenu.SetActive(false);
        FacialHairMenu.SetActive(false);
        HeadAccesories.SetActive(false);
        HatMenu.SetActive(false);
        //-----ARMHIDE
        GauntletsMenu.SetActive(false);
        ShouldersMenu.SetActive(false);
    }
    }

