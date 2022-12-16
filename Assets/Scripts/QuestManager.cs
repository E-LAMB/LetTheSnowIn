using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class QuestManager
{

    static int main_story_progression;
    
    public static void main_quest_update(int progress)
    {
        main_story_progression = progress;
    }

    public static int query_main_quest_progress()
    {
        return main_story_progression;
    }

}
