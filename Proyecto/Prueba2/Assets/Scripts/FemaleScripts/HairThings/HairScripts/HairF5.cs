using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF5 : MonoBehaviour
{
  public GameObject HF5;

  public void ShowHF5()
  {
       if(HF5!= null)
      {
          bool isActive= HF5.activeSelf;

          HF5.SetActive(!isActive);
      }
  }
}