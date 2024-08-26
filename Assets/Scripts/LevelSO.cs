using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "level", menuName = "new level", order = 51)]
public class LevelSO : ScriptableObject
{
    public int levelNumber;
    public Scene sceneToLoad;
}
