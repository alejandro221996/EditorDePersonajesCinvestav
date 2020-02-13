using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendToGoogleForm : MonoBehaviour
{
   // public GameObject StrField;
  //  public GameObject AgiField;
   // public GameObject HeaField;
    public Text SPoints;
    public Slider Sslider;
    public Text APoints;
    public Slider Aslider;
    public Text HPoints;
    public Slider Hslider;
    string STRs;
    string AGIs;
    string HEAs;
    int STR = 0;
    int AGI = 0;
    int HEA = 0;
    int Svalue = 0;
    int Avalue = 0;
    int Hvalue = 0;
    private string Strength;
    private string Agility;
    private string Health;
    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScE-G2H2f0qznIb0mmU8pRh8KuAi4-KvPqkEHpYXTSVOEk1mg/formResponse";
    IEnumerator Post(string str,string agility,string health)
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
        Debug.Log(Svalue + "SValue"); Debug.Log(Hvalue + "SValue"); Debug.Log(Avalue + "AValue");
        SlidersValue();
        SlideraValue();
        SliderhValue();


        STRs =Svalue.ToString();
        AGIs = Avalue.ToString();
        HEAs = Hvalue.ToString();
        StartCoroutine(Post(STRs,AGIs,HEAs));

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
