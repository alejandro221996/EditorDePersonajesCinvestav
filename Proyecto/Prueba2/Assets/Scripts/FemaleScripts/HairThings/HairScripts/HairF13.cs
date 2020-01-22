using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF13 : MonoBehaviour
{
  public GameObject HF13;

  public void ShowHF13()
  {
       if(HF13!= null)
      {
          bool isActive= HF13.activeSelf;

          HF13.SetActive(!isActive);
      }
  }
}
