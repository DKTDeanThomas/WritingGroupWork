using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool isHolding;
    public int collected = 0;
    public int targetNumber = 0;


    public bool hasClothes;

    private void Update()
    {
        if (collected == targetNumber)
        {
            Debug.Log("All items collected");
        }
    }
}
