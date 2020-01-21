using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesF1 : MonoBehaviour
{
     public GameObject AF1;

  public void ShowAF1()
  {
       if(AF1!= null)
      {
          bool isActive= AF1.activeSelf;

          AF1.SetActive(!isActive);
      }
  }
}
