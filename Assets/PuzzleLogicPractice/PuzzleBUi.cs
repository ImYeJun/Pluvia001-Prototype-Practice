using TMPro;
using UnityEngine;

public class PuzzleBUi : PuzzleUi
{
    [SerializeField] private PuzzleBLogic puzzleLogic;
    [SerializeField] private TextMeshProUGUI currentValueText;

    public void subtractValue()
    {
        puzzleLogic.subtractValue();
        currentValueText.text = "CurrentValue : " + puzzleLogic.getCurrentValue();
    }

    override public PuzzleLogic getPuzzleLogic(){
        return puzzleLogic;
    }
}
