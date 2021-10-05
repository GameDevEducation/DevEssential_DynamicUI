using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageEntryUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MessageContent;

    public void Bind(string messageText)
    {
        MessageContent.text = messageText;

        // query the dimensions based on the current content
        var dimensions = MessageContent.GetPreferredValues();

        // resize the rect for the text
        ((RectTransform)MessageContent.transform).SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, dimensions.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
