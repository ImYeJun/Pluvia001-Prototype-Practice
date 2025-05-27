using TMPro;
using UnityEngine;

public class PuzzleBUi : PuzzleUi
{
    [SerializeField] private PuzzleBLogic puzzleLogic;
    [SerializeField] private TextMeshProUGUI currentValueText;

    private void Awake() {
        generalPuzzleLogic = puzzleLogic;
    }

    public void subtractValue()
    {
        puzzleLogic.subtractValue();
        currentValueText.text = "CurrentValue : " + puzzleLogic.getCurrentValue();
    }
}
