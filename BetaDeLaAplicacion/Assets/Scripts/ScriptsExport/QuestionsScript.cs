using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsScript : MonoBehaviour
{
    public DropDownAuto CountriesS;
    public DropDownGender GendersS;
    public DropAges AgeS;


    public GameObject AvatarLabelsField;
    public GameObject AvatarDescriptionField;

    string EdadActual;
    private string Response1 = "";
    private string Response2 = "";
    private string Response3 = "";
    private string Response4 = "";
    private string Response5 = "";


    private string BASE_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLSckSkxOors-ZE8dkG1RMBWSPNoPl_waconUvFBx6UG1heQklw/formResponse";
    IEnumerator Post(string AvatarLabels, string AvatarDescription, string Gender, string Age, string Country)// string Gender, string Age, string Country)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.613702313", AvatarLabels);
        form.AddField("entry.3918468", AvatarDescription);
        form.AddField("entry.1932287901", Gender);
        form.AddField("entry.1072302844", Age);
        form.AddField("entry.873422993", Country);

        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }
    public void SetCountry(string in_Country)
    {
        Response5 = in_Country.ToString();
    }
    public void SetGender(string in_Gender)
    {
        Response3 = in_Gender.ToString();
    }
    public void SetAge(string in_Age)
    {
        Response4 = in_Age.ToString();
    }
    public void SubmitData()
    {
        //Ages();



        Response1 = AvatarLabelsField.GetComponent<InputField>().text;
        Response2 = AvatarDescriptionField.GetComponent<InputField>().text;

        StartCoroutine(Post(Response1, Response2, Response3, Response4, Response5));
    }




}

