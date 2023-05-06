using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Hit : MonoBehaviour
{
    public bool OK;
    public GameObject Sound_Live, Sound_Dead,Blood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OK)
        {
            gameObject.GetComponent<Animator>().Play("Zombie Dying");
            gameObject.GetComponent<Collider>().enabled = false;
            Sound_Dead.SetActive(true);
            Sound_Live.SetActive(false);
            Blood.SetActive(true);
            OK = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "¤l¼u")
        {
            OK = true;
        }
    }
}
