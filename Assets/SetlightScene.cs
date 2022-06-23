using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SceneSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetlightScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IMixedRealitySceneSystem sceneSystem = MixedRealityToolkit.Instance.GetService<IMixedRealitySceneSystem>();


        // Additively load a single content scene
        sceneSystem.LoadContent("selectedScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
