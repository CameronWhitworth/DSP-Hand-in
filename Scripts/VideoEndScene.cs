using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEndScene : MonoBehaviour
{
    public float delay = 150;

    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    public string SceneName;
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay)); // Start Timer

        VideoPlayer.frame = 500; //Video is 24fps (500 frames = 20sec)
        
    }
    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneName); //Select Scene in component
    }
    
}