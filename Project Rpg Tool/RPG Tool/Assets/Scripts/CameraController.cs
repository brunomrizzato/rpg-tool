using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    #region Variables
    [SerializeField]
    private float float_speedy;
    [SerializeField]
    private GameObject gobj_transform;
    [SerializeField]
    private GameObject gobj_camera;
    #endregion

    #region Functions
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

		if(Input.GetKey(KeyCode.W) && Input.GetMouseButton(2))
        {
            gobj_transform.transform.localPosition +=transform.forward * float_speedy * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) && Input.GetMouseButton(2))
        {
            gobj_transform.transform.localPosition += -1 *transform.forward * float_speedy * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && Input.GetMouseButton(2))
        {
            gobj_transform.transform.localPosition += transform.right * float_speedy * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) && Input.GetMouseButton(2))
        {
            gobj_transform.transform.localPosition += -1 * transform.right * float_speedy * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E) && Input.GetMouseButton(2))
        {
            gobj_transform.transform.localPosition += transform.up * float_speedy * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q) && Input.GetMouseButton(2))
        {
            gobj_transform.transform.localPosition += -1 * transform.up * float_speedy * Time.deltaTime;
        }
    }
    #endregion
}
