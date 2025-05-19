using UnityEngine;

public class DataContainer1 : MonoBehaviour
{
    public CommonDataContainerData scriptableObject; 

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Cnt : " + scriptableObject.cnt);
        }
    }
}
