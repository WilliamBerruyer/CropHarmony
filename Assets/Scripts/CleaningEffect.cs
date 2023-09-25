using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CleaningEffect : MonoBehaviour
{
    public ParticleSystem cleaningParticles; 

    private bool isTouchingHorse = false; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HorseAnimations")) // Checks if the collider belongs to the horse
        {
            // Play cleaning particle effect
            cleaningParticles.Play();
            isTouchingHorse = true; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HorseAnimations")) // Check if the collider belongs to the horse
        {
            // Stop particle effect when exiting the trigger zone
            cleaningParticles.Stop();
            isTouchingHorse = false; // Set the flag to false when not touching horse
        }
    }

    private void OnCollisionEnter(Collision collide)
    {
        Debug.Log("Testttttttttt");
        if (collide.gameObject.CompareTag("HorseAnimations")) // Check if the collider belongs to horse
        {
            // Play the particle effect
            cleaningParticles.Play();
            isTouchingHorse = true; // Set flag to true when colliding with horse
        }
    }

    

    
    private void Update()
    {
        if (!isTouchingHorse)
        {
            cleaningParticles.Stop();
        }
    }
}


