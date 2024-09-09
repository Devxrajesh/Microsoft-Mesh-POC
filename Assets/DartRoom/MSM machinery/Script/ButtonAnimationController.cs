using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationController : MonoBehaviour
{
    public Animator animator;  // Reference to the Animator component
    private bool isPlaying = false;  // To track the state of animation

    void Start()
    {
        // Ensure the animator is attached
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    // This method is triggered when the avatar interacts with the button
    public void OnButtonPressed()
    {
        if (isPlaying)
        {
            // Stop the animation if it's playing
            animator.SetBool("isPlaying", false);
            isPlaying = false;
        }
        else
        {
            // Start the animation if it's not playing
            animator.SetBool("isPlaying", true);
            isPlaying = true;
        }
    }

    // Optional method if you want to detect when the avatar touches the button
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Avatar"))  // Assuming the avatar has a tag "Avatar"
        {
            OnButtonPressed();
        }
    }
}

