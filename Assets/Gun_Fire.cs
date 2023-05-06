using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Gun_Fire : MonoBehaviour
{
    public SteamVR_Input_Sources 手把輸入源;
    public SimpleShoot SimpleShoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SteamVR_Input.GetStateDown("InteractUI", 手把輸入源))
        {
            SimpleShoot.OK = true;
        }
    }
}
