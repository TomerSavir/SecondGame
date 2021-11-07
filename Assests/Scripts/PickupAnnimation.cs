using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAnnimation : MonoBehaviour
{
    public float RotationSpeed=50;
    public bool rotatioAnimation=true;
    


    // Start is called before the first frame update
    void Start()
    {
  

    }

    // Update is called once per frame
    void Update()
    {
      
      if(rotatioAnimation)
      {
          RotatePickup();
      }
      

    }
    
    void RotatePickup(){
    transform.Rotate(0f,RotationSpeed * Time.deltaTime ,0f);

    }
}
