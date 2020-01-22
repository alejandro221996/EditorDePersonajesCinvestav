using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acces5 : MonoBehaviour
{
     public GameObject A5;

  public void ShowA5()
  {
       if(A5!= null)
      {
          bool isActive= A5.activeSelf;

          A5.SetActive(!isActive);
      }
  }
}
