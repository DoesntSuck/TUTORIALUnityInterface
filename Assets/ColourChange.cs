using UnityEngine;
using System.Collections;

public class ColourChange : MonoBehaviour
{
    // Public variables will be exposed in the inspector

    // Colours to change from and to
    public Color From;
    public Color To;

    // The duration of the colour change
    public float duration;

    // The current time the colour change has been occuring for
    float time;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        // t is the amount to interpolate by, i.e. the amount of colour 1 and 2 to mix. 0 = all colour1, 1 = all colour2, 0.5 = 50 : 50 mix
        float t = time / duration;

        // The current colour (Lerp = linear interpolate)
        Color current = Color.Lerp(From, To, t);

        // Get the mesh renderer component attached to THIS game object
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        // Get the material the renderer is using to draw the mesh and set its colour to the one we calculated
        renderer.material.color = current;

        // Keep track of the time
        time += Time.deltaTime;

        // Reset time when duration is exceeded so that lerp starts again
        if (time > duration) time = 0;
	}
}
