using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSkeletonsAction : MonoBehaviour
{
    //Should be attached to Main camera
    public float start_delay_action;
    public GameObject building;
    public GameObject skeleton1, skeleton2, skeleton3, skeleton4, skeleton5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayedStartAction());
    }

    IEnumerator DelayedStartAction()
    {
        yield return new WaitForSeconds(start_delay_action);
        skeleton1.GetComponent<Animator>().Play("Action 1");
        skeleton2.GetComponent<Animator>().Play("Action 2");
        skeleton3.GetComponent<Animator>().Play("Action 3");
        skeleton4.GetComponent<Animator>().Play("Action 4");
        skeleton5.GetComponent<Animator>().Play("Action 5");


        building.GetComponent<Animator>().enabled = true;
        building.GetComponent<AudioSource>().enabled = true;

        this.GetComponent<FireStart>().enabled = true;
    }
}
