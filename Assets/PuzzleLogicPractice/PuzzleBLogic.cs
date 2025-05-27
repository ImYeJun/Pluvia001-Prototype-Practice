using UnityEngine;

public class PuzzleBLogic : PuzzleLogic
{
    [SerializeField] private int currentValue;

    public override void Init()
    {
        currentValue = 0;
        Debug.Log("PuzzleB 초기화 완료");
    }

    public void subtractValue()
    {
        currentValue--;
    }

    public int getCurrentValue() { return currentValue; }
}
