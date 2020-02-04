using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGender : MonoBehaviour
{
    public GameObject Male;
    public GameObject Female;
    public GameObject SelectMale;
    public GameObject SelectFemale;
    public GameObject MaleHairButton;
    public GameObject MaleHeadButton;
    public GameObject MaleBodyButton;
    public GameObject MaleLegsButton;
    public GameObject MaleArmsButton;


    public void ShowAvatar(int Actual)
    {
        if (Actual == 1)//--------------------------1=Male
        {
            Male.SetActive(true);
            Female.SetActive(false);
            MaleHairButton.SetActive(true);
            MaleHeadButton.SetActive(true);
            MaleLegsButton.SetActive(true);
            MaleArmsButton.SetActive(true);
            MaleBodyButton.SetActive(true);

        }
        if(Actual==2)//---------------------2=Female
        {
            Female.SetActive(true);
            Male.SetActive(false);
            HideMaleControls();


        }
        
    }
    public void HideMaleControls()
    {
        MaleHairButton.SetActive(false);
        MaleHeadButton.SetActive(false);
        MaleLegsButton.SetActive(false);
        MaleArmsButton.SetActive(false);
        MaleBodyButton.SetActive(false);
    }
}
