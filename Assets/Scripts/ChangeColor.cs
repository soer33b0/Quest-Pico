using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public float distance;
    public OVRInput.RawButton button;
    public Color color;
    RaycastHit rayray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distance, Color.magenta);

        if (Physics.Raycast(this.transform.position, this.transform.forward, out rayray, distance) && OVRInput.Get(button) == true)
        {
            rayray.collider.gameObject.GetComponent<Renderer>().material.color = color;
        }
    }
}
