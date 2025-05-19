using UnityEngine;

public class DataContainer : MonoBehaviour
{
    public CommonDataContainerData scriptableObject;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.F))
        {
            scriptableObject.cnt++;
        }
    }
}
