using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomPos : MonoBehaviour {

    public float waitTime;
    public LayerMask whatIsRoom;
    bool hasRoom;

    public GameObject closedRoom;

	void Update () {

        Collider2D room = Physics2D.OverlapCircle(transform.position, 1, whatIsRoom);
        if (room != null) {
            hasRoom = true;
        }

        if (waitTime <= 0)
        {
            if (hasRoom == false) {
                Instantiate(closedRoom, transform.position, Quaternion.identity);
            }
        }
        else {
            waitTime -= Time.deltaTime;
        }
	}
}
