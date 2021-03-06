﻿using System.Collections;
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
   
    //Aplicacion Web
    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScE-G2H2f0qznIb0mmU8pRh8KuAi4-KvPqkEHpYXTSVOEk1mg/formResponse";


    //Valores String de los Sliders
    string SvalueString ;
    string AvalueString ;
    string HvalueString ;
    string WvalueString ;
    string IvalueString ;
   

    //

    //Valores Enteros De Los Sliders
     int Svalue = 0;
    int Avalue = 0;
    int Hvalue = 0;
    int Wvalue = 0;
    int Ivalue = 0;
    int RValue = 0;
    IEnumerator Post(string strength, string agility, string health,string wisdom,string intelligence)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1657925407", strength);
        form.AddField("entry.1584728741", agility);
        form.AddField("entry.1210576219", health);
        form.AddField("entry.1831548053", wisdom);
        form.AddField("entry.1986338539", intelligence);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }
   public void IncreasingSPoints()
    {


        float SSliderValue = Sslider.value;
        SPoints.text = Mathf.RoundToInt(SSliderValue) + "";

        Svalue = int.Parse(SPoints.text);
        Debug.Log(Svalue + "SValue");
        //Debug.Log(SSliderValue);


    }
    public void IncreasingAPoints()
    {
        float ASliderValue = Aslider.value;
        APoints.text = Mathf.RoundToInt(ASliderValue) + "";

        Avalue = int.Parse(APoints.text);
        Debug.Log(Avalue + "AValue");
        //Debug.Log(ASliderValue);
    }
    public void IncreasingHPoints()
    {
        float HSliderValue = Hslider.value;
        HPoints.text = Mathf.RoundToInt(HSliderValue) + "";

        Hvalue = int.Parse(HPoints.text);
        Debug.Log(Hvalue + "HValue");
        //Debug.Log(HSliderValue);
    }
   public void IncreasingWPoints()
    {
        float WSliderValue = Wslider.value;
        WPoints.text = Mathf.RoundToInt(WSliderValue) + "";

        Wvalue = int.Parse(WPoints.text);
        Debug.Log(Wvalue + "WValue");
        // Debug.Log(WSliderValue);
    }
    public void IncreasingIPoints()
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
        SvalueString = Svalue.ToString();
        AvalueString = Avalue.ToString();
        HvalueString = Hvalue.ToString();
        WvalueString = Wvalue.ToString();
        IvalueString = Ivalue.ToString();

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
               // SendData();
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
    public void SendData()
    {
        IncreasingAPoints();
        IncreasingWPoints();
        IncreasingIPoints();
        IncreasingSPoints();
        IncreasingAPoints();

        SvalueString = Svalue.ToString();
        AvalueString = Avalue.ToString();
        IvalueString = Ivalue.ToString();
        HvalueString = Hvalue.ToString();
        WvalueString = Wvalue.ToString();

        StartCoroutine(Post(SvalueString, AvalueString, HvalueString, WvalueString,IvalueString));
    }
}

    








