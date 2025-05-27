using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] List<PuzzleUi> puzzleUis;

    private void Awake()
    {
        foreach (PuzzleUi puzzleUi in puzzleUis)
        {
            puzzleUi.SetOnCloseEvnet(SetCharacterMovd);

            PuzzleLogic puzzleLogic = puzzleUi.getPuzzleLogic();
            puzzleLogic.Init();
        }
    }

    public void OpenPuzzle(int puzzleIndex)
    {
        PuzzleUi puzzleUi = puzzleUis[puzzleIndex];
        SetCharacterUnMove();
        puzzleUi.Show();
    }

    public void SetCharacterUnMove()
    {
        Debug.Log("캐릭터 멈춤");
    }

    public void SetCharacterMovd()
    {
        Debug.Log("캐릭터 움직임");
    }
}
