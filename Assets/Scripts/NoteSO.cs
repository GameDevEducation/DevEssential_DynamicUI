using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Note", fileName = "Note")]
public class NoteSO : ScriptableObject
{
    public string Title;
    [TextArea(5, 50)] public string Content;
}
