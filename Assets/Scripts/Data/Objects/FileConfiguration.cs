using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UserConfiguration", menuName = "Mother/File", order = 1)]
public class FileConfiguration : ScriptableObject
{
 public string FileName;
 public int FileDim;
 public string FileImg;
 public string FileContents;
 
}
