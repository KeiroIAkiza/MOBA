using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendInfo : MonoBehaviour {

	
	void Start () {
		
	}
	
	void Update () {
        bool RMB = Input.GetMouseButtonDown(1);

        if (RMB)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit) && hit.transform.tag == "Map")
            {
               this.GetComponent<PhotonView>().RPC("RecievedMovementCommand", PhotonTargets.All, hit.point);
            }

        }
	}
}
