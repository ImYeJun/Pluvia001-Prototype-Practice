using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    private CircleCollider2D circleCollider;
    private Item inRangeItem;

    private void Awake() {
        circleCollider = GetComponent<CircleCollider2D>();
        inRangeItem = null;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable")){
            inRangeItem = collision.GetComponent<Item>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inRangeItem = null;
    }

    private void Update() {
        if (inRangeItem && Input.GetKeyDown(KeyCode.F)){
            inRangeItem.Interact();
        }

    }
}
