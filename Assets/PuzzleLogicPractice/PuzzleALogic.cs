using UnityEngine;

public class PuzzleALogic : PuzzleLogic
{
    [SerializeField] private int currentValue;

    public override void Init()
    {
        currentValue = 0;
        Debug.Log("PuzzleA 초기화 완료");
    }

    public void addValue()
    {
        currentValue++;
    }

    public int getCurrentValue() { return currentValue; }
}
