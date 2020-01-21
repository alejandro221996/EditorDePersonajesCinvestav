using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesF2 : MonoBehaviour
{
     public GameObject AF2;

  public void ShowAF2()
  {
       if(AF2!= null)
      {
          bool isActive= AF2.activeSelf;

          AF2.SetActive(!isActive);
      }
  }
}
