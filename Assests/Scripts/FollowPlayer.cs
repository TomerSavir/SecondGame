using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 Offset= new Vector3 (0,4.2f,-8.5f);
    // Start is called before the first frame update
    // no functions here
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.position = player.transform.position + Offset;    
    }


  
}
