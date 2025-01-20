using UnityEngine;

namespace IKAnimationLearning.Controls
{
    public class SingletonInputManager : MonoBehaviour
    {
        public static SingletonInputManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance)
            {
                return;
            }

            Instance = this;
        }

        private void Start()
        {
            
        }
    }
}