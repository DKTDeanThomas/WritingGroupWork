using UnityEngine;

public class BasketInteract : MonoBehaviour, IInteractible
{
    [SerializeField] private bool inspect;
    [SerializeField] private bool examine;
    [SerializeField] private bool shoulddestroy;
    [SerializeField] private GameObject examineCamera;
    public bool Inspect { get { return inspect; } }
    public bool Examine { get { return examine; } }
    public bool shouldDestroy { get { return shoulddestroy; } }
    public GameObject ExamineCam { get { return examineCamera; } }

    public string text;
    public string text2;

    public CommsManager cM;

    private void Start()
    {
        cM = GameObject.FindWithTag("DialogueManager").GetComponent<CommsManager>();
    }

    public bool Interact(Interactors interact)
    {
        if (GameObject.Find("Player").GetComponent<PlayerInventory>().hasClothes == true)
        {
            cM.InteractComment(text);
            GameObject.Find("Player").GetComponent<PlayerInventory>().isHolding = false;
            GameObject.Find("Player").GetComponent<PlayerInventory>().hasClothes = true;

            GameObject.Find("Player").GetComponent<PlayerInventory>().collected++;
        }

        else if (GameObject.Find("Player").GetComponent<PlayerInventory>().hasClothes == false)
        {
            cM.InteractComment(text2);
        }



            return false;

    }
}
