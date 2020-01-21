using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesF7 : MonoBehaviour
{
     public GameObject AF7;

  public void ShowA7()
  {
       if(AF7!= null)
      {
          bool isActive= AF7.activeSelf;

          AF7.SetActive(!isActive);
      }
  }
}
