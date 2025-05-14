using TMPro;
using UnityEngine;

public class UITextManager : MonoBehaviour
{
    public static UITextManager Instance { get; private set; }
    [SerializeField] private GameObject itemAchieveText;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        CloseItemAchieveText();

        Instance = this;
        DontDestroyOnLoad(gameObject); 
    }

    public void GetItem(Item item){
        itemAchieveText.GetComponent<TextMeshProUGUI>().text = "Got " + "\"" + item.ItemName + "\"";
        OpenItemAchieveText();

        Invoke(nameof(CloseItemAchieveText), 2.0f);
    }

    private void CloseItemAchieveText(){
        itemAchieveText.GetComponent<CanvasGroup>().alpha = 0;
    }

    private void OpenItemAchieveText(){
        itemAchieveText.GetComponent<CanvasGroup>().alpha = 1;
    }
}