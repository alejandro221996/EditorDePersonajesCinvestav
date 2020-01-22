using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acces6 : MonoBehaviour
{
     public GameObject A6;

  public void ShowA6()
  {
       if(A6!= null)
      {
          bool isActive= A6.activeSelf;

          A6.SetActive(!isActive);
      }
  }
}
