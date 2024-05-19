using System.Collections;
using System.Collections.Generic;
using UnityEngine;
interface IInteractable 
{
    public void Interact();
}


public class Interactor : MonoBehaviour
{
    public Transform interactorSource;              //Get the sourcecameras transform
    public float interactRange;                    //Range at which I want to be able to interact | Decrease for less interact distance

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray r = new Ray(interactorSource.position, interactorSource.forward);           //Create a new ray cast forward from the Camera transform
            if (Physics.Raycast(r, out RaycastHit hitInfo, interactRange))                 // If you hit something within the interactRange then...
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) // Check if it has the interactable interface then..
                { 
                    interactObj.Interact();                                                     //Interact with the object.
                }
            }
        }
    }
}
