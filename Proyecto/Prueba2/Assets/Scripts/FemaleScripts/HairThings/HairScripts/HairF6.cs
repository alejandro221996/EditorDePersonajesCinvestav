using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF6 : MonoBehaviour
{
  public GameObject HF6;

  public void ShowH6()
  {
       if(HF6!= null)
      {
          bool isActive= HF6.activeSelf;

          HF6.SetActive(!isActive);
      }
  }
}
