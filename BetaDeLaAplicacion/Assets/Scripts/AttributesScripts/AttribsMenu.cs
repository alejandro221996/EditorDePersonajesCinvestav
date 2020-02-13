using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AttribsMenu : MonoBehaviour
{
    public Slider Sslider;
    public Slider Aslider;
    public Slider Hslider;
    public Slider Wslider;
    public Slider Islider;
    int TotalPoints = 10;
    public Text SPoints;
    public Text APoints;
    public Text HPoints;
    public Text WPoints;
    public Text RPoints;
    public Text IPoints;
    public GameObject Message;
    public GameObject DiscardMenu;
    public GameObject ConfirmMenu;


    int Svalue = 0;
    int Avalue = 0;
    int Hvalue = 0;
    int Wvalue = 0;
    int Ivalue = 0;
    int RValue = 0;
    void IncreasingSPoints()
    {


        float SSliderValue = Sslider.value;
        SPoints.text = Mathf.RoundToInt(SSliderValue) + "";

        Svalue = int.Parse(SPoints.text);
        Debug.Log(Svalue + "SValue");
        //Debug.Log(SSliderValue);


    }
    void IncreasingAPoints()
    {
        float ASliderValue = Aslider.value;
        APoints.text = Mathf.RoundToInt(ASliderValue) + "";

        Avalue = int.Parse(APoints.text);
        Debug.Log(Avalue + "AValue");
        //Debug.Log(ASliderValue);
    }
    void IncreasingHPoints()
    {
        float HSliderValue = Hslider.value;
        HPoints.text = Mathf.RoundToInt(HSliderValue) + "";

        Hvalue = int.Parse(HPoints.text);
        Debug.Log(Hvalue + "HValue");
        //Debug.Log(HSliderValue);
    }
    void IncreasingWPoints()
    {
        float WSliderValue = Wslider.value;
        WPoints.text = Mathf.RoundToInt(WSliderValue) + "";

        Wvalue = int.Parse(WPoints.text);
        Debug.Log(Wvalue + "WValue");
        // Debug.Log(WSliderValue);
    }
    void IncreasingIPoints()
    {
        float ISliderValue = Islider.value;
        IPoints.text = Mathf.RoundToInt(ISliderValue) + "";

        Ivalue = int.Parse(IPoints.text);
        Debug.Log(Ivalue + "IValue");
        //Debug.Log(ISliderValue);
    }
    public void AttribsPoints()
    {

        RValue = int.Parse(RPoints.text);
        Debug.Log(RValue + "RValue");

        IncreasingHPoints();
        IncreasingWPoints();
        IncreasingIPoints();
        IncreasingSPoints();
        IncreasingAPoints();

        RValue = TotalPoints - Svalue - Avalue - Ivalue - Wvalue - Hvalue;
        RPoints.text = RValue + "";
        if (RValue == 0)
        {
            ConfirmDiscardMenu();

        }

    }
    void ConfirmDiscardMenu()
    {
        Message.SetActive(true);
        DiscardMenu.SetActive(true);
        ConfirmMenu.SetActive(true);
    }
    public void ContMenus(int ConfDis)
    {
        switch (ConfDis)
        {
            case 1:
                Message.SetActive(false);
                DiscardMenu.SetActive(false);
                ConfirmMenu.SetActive(false);
                break;
            case 2:
                Message.SetActive(false);
                DiscardMenu.SetActive(false);
                ConfirmMenu.SetActive(false);

                RValue = 10;
                Svalue = 0;
                Sslider.value = 0;
                Avalue = 0;
                Aslider.value = 0;
                Hvalue = 0;
                Hslider.value = 0;
                Ivalue = 0;
                Islider.value = 0;
                Wvalue = 0;
                Wslider.value = 0;



                RPoints.text = RValue + "";
                APoints.text = Avalue + "";
                SPoints.text = Svalue + "";
                WPoints.text = Wvalue + "";
                HPoints.text = Hvalue + "";
                IPoints.text = Ivalue + "";

                break;
        }
    }
}

    








