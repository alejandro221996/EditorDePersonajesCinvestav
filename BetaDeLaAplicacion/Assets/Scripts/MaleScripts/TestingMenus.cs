using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMenus : MonoBehaviour
{
    public GameObject BootsMenu;
    public GameObject PantsMenu;
   
    public GameObject BeltMenu;
    public GameObject UpperArmorMenu;
    public GameObject GauntletsMenu;
    public GameObject ShouldersMenu;
    
    
    public GameObject ArmorMenu;
    public GameObject TopMenu;
    public GameObject OuterMenu;
    public GameObject AccesoriesMenu;
    public GameObject WingMenu;
    
   
    public GameObject HairMenu;
    public GameObject AccesoriesHMenu;
    
    
    public GameObject HatMenu;
    public GameObject EarsMenu;
    public GameObject EyesMenu;
    public GameObject HelmetMenu;
   
    public GameObject FacialHairMenu;
    public GameObject HeadAccesories;

    public GameObject AgiPoints;
    public GameObject StrPoints;
    public GameObject WisPoints;
    public GameObject HeaPoints;
    public GameObject IntPoints;
    public GameObject ReamainingPoints;
    public GameObject UsedPoints;
    public GameObject AttribTittle;
    




    public void MostrarMenu(int MenuSelected)
    {
        switch (MenuSelected)
        {
            case 1://--------------------------1=Male
                HideAttribsControls();
                HideMenus();
                HairMenu.SetActive(true);
                AccesoriesHMenu.SetActive(true);

                break;

            case 2://---------------------2=Female
                HideAttribsControls();
                HideMenus();
                EyesMenu.SetActive(true);
                EarsMenu.SetActive(true);
                HelmetMenu.SetActive(true);
                FacialHairMenu.SetActive(true);
                HeadAccesories.SetActive(true);
                HatMenu.SetActive(true);


                break;
            case 3:
                HideAttribsControls();
                HideMenus();
                ArmorMenu.SetActive(true);
                TopMenu.SetActive(true);
                OuterMenu.SetActive(true);
                AccesoriesMenu.SetActive(true);
                WingMenu.SetActive(true);
                break;
            case 4:
                HideAttribsControls();
                HideMenus();
                GauntletsMenu.SetActive(true);
                ShouldersMenu.SetActive(true);
                //-----HAIRHIDE

                break;
            case 5:
                HideAttribsControls();
                HideMenus();
                UpperArmorMenu.SetActive(true);
                BootsMenu.SetActive(true);
                PantsMenu.SetActive(true);
                BeltMenu.SetActive(true);

                break;
            case 6:
                HideMenus();
                AgiPoints.SetActive(true);
                StrPoints.SetActive(true);
                HeaPoints.SetActive(true);
                IntPoints.SetActive(true);
                WisPoints.SetActive(true);
                AttribTittle.SetActive(true);
                ReamainingPoints.SetActive(true);
                UsedPoints.SetActive(true);


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
        WingMenu.SetActive(false);
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
    void HideAttribsControls()
    {
        AgiPoints.SetActive(false);
        StrPoints.SetActive(false);
        HeaPoints.SetActive(false);
        IntPoints.SetActive(false);
        WisPoints.SetActive(false);
        AttribTittle.SetActive(false);
        ReamainingPoints.SetActive(false);
        UsedPoints.SetActive(false);
       

    }
}

