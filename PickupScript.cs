using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour {

    int coinCounter;
	public bool rotateitem = true;
	public float speed = 1 ;
	public int coinType;
	public int itemScore;
	// Use this for initialization
	void Start () {
		//coinCounter = 0;  
	}
	
	// Update is called once per frame
	void Update () {
		if (rotateitem){
			transform.Rotate(new Vector3(1,0,0)* speed);
		}
		
		
	}
/*void OnControllerColliderHit(ControllerColliderHit hit){
    Destroy (hit.gameObject);
	coinCounter++;
	Debug.Log("coin counter = " + coinCounter);
}
*/
/*void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.tag == "Coin") {
			coinCounter++;
        gameObject.SetActive(false);
//Debug.Log("coin counter = " + coinCounter);*/
}
//}
//}
