using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInteract : MonoBehaviour, IInteractible
{

    [SerializeField] private bool inspect;
    [SerializeField] private bool examine;
    [SerializeField] private bool shoulddestroy;
    [SerializeField] private GameObject examineCamera;
    public bool Inspect { get { return inspect; } }
    public bool Examine { get { return examine; } }
    public GameObject ExamineCam { get { return examineCamera; } }
    public bool shouldDestroy { get { return shoulddestroy; } }

    public string text;


    public bool Interact(Interactors interact)
    {
        return false;

    }
}
