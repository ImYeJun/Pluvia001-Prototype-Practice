using System;
using UnityEngine;
using UnityEngine.Events;

public abstract class PuzzleUi : MonoBehaviour
{
    protected PuzzleLogic generalPuzzleLogic;
    private Action onClose;
    [SerializeField] private GameObject gui;

    public void Show()
    {
        gui.SetActive(true);
    }
    
    public void Close()
    {
        gui.SetActive(false);
        onClose.Invoke();
    }

    public void SetOnCloseEvnet(Action onCloseEvent)
    {
        onClose = onCloseEvent;
    }
    public PuzzleLogic getPuzzleLogic() { return generalPuzzleLogic; }
}
