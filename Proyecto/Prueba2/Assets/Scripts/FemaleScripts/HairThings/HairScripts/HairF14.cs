using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF15 : MonoBehaviour
{
  public GameObject HF14;

  public void ShowHF14()
  {
       if(HF14!= null)
      {
          bool isActive= HF14.activeSelf;

          HF14.SetActive(!isActive);
      }
  }
}
