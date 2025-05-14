using UnityEngine;

public abstract class Item : MonoBehaviour, IInteractable
{
    [SerializeField] protected string itemName;
    public string ItemName => itemName;


    virtual public void Interact(){
        UITextManager.Instance.GetItem(this);
    }
}
