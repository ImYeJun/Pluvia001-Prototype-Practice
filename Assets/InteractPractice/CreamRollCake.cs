using UnityEngine;

public class CreamRollCake : Item
{
    override public void Interact(){
        Debug.Log("센세 크림이 너무 꾸덕한걸~★");
        base.Interact();
        Destroy(gameObject);
    }
}
