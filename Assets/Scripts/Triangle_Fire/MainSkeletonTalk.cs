using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSkeletonTalk : MonoBehaviour
{
    public float start_delay;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayedStart());   
    }

    IEnumerator DelayedStart(){
        yield return new WaitForSeconds(start_delay);
        this.GetComponent<Animator>().Play("Talking");
        this.GetComponent<AudioSource>().enabled = true;
    }
}
