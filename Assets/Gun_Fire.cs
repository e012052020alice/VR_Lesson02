using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Gun_Fire : MonoBehaviour
{
    public SteamVR_Input_Sources ����J��;
    public SimpleShoot SimpleShoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SteamVR_Input.GetStateDown("InteractUI", ����J��))
        {
            SimpleShoot.OK = true;
        }
    }
}
