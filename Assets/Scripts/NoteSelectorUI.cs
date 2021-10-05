using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

[System.Serializable]
public class NoteSelectedEvent : UnityEvent<NoteSO> {}

public class NoteSelectorUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI LinkedText;

    public NoteSelectedEvent OnNoteSelected = new NoteSelectedEvent();

    NoteSO LinkedNote;

    public void Bind(NoteSO note)
    {
        LinkedNote = note;
        LinkedText.text = note.Title;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSelected()
    {
        OnNoteSelected.Invoke(LinkedNote);
    }
}
