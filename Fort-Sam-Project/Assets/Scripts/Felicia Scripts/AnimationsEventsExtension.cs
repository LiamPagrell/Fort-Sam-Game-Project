using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimationsEventsExtension 
{
    public static void AddAnimationEvent(this AnimationClip clip, float time, string functionName)
    {
        float clipDuration = clip.length;

        if (time < 0f)
        {
            Debug.LogError("Event time must be greather than 0");
            return;
        }
        else if (time > clipDuration)
        {
            Debug.LogError("Event time must be less than clipsduration"+clipDuration+"f seconds");
            return;
        }
        AnimationEvent animationEvent = new AnimationEvent();
        animationEvent.time = time;
        animationEvent.functionName = functionName;
        clip.AddEvent(animationEvent);
    }
}
