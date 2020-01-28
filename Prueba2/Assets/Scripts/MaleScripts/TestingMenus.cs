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
        if (MenuSelected == 1)//--------------------------1=Male
        { 
            HairMenu.SetActive(true);
            AccesoriesHMenu.SetActive(true);
            //-----HEADHIDE
            EyesMenu.SetActive(false);
            EarsMenu.SetActive(false);
            HelmetMenu.SetActive(false);
            FacialHairMenu.SetActive(false);
            HeadAccesories.SetActive(false);
            HatMenu.SetActive(false);
         
            //-----BODYHIDE
            ArmorMenu.SetActive(false);
            TopMenu.SetActive(false);
            OuterMenu.SetActive(false);
            AccesoriesMenu.SetActive(false);
            //-----LEGSHIDE
            UpperArmorMenu.SetActive(false);
            BootsMenu.SetActive(false);
            PantsMenu.SetActive(false);
            BeltMenu.SetActive(false);
            //-----ARMHIDE
            GauntletsMenu.SetActive(false);
            ShouldersMenu.SetActive(false);
        }

        if (MenuSelected == 2)//---------------------2=Female
        {
            EyesMenu.SetActive(true);
            EarsMenu.SetActive(true);
            HelmetMenu.SetActive(true);
            FacialHairMenu.SetActive(true);
            HeadAccesories.SetActive(true);
            HatMenu.SetActive(true);
            //-----HAIRHIDE
            HairMenu.SetActive(false);
            AccesoriesHMenu.SetActive(false);
            //-----BODYHIDE
            ArmorMenu.SetActive(false);
            TopMenu.SetActive(false);
            OuterMenu.SetActive(false);
            AccesoriesMenu.SetActive(false);
            //-----LEGSHIDE
            UpperArmorMenu.SetActive(false);
            BootsMenu.SetActive(false);
            PantsMenu.SetActive(false);
            BeltMenu.SetActive(false);
            //-----ARMHIDE
            GauntletsMenu.SetActive(false);
            ShouldersMenu.SetActive(false);

        }
        if(MenuSelected==3)
        {
            ArmorMenu.SetActive(true);
            TopMenu.SetActive(true);
            OuterMenu.SetActive(true);
            AccesoriesMenu.SetActive(true);
            //------HEADHIDE
            EyesMenu.SetActive(false);
            EarsMenu.SetActive(false);
            HelmetMenu.SetActive(false);
            FacialHairMenu.SetActive(false);
            HeadAccesories.SetActive(false);
            HatMenu.SetActive(false);
            //-----LEGSHIDE
            UpperArmorMenu.SetActive(false);
            BootsMenu.SetActive(false);
            PantsMenu.SetActive(false);
            BeltMenu.SetActive(false);
            //-----ARMHIDE
            GauntletsMenu.SetActive(false);
            ShouldersMenu.SetActive(false);
            //-----HAIRHIDE
            HairMenu.SetActive(false);
            AccesoriesHMenu.SetActive(false);

        }
        if (MenuSelected==4)
        {
            
            GauntletsMenu.SetActive(true);
            ShouldersMenu.SetActive(true);
            //-----HAIRHIDE
            HairMenu.SetActive(false);
            AccesoriesHMenu.SetActive(false);
            //-----BODYHIDE
            ArmorMenu.SetActive(false);
            TopMenu.SetActive(false);
            OuterMenu.SetActive(false);
            AccesoriesMenu.SetActive(false);
            //-----LEGSHIDE
            UpperArmorMenu.SetActive(false);
            BootsMenu.SetActive(false);
            PantsMenu.SetActive(false);
            BeltMenu.SetActive(false);
            //------HEADHIDE
            EyesMenu.SetActive(false);
            EarsMenu.SetActive(false);
            HelmetMenu.SetActive(false);
            FacialHairMenu.SetActive(false);
            HeadAccesories.SetActive(false);
            HatMenu.SetActive(false);
        }
        if(MenuSelected==5)
        {
            UpperArmorMenu.SetActive(true);
            BootsMenu.SetActive(true);
            PantsMenu.SetActive(true);
            BeltMenu.SetActive(true);
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
        Debug.Log(MenuSelected);
    }
}
