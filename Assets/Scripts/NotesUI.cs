using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NotesUI : MonoBehaviour
{
    [SerializeField] List<NoteSO> Notes;

    [SerializeField] GameObject NoteSelectorPrefab;
    [SerializeField] Transform NoteSelectorRoot;

    [SerializeField] TextMeshProUGUI NoteContent;
    [SerializeField] RectTransform NoteContentRoot;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var note in Notes)
        {
            // instantiate the selector
            var selectorGO = Instantiate(NoteSelectorPrefab, Vector3.zero, Quaternion.identity, NoteSelectorRoot);
            selectorGO.name = "Selector_" + note.name;

            // retrieve and configure the selector script
            var selectorScript = selectorGO.GetComponent<NoteSelectorUI>();
            selectorScript.Bind(note);
            selectorScript.OnNoteSelected.AddListener(OnNoteSelected);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNoteSelected(NoteSO note)
    {
        // update the size of the content area for the note to fit the text
        var dimensions = NoteContent.GetPreferredValues(note.Content, NoteContentRoot.rect.width, NoteContentRoot.rect.height);
        NoteContentRoot.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, dimensions.y);
        NoteContent.text = note.Content;
    }
}
