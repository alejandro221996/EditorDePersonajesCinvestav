using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acces2 : MonoBehaviour
{
     public GameObject A2;

  public void ShowA2()
  {
       if(A2!= null)
      {
          bool isActive= A2.activeSelf;

          A2.SetActive(!isActive);
      }
  }
}
