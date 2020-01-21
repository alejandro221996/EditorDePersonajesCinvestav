using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesF5 : MonoBehaviour
{
     public GameObject AF5;

  public void ShowAF5()
  {
       if(AF5!= null)
      {
          bool isActive= AF5.activeSelf;

          AF5.SetActive(!isActive);
      }
  }
}
