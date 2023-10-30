using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour

{
  

    List<string> QuestPartyMember = new List<string>()
    {
        "Grim the Barbarian",
        "Merlin the Wise",
        "Sterling the Knight"

    };
    // Start is called before the first frame update
    void Start()
    {
        AddPartyMember("Sofie Hansen", 1);
        FindPartyMember();
       
    }

    public void FindPartyMember()
    {


        int listLength = QuestPartyMember.Count;

        for (int i = 0; i < listLength; i++)
        {
            Debug.Log(QuestPartyMember[i]);

        }

    }

        public void AddPartyMember(string name, int myIndex)

    {

        QuestPartyMember.Insert(myIndex, name);
    }
}
