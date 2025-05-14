using UnityEngine;

public class SwisRollCake : Item
{
    override public void Interact(){
        Debug.Log("이거 스위스 롤케익이야");
        base.Interact();
        Destroy(gameObject);
    }
}
