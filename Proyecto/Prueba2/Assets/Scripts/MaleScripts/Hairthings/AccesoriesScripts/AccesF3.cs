using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesF3 : MonoBehaviour
{
     public GameObject AF3;

  public void ShowAF3()
  {
       if(AF3!= null)
      {
          bool isActive= AF3.activeSelf;

          AF3.SetActive(!isActive);
      }
  }
}
