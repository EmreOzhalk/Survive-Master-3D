using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectParticle : MonoBehaviour
{
    [SerializeField] ParticleSystem collectParticle = null;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            Collect();
        }
    }

    public void Collect()
    {
        collectParticle.Play();
    }
}