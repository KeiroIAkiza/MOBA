using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecievedMovement : MonoBehaviour {

    Vector3 newPosition;
    public float speed;
    public float walkRange;
    public GameObject graphics;

	void Start () {
        newPosition = this.transform.position;	
	}
	
	void Update () {

        if(Vector3.Distance (newPosition, this.transform.position) > walkRange)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, newPosition, speed * Time.deltaTime);
            Quaternion transRotation = Quaternion.LookRotation(newPosition - this.transform.position, Vector3.up);
            graphics.transform.rotation = Quaternion.Slerp(transRotation, graphics.transform.rotation, 0.2f);
        }
	}

    //ADD RPC HERE | RPC - Remote Procedural Call
    [PunRPC]
    public void RecievedMovementCommand(Vector3 movePos)
    {
        newPosition = movePos;
    }

}
