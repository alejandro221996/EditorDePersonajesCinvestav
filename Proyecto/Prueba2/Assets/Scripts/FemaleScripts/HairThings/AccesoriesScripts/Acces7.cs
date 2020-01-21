using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acces7 : MonoBehaviour
{
     public GameObject A7;

  public void ShowA7()
  {
       if(A7!= null)
      {
          bool isActive= A7.activeSelf;

          A7.SetActive(!isActive);
      }
  }
}
