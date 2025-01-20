using System.ComponentModel;
using UnityEngine;

namespace IKAnimationLearning
{
    public class SceneManager : MonoBehaviour
    {
        [Description("Inital scene to open when launched from persistent scene.")] [SerializeField]
        public Scenes initialSceneToLoad;
    }
}