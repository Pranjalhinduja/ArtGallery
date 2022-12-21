using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisibility : MonoBehaviour
{
    void OnLevelWasLoaded(int level)
    {
            Cursor.visible = true;
        Screen.lockCursor = false;
    }
}
