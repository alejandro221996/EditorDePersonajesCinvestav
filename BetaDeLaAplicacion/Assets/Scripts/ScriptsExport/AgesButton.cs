using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgesButton : MonoBehaviour
{
    //public QuestionsScript QuestionsS;
    public GameObject Age1;
    public GameObject Age2;
    public GameObject Age3;
    public GameObject Age4;
    public GameObject Age5;
    public GameObject Age6;
    public GameObject Age7;
    public GameObject Age8;

    private string Mensaje;






    public void AgeActual(int AgeSelected)
    {


        switch (AgeSelected)
        {
            case 1:

                Mensaje = "1";
                break;
            case 2:
                Mensaje = "1";


                break;
            case 3:
                Mensaje = "1";

                break;
            case 4:
                Mensaje = "1";
                break;
            case 5:
                Mensaje = "1";

                break;
            case 6:
                Mensaje = "1";

                break;
            case 7:
                Mensaje = "1";
                break;
            case 8:
                Mensaje = "1";

                break;


            default:
                Mensaje = "1";
                break;


        }



    }

}
