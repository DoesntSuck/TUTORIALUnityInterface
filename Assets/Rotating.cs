using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour
{
    // The degrees per second that the object will rotate
    public float speed = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        // The amount to rotate the object this frame. Multiplying by Time.delta time makes it a per second change
        float degrees = speed * Time.deltaTime;

        // Rotate the object around the world upwards vector (x: 0, y: 1, z: 0)
        transform.Rotate(Vector3.up, degrees, Space.World);	
	}
}
