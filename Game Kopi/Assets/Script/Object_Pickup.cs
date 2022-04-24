using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Pickup : Object_Interact
{
    public Transform rightHand, leftHand;

    public bool picked;
    public static bool isRightFull = false;
    public static bool isLeftFull = false;

    public void Awake()
    {
        rightHand = GameObject.Find("RightSlot").GetComponent<Transform>();
        leftHand = GameObject.Find("LeftSlot").GetComponent<Transform>();
    }

    public override void Respond()
    {
        base.Respond();
        if (!isRightFull && Input.GetButtonDown("Fire1"))
        {
            PickUpRight();
        }
        else if (!isLeftFull && Input.GetButtonDown("Fire2"))
        {
            PickUpLeft();
        }

    }

    void PickUpRight()
    {
        picked = true;
        isRightFull = true;

        transform.SetParent(rightHand);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;
    }

    void PickUpLeft()
    {
        picked = true;
        isLeftFull = true;

        transform.SetParent(leftHand);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;
    }

    void DropLeft(GameObject location)
    {
        picked = false;
        isLeftFull = false;

        transform.SetParent(location.transform);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;
    }

    void DropRight(GameObject location)
    {
        picked = false;
        isRightFull = false;

        transform.SetParent(location.transform);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;
    }
        
    
}
