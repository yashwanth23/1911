using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Skeleton_spawn : MonoBehaviour
{
    public GameObject Player;
    public GameObject tomb;
    public GameObject skeleton;
    public ParticleSystem smoke;
    float scale;

    public bool spawn;
    Animator animator;
    // Use this for initialization
    void Start()
    {
        spawn = false;
        scale = Random.Range(0.2f, 0.6f);
    }

    // Update is called once per frame
    void Update()
    {

    } 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            Instantiate(smoke, tomb.transform.position, Quaternion.LookRotation(Vector3.up));
            GameObject newSkeleton = Instantiate(skeleton, tomb.transform.position, Quaternion.identity);
            newSkeleton.transform.rotation = Quaternion.Euler(0, 90, 0);
            newSkeleton.transform.localScale = new Vector3(scale, scale, scale);
            //newSkeleton.transform.LookAt(Player.transform);
            animator = newSkeleton.GetComponent<Animator>();
            int i = Mathf.RoundToInt(Random.Range(1, 6));
            animator.SetInteger("AnimNumber", i);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "player")
        {
            spawn = true;
        }
    }
}