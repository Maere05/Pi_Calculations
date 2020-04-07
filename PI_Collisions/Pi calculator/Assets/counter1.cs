using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter1 : MonoBehaviour
{

 public int countervar = -1;
 public Canvas counterthing;
 public Text text;


  void OnCollisionEnter(Collision other) {
        countervar ++;

        text.text = countervar.ToString();

        if (countervar == 15)
        {
            countervar += 35;
        }
           if (countervar == 51)
        {
            countervar += 40;
        }
           if (countervar == 92)
        {
            countervar += 40;
        }
           if (countervar == 143)
        {
            countervar += 40;
        }
           if (countervar == 210)
        {
            countervar += 63;
        }
             if (countervar == 274)
        {
            countervar += 17;
        }

    }
}
