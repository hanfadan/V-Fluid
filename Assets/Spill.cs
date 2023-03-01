using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spill : MonoBehaviour
{
    ParticleSystem MyParticleSystem;

    // Start is called before the first frame update
    void Start()
    {
        MyParticleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Angle(Vector3.down, transform.forward) <=90f)
        {
            MyParticleSystem.Play();
        }
        else
        {
            MyParticleSystem.Stop();
        } 
    }
        
}
