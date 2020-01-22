using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF11 : MonoBehaviour
{
  public GameObject HF11;

  public void ShowHF11()
  {
       if(HF11!= null)
      {
          bool isActive= HF11.activeSelf;

          HF11.SetActive(!isActive);
      }
  }
}
