using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF12 : MonoBehaviour
{
  public GameObject HF12;

  public void ShowHF12()
  {
       if(HF12!= null)
      {
          bool isActive= HF12.activeSelf;

          HF12.SetActive(!isActive);
      }
  }
}
