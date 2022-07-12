using System;
using UnityEngine;

namespace UnityTools
{
    public static class AnimationExtensions
    {
        public static void Play(this Animator animator, string state, Action onEnd = null)
        {

        }

        public static float GetAnimationTime(this Animator animator, string state)
        {
            return 0;
        }
    }
}

