using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{
    public void OnTriggerEnter(Collider coll){

        GameObject.Find("Player").SendMessage("finnish");
    }
}
