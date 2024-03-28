using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CutsceneTrigger : MonoBehaviour
{
    [Header("Player variables")]
    public GameObject Player;
    public AudioListener PlayerListener;

    public GameObject crosshairNormal;
    public GameObject crosshairHover;

    [Header("Cutscene Cameras")]
    public GameObject ccLilypads;
    public GameObject ccLights;
    public GameObject ccPaint;
    public GameObject ccAylaBack;
    public GameObject ccAylaSide;
    public GameObject ccAylaLift;

    [Header("Ayla")]
    public GameObject AylaHolding;
    public GameObject AylaWalking;
    public GameObject AylaPointing;
    public GameObject AylaLifiting;

    [Header("Cutscene objects")]
    public GameObject LanternHolding;
    public GameObject LanternWalking;
    public GameObject LanternLifting;

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        ccLilypads.SetActive(true); //lilypads

        crosshairNormal.SetActive(false);
        crosshairHover.SetActive(false);
        Player.SetActive(false);
        PlayerListener.enabled = false;

        StartCoroutine(CamSwitchOne());

        StartCoroutine(CamSwitchTwo());

        StartCoroutine(CamSwitchThree());

        StartCoroutine(CamSwitchFour());

        StartCoroutine(CamSwitchFive());

        StartCoroutine(FinishCutscene());
    }

    IEnumerator CamSwitchOne() //lilypads to lights
    {
        yield return new WaitForSeconds(4);
        ccLights.SetActive(true);

        ccLilypads.SetActive(false);
    }

    IEnumerator CamSwitchTwo() //lights to paint
    { 
        yield return new WaitForSeconds(8);
        ccPaint.SetActive(true);

        AylaHolding.SetActive(false);
        LanternHolding.SetActive(false);

        ccLights.SetActive(false);
    }

    IEnumerator CamSwitchThree() //paint to ayla back
    {
        yield return new WaitForSeconds(12);
        AylaWalking.SetActive(true);
        LanternWalking.SetActive(true);

        ccAylaBack.SetActive(true);

        ccPaint.SetActive(false);
    }

    IEnumerator CamSwitchFour() //ayla back to ayla looking up
    {
        yield return new WaitForSeconds(16);
        AylaPointing.SetActive(true);

        AylaWalking.SetActive(false);
        LanternWalking.SetActive(false);

        ccAylaSide.SetActive(true);

        ccAylaBack.SetActive(false);
    }

    IEnumerator CamSwitchFive() //ayla looking up to ayla lift
    {
        yield return new WaitForSeconds(18);
        AylaLifiting.SetActive(true);
        AylaPointing.SetActive(false);
        LanternLifting.SetActive(true);
        ccAylaLift.SetActive(true);

        ccAylaSide.SetActive(false);
    }


    IEnumerator FinishCutscene()
    {
        yield return new WaitForSeconds(21);

        Player.SetActive(true);
        crosshairNormal.SetActive(true);
        crosshairHover.SetActive(true);
        PlayerListener.enabled = true;

        ccAylaLift.SetActive(false);
    }
}
