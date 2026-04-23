using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace W4Activity
{
    [CreateAssetMenu(fileName = "DialogueLineW4", menuName = "ScriptableObjects/DialogueLine W4 activity", order = 1)]

    
    public class DialogueNodeW4 : ScriptableObject
    {
        public GameObject sprite;
        //---------------------------------------------------------------------
        // Variables
        //---------------------------------------------------------------------
        [Tooltip("The line of dialogue the NPC says in this node.")]
        public string Line;

        [Tooltip("[Optional] The dialogue options for the player's response, and what node each response leads to.")]
        public List<PlayerReplyW4> ReplyOptions;
    }
}