using UnityEngine;
using UnityEngine.Events;

public class PuzzleOpenObject : MonoBehaviour, IInteractable
{
    [SerializeField] private int puzzleIndex;
    [SerializeField] private UnityEvent<int> onInteract;

    public void Interact()
    {
        onInteract.Invoke(puzzleIndex);
    }
}
