using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acces1 : MonoBehaviour
{
     public GameObject A1;

  public void ShowA1()
  {
       if(A1!= null)
      {
          bool isActive= A1.activeSelf;

          A1.SetActive(!isActive);
      }
  }
}
