using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interactor : MonoBehaviour
{
    public float range = 2f;
    public Camera cam;
    public LayerMask interactableLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
        {
            Interact();
        }
    }

    void Interact()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range, interactableLayer))
        {
            Debug.Log(hit.transform.name);
            Object_Interact target = hit.transform.GetComponent<Object_Interact>();

            if (target != null)
            {
                target.Respond();
            }
        }
    }
}
