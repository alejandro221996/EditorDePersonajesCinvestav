using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesF6 : MonoBehaviour
{
     public GameObject AF6;

  public void ShowAF6()
  {
       if(AF6!= null)
      {
          bool isActive= AF6.activeSelf;

          AF6.SetActive(!isActive);
      }
  }
}
