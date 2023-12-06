using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //Message when player interacts.
    public string promptMessage;
    
    public void BaseInteract()
    {
        //Called from the Player.
        Interact();
    }
    protected virtual void Interact()
    {
        //Overridden by the subclasses.
    }
}
