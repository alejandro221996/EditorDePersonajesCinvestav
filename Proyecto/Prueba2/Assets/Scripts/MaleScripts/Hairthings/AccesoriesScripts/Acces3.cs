using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acces3 : MonoBehaviour
{
     public GameObject A3;

  public void ShowA3()
  {
       if(A3!= null)
      {
          bool isActive= A3.activeSelf;

          A3.SetActive(!isActive);
      }
  }
}
