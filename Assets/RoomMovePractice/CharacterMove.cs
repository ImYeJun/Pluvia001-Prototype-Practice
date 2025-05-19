using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] private List<GameObject> doors;
    private CinemachineConfiner2D cinemachineConfiner;
    private GameObject currentDoor;

    private void Awake()
    {
        cinemachineConfiner = GetComponent<CinemachineConfiner2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetCurrentDoor(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetCurrentDoor(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetCurrentDoor(2);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Move();
        }
    }

    private void SetCurrentDoor(int index)
    {
        if (index >= 0 && index < doors.Count)
        {
            currentDoor = doors[index];
            Debug.Log($"Set to {index + 1}");
        }
    }

    private void Move()
    {
        if (currentDoor != null)
        {
            var collider = currentDoor.GetComponent<PolygonCollider2D>();
            Debug.Log("Current Collider : " + collider);
            if (collider != null)
            {
                Debug.Log("Before : " + cinemachineConfiner.BoundingShape2D);
                // cinemachineConfiner.InvalidateBoundingShapeCache();
                cinemachineConfiner.BoundingShape2D = collider;
                Debug.Log("After : " + cinemachineConfiner.BoundingShape2D);
                // cinemachineConfiner.InvalidateBoundingShapeCache();
                transform.position = currentDoor.transform.position;
            }
            else
            {
                Debug.LogWarning("Current door has no PolygonCollider2D.");
            }
        }
    }
}
