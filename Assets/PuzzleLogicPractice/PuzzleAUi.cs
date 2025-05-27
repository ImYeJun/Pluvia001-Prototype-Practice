using TMPro;
using UnityEngine;

public class PuzzleAUi : PuzzleUi
{
    [SerializeField] private PuzzleALogic puzzleLogic;
    [SerializeField] private TextMeshProUGUI currentValueText;

    private void Awake()
    {
        generalPuzzleLogic = puzzleLogic;
    }

    public void addValue()
    {
        puzzleLogic.addValue();
        currentValueText.text = "CurrentValue : " + puzzleLogic.getCurrentValue();
    }
}
