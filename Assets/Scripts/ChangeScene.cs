// I got help with this script from  a Udemy course https://www.udemy.com/course/develop-augmented-reality-book-ar-business-card-with-unity/learn/lecture/23133230#overview

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
 public void LoadARScene()
 {
    SceneManager.LoadScene("Game Scene");
 }

 public void ExitApp()
 {
    Application.Quit();
    Debug.Log("You have quit the app");
 }
}
