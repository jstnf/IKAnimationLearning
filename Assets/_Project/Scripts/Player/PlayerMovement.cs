using System;
using System.ComponentModel;
using UnityEngine;

namespace IKAnimationLearning.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Serializable]
        public struct MovementStats
        {
            public float MovementSpeed;
            public float JumpForce;
        }

        [Description("Player movement stats")] [SerializeField]
        private MovementStats stats;
    }
}