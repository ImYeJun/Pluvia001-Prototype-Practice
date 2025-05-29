using TMPro;
using UnityEngine;

public class PuzzleAUi : PuzzleUi
{
    [SerializeField] private PuzzleALogic puzzleLogic;
    [SerializeField] private TextMeshProUGUI currentValueText;

    public void addValue()
    {
        puzzleLogic.addValue();
        currentValueText.text = "CurrentValue : " + puzzleLogic.getCurrentValue();
    }

    public override PuzzleLogic getPuzzleLogic(){
        return puzzleLogic;
    } 
}
