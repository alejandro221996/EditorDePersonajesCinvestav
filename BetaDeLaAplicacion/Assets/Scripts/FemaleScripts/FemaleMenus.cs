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
            case 1://--------------------------1=HairMenus
                HideAttribsControls();
                HideMenus();
                HairMenu.SetActive(true);
                FrontHair.SetActive(true);
                BackHair.SetActive(true);

                break;

            case 2://---------------------2=HeadMenus
                HideAttribsControls();
                HideMenus();
                EyesMenu.SetActive(true);
                EarsMenu.SetActive(true);
                HairAccesories.SetActive(true);      
                HeadAccesories.SetActive(true);
                HatMenu.SetActive(true);


                break;
            case 3://---------------------3=BodyMenus
                HideAttribsControls();
                HideMenus();
                ArmorMenu.SetActive(true);
                TopsMenu.SetActive(true);
                DressesMenu.SetActive(true);
                BAccesoriesMenu.SetActive(true);
                TorsoMenu.SetActive(true);
                break;
            case 4:
                HideAttribsControls();
                HideMenus();
                GauntletsMenu.SetActive(true);
                ShouldersMenu.SetActive(true);
                GlovesMenu.SetActive(true);
                //-----HAIRHIDE

                break;
            case 5:
                HideAttribsControls();
                HideMenus();
                UpperArmorMenu.SetActive(true);
                BootsMenu.SetActive(true);
                PantsMenu.SetActive(true);
                SkirtsMenu.SetActive(true);

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
