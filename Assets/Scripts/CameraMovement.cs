using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour {
    public Transform Objtransform;
    public GameObject Hologram;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Objtransform);
	}
    public void GoBigger()
    {
        Vector3 vec = new Vector3(1f, 1f, 1f);
        Vector3 vecComp = new Vector3(0.3f, 0.3f, 0.3f);
        Vector3 comparisonPosition = Hologram.transform.localScale;
        if (comparisonPosition.magnitude >= vecComp.magnitude * 3)
        {
            Debug.Log("Is already to big");
        }
        else
        {

            Hologram.transform.localScale = Vector3.Slerp(Hologram.transform.localScale, Hologram.transform.localScale + vecComp, 0.1f); /*Vector3(Mathf.Lerp(Hologram.transform.localScale.x,Hologram.transform.localScale.x + vecComp.x ,0.1f),
                                                        Mathf.Lerp(Hologram.transform.localScale.y, Hologram.transform.localScale.y + vecComp.y, 0.1f),
                                                        Mathf.Lerp(Hologram.transform.localScale.z, Hologram.transform.localScale.z + vecComp.z, 0.1f));*/
        }
        
    }
    public void GoSmaller()
    {
        Vector3 vec = new Vector3(1f, 1f, 1f);
        Vector3 vecComp = new Vector3(0.3f, 0.3f, 0.3f);
        Vector3 comparisonPosition = Hologram.transform.localScale;
        if (comparisonPosition.magnitude <= vecComp.magnitude)
        {
            Debug.Log("Is already to small");
        }
        else
        {

            Hologram.transform.localScale = Hologram.transform.localScale - (vec * 0.3f);
        }
    }
    
}
