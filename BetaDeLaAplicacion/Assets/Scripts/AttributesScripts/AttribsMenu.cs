using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AttribsMenu : MonoBehaviour
{
    
   int TotalPoints=10;
    public Text SPoints;
    public Text APoints;
   // public Text HPoints;
   // public Text WPoints;
    public Text RPoints;
   // public Text IPoints;
    
    int Svalue=0;
    //int Avalue = 0;
    //int Hvalue = 0;
    //int Wvalue = 0;
   // int Ivalue = 0;
    int RValue = 0;

    public void IncreasingPoints(float Slidervalue )
    {
        SPoints.text = Mathf.RoundToInt(Slidervalue)+"";
        
        Svalue = int.Parse(SPoints.text);
        RValue = int.Parse(RPoints.text);

        RValue =TotalPoints - Svalue;
        RPoints.text = RValue + "";
    
        Debug.Log(RValue);
        
        Debug.Log(RPoints.text);
      
        
    }
 
    }



