using System;
using UnityEngine;
using UnityEngine.Events;

public abstract class PuzzleUi : MonoBehaviour
{
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
    
    abstract public PuzzleLogic getPuzzleLogic();
}
