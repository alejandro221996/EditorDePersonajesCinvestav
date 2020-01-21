using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGenderFemale : MonoBehaviour
{
  public GameObject Female;
  public GameObject Male;
  public void SelectFemale()
  {
        if(Female!= null)
      {
          bool isActive= Female.activeSelf;

          Female.SetActive(!isActive);
      }
  }
}
