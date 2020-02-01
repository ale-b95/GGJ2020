﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterAnchorCollisions : MonoBehaviour
{
    [SerializeField]
    private GameObject inactiveChild;

    [SerializeField]
    private GameObject rightPart;

    // TODO - On trigger stay
    // hiltight this to give feedback
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SnapSlave")
        {
            
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
                    
            StartCoroutine(Destroy(other.gameObject));        

            // TODO - Check if this is already active?
            // TODO - Create a copy and then set active?
            inactiveChild.SetActive(true);
        }
    }

    public void AssignRightPart(GameObject part) { 
        this.rightPart = part;
    }

    private IEnumerator Destroy(GameObject gameobject) { 
        yield return new WaitForSeconds(5.0f);
        
        Destroy(gameobject);
    }
}
