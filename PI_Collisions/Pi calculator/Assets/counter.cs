using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{

 public int countervar = -1;
 public Canvas counterthing;
 public Text text;


  void OnCollisionEnter(Collision other) {
        countervar ++;

        text.text = countervar.ToString();
    }
}
