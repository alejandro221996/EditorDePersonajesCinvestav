using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendToGoogleForm : MonoBehaviour
{
    public PuttingHairs 
   // public GameObject StrField;
  //  public GameObject AgiField;
   // public GameObject HeaField;
 
    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScze40MaWVFPlt6TXTbaxnpKSG_sQ3Ztm3cx94Q83wznlyCTQ/formResponse";
    IEnumerator Post(string Hair,string AccesHair,string Gender)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1657925407", str);
        form.AddField("entry.1584728741", agility);
        form.AddField("entry.1210576219", health);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }
    public void MandarDatos()
    {
        
       
        StartCoroutine(Post(HairS,AccesHairS,GenderS));

    }
    void SlidersValue()
    {
        float SSliderValue = Sslider.value;
        SPoints.text = Mathf.RoundToInt(SSliderValue) + "";

        Svalue = int.Parse(SPoints.text);
        Debug.Log(Svalue + "SValue");
    }
    void SliderhValue()
    {
        float HSliderValue = Hslider.value;
        SPoints.text = Mathf.RoundToInt(HSliderValue) + "";

        Hvalue = int.Parse(HPoints.text);
        Debug.Log(Hvalue + "SValue");
    }
    void SlideraValue()
    {
        float ASliderValue = Aslider.value;
        APoints.text = Mathf.RoundToInt(ASliderValue) + "";

        Avalue = int.Parse(APoints.text);
        Debug.Log(Avalue + "AValue");
    }
}
