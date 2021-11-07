using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLayerControl : MonoBehaviour
{
     public float Speed=20;
     public float TurnSpeed=40;
     public float HorizontalInput;
     public float VerticalInput;
     public int Score=0;
     public Text TextScore;

    // Update is called once per frame
    void Update()
    {
    //define user input from arrows for Horizontal movement
    HorizontalInput=Input.GetAxis("Horizontal");
    //define user input from arrows for Vertical movement
    VerticalInput=Input.GetAxis("Vertical");
    //define car vertical movement by user input by arrows 
    transform.Translate(Vector3.forward * Time.deltaTime * Speed * VerticalInput);
    //define car movement by Y rotation
    transform.Rotate(Vector3.up , HorizontalInput * Time.deltaTime * TurnSpeed);    
     
    }

 private void OnTriggerEnter (Collider coll){  
     coll.gameObject.SetActive(false);  
     Score++;
     TextScore.text=Score.ToString();}
}
