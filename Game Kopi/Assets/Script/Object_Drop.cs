using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Drop : Object_Interact
{
    public Transform dropSlot;
    public bool isSlotFull = false;
    public override void Respond()
    {
        base.Respond();
        if (Object_Pickup.isRightFull && Input.GetButtonDown("Fire1"))
        {
            getRight();
        }
        else if (Object_Pickup.isLeftFull && Input.GetButtonDown("Fire2"))
        {
            getLeft();
        }
        
        if (transform.childCount <= 0)
        {
            isSlotFull = false;
        }
    }

    public void getRight()
    {
        Transform onRight = GameObject.Find("RightSlot").transform.GetChild(0).transform;
        isSlotFull = true;
        Object_Pickup.isRightFull = false;

        onRight.SetParent(dropSlot, true);
        onRight.localPosition = Vector3.zero;
        onRight.localRotation = Quaternion.Euler(Vector3.zero);
        onRight.localScale = Vector3.one;

    }

    public void getLeft()
    {
        Transform onLeft = GameObject.Find("LeftSlot").transform.GetChild(0).transform;

        isSlotFull = true;
        Object_Pickup.isLeftFull = false;

        onLeft.SetParent(dropSlot, true);
        onLeft.localPosition = Vector3.zero;
        onLeft.localRotation = Quaternion.Euler(Vector3.zero);
        onLeft.localScale = Vector3.one;
    }
}
