using UnityEngine;
using System.Collections;

public class PaddleMover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, this.transform.position.z); 

        float mousePosition = (Input.mousePosition.x / Screen.width * 650);

        print(mousePosition);

        paddlePos.x = Mathf.Clamp(mousePosition, 50f, 650f);

        this.transform.position = paddlePos;
	}
}
