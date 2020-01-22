﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedGenderMale : MonoBehaviour
{
   public GameObject Male;

   public void SelectMale()
   {
        if(Male!= null)
      {
          bool isActive= Male.activeSelf;

          Male.SetActive(!isActive);
      }
   }
}
