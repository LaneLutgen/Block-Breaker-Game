using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public PaddleMover paddle;

    private bool hasStarted = false;
    private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
        paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            //Lock the ball on the paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;

            //Wait for mouse click to launch the ball
            if (Input.GetMouseButton(0))
            {
                //Launch that sumbitch
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(200f, 300f);
            }
        }
	}
}
