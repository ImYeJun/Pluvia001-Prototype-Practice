using System;
using UnityEngine;

public abstract class PuzzleLogic : MonoBehaviour
{
    private Action onSolve;
    public bool isSolved;

    private void Awake()
    {
        isSolved = false;
    }

    abstract public void Init();

    public void SetOnSolve(Action action)
    {
        onSolve = action;
    }
}
