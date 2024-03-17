using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchObject : MonoBehaviour
{
    [Header("Interactable related references")]
    public Transform lookingAt; //camera
    public float interactRange;
    public LayerMask interactable;

    public KeyCode interactKey = KeyCode.Mouse0;

    [Header("Crosshair related")]
    public GameObject crosshairNormal;
    public GameObject crosshairHover;

    private void Update()
    {
        VibeCheck();
    }

    private void VibeCheck()
    {
        RaycastHit hit;
        if (Physics.Raycast(lookingAt.position, lookingAt.forward, out hit, interactRange, interactable))
        {

            crosshairNormal.SetActive(false);
            crosshairHover.SetActive(true);


            if (Input.GetKey(interactKey))
            {
                //code here
            }

        }

        else
        {
            crosshairNormal.SetActive(true);
            crosshairHover.SetActive(false);
        }
    }
}
