using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageLogUI : MonoBehaviour
{
    [SerializeField] List<NoteSO> Messages;
    [SerializeField] GameObject MessageEntryPrefab;
    [SerializeField] Transform MessageEntryRoot;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var message in Messages)
        {
            // instantiate the message prefab
            var messageGO = Instantiate(MessageEntryPrefab, Vector3.zero, Quaternion.identity, MessageEntryRoot);

            // retrieve and configure the message
            messageGO.GetComponent<MessageEntryUI>().Bind(message.Content);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
