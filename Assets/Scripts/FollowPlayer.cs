using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (Input.GetMouseButton(0))
        { // When the left mouse button is pressed return true
            offset = new Vector3(0, 5, 0);
            transform.position = player.transform.position + offset;
            transform.rotation = player.transform.rotation;
        }
        else
        {
            offset = new Vector3(0, 7, -8);
            transform.position = player.transform.position + offset;
            transform.eulerAngles = new Vector3(24, 0, 0);

        }
        
    }
}
