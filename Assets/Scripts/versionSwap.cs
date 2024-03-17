using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class versionSwap : MonoBehaviour
{
    public gameManager MotherExecuter;

    [Header("Interactable related references")]
    public Transform lookingAt; //camera
    public float interactRange;
    public LayerMask triggerswap;

    public KeyCode interactKey = KeyCode.Mouse0;

    [Header("Crosshair related")]
    public GameObject crosshairNormal;
    public GameObject crosshairHover;

    public void Update()
    {
        SwapVersionGo();
    }

    private void SwapVersionGo()
    {
        if (Physics.Raycast(lookingAt.position, lookingAt.forward, out _, interactRange, triggerswap))
        {
            crosshairNormal.SetActive(false);
            crosshairHover.SetActive(true);

            if (Input.GetKey(interactKey))
            {
                MotherExecuter.SwapToNight();
            }
        }

        else
        {
            crosshairNormal.SetActive(true);
            crosshairHover.SetActive(false);
        }
    }
}
