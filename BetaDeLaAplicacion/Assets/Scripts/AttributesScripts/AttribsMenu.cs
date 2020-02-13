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
    int TotalPoints=10;
    public Text SPoints;
    public Text APoints;
    public Text HPoints;
   public Text WPoints;
    public Text RPoints;
    public Text IPoints;
    
    int Svalue=0;
    int Avalue = 0;
    int Hvalue = 0;
    int Wvalue = 0;
    int Ivalue = 0;
    int RValue=0 ;
     void IncreasingSPoints()
    {
        float SSliderValue = Sslider.value;
        SPoints.text = Mathf.RoundToInt(SSliderValue) + "";

        Svalue = int.Parse(SPoints.text);
        Debug.Log(Svalue);
        Debug.Log(SSliderValue);
    }
    void IncreasingAPoints()
    {
        float ASliderValue = Aslider.value;
        APoints.text = Mathf.RoundToInt(ASliderValue) + "";

        Avalue = int.Parse(APoints.text);
        Debug.Log(Avalue);
        Debug.Log(ASliderValue);
    }
    void IncreasingHPoints()
    {
        float HSliderValue = Hslider.value;
        HPoints.text = Mathf.RoundToInt(HSliderValue) + "";

        Hvalue = int.Parse(HPoints.text);
        Debug.Log(Hvalue);
        Debug.Log(HSliderValue);
    }
    void IncreasingWPoints()
    {
        float WSliderValue = Wslider.value;
        WPoints.text = Mathf.RoundToInt(WSliderValue) + "";

        Wvalue = int.Parse(WPoints.text);
        Debug.Log(Wvalue);
        Debug.Log(WSliderValue);
    }
    void IncreasingIPoints()
    {
        float ISliderValue = Islider.value;
        IPoints.text = Mathf.RoundToInt(ISliderValue) + "";

        Ivalue = int.Parse(IPoints.text);
        Debug.Log(Ivalue);
        Debug.Log(ISliderValue);
    }
    public void AttribsPoints()
    {
        RValue = int.Parse(RPoints.text);
        Debug.Log(RValue);
        if (RValue > 0)
        {
            IncreasingIPoints();
            IncreasingWPoints();
            IncreasingHPoints();
            IncreasingAPoints();
            IncreasingSPoints();
           

            RValue = TotalPoints - Svalue - Avalue - Ivalue - Wvalue - Hvalue;
            RPoints.text = RValue + "";
        }
        else
        {
            RPoints.text = "No Hay puntos disponibles";
        }
    }
    
    /*
    public void IncreasingPoints(float Slidervalue )
    {
        SPoints.text = Mathf.RoundToInt(Slidervalue)+"";
        
        Svalue = int.Parse(SPoints.text);
        RValue = int.Parse(RPoints.text);

        RValue = TotalPoints - Svalue;
        RPoints.text = RValue + "";
    
        Debug.Log(RValue);
        
        Debug.Log(RPoints.text);
      
        
    }*/

}



