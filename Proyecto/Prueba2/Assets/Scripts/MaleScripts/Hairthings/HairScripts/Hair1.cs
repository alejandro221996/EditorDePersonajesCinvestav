using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF1 : MonoBehaviour
{
  public GameObject HF1;

  public void ShowHF1()
  {
       if(HF1!= null)
      {
          bool isActive= HF1.activeSelf;

          HF1.SetActive(!isActive);
      }
  }
}
