using System;
using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Here");
        other.transform.position = Vector3.zero;
    }
}
