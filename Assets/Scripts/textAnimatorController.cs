using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class textAnimatorController : MonoBehaviour
{
    public XRGazeInteractor xRGazeInteractor;

    public Animator animationController;
    public GameObject memoryPalaceObject;

    public string gazeObjectName;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeIn()
    {
        animationController.Play("Fade In Text");
    }
    
    public void FadeOut()
    {
        animationController.Play("Fade Out Text");
    }

    public void FindAnimator()
    {

        animationController = memoryPalaceObject.GetComponentInChildren<Animator>();
        if (animationController == null)
        {
            Debug.LogError("Could not find animation controller");
        }
    }
}
