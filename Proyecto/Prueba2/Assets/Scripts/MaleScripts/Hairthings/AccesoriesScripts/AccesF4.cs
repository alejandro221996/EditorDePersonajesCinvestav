using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesF4 : MonoBehaviour
{
     public GameObject AF4;

  public void ShowAF4()
  {
       if(AF4!= null)
      {
          bool isActive= AF4.activeSelf;

          AF4.SetActive(!isActive);
      }
  }
}
