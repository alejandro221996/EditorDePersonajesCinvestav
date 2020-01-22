using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair11 : MonoBehaviour
{
  public GameObject H11;

  public void ShowH11()
  {
       if(H11!= null)
      {
          bool isActive= H11.activeSelf;

          H11.SetActive(!isActive);
      }
  }
}
