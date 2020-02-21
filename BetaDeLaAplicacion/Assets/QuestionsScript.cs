using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsScript : MonoBehaviour
{
     public GameObject AvatarLabelsField;
      public GameObject AvatarDescriptionField;
    public GameObject GenderField;
    public GameObject AgeField;
    public GameObject CountryField;
    public GameObject StateField;
    public GameObject CityField;
    string EdadActual;
    private string Response1;
    private string Response2;
    private string Response3;
    private string Response4;
    private string Response5;
    private string Response6;
    private string Response7;
    private string BASE_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLSckSkxOors-ZE8dkG1RMBWSPNoPl_waconUvFBx6UG1heQklw/formResponse";
    IEnumerator Post(string AvatarLabels, string AvatarDescription, string Gender,string Age,string Country,string State,string City)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.613702313", AvatarLabels);
        form.AddField("entry.3918468", AvatarDescription);
        form.AddField("entry.1932287901", Gender);
        form.AddField("entry.1072302844", Age);
        form.AddField("entry.873422993", Country);
        form.AddField("entry.1701443724", State);
        form.AddField("entry.1737114437", City);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }
    public void SubmitData()
    {
        //Ages();
        Response1 = AvatarLabelsField.GetComponent<InputField>().text;
        Response2 = AvatarDescriptionField.GetComponent<InputField>().text;
        Response3 = GenderField.GetComponent<InputField>().text;
        Response4 = EdadActual;
        Response5 = CountryField.GetComponent<InputField>().text;
        Response6 = StateField.GetComponent<InputField>().text;
        Response7 = CityField.GetComponent<InputField>().text;

        StartCoroutine(Post(Response1, Response2, Response3, Response4, Response5, Response6, Response7));
    }
  /* public void Ages(int ActualAge)

    {
        string edad;
        switch(ActualAge)
        {
            case 1:
                edad = "12-15";
                break;
            case 2:
                edad = "15-18";
                break;
            case 3:
                edad = "18-23";
                break;
            case 4:
                edad = "23-28";
                break;
            case 5:
                edad = "28-33";
                break;

            case 6:
                edad = "33-38";
                break;
            case 7:
                edad = "38-43";
                break;
            case 8:
                edad = "43-48";
                break;
            default:
                break;

        }
        EdadActual = edad;
    }*/

}
