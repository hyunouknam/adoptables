using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class SaveLoad : MonoBehaviour
{

    FileInfo f;

    void Start()
    {
        //f = new FileInfo(Application.persistentDataPath + "\\" + "adoptablesFile.txt");
    }

    void Save()
    {
        StreamWriter w;
        if (!f.Exists)
        {
            w = f.CreateText();
        }
        else
        {
            f.Delete();
            w = f.CreateText();
        }
        //w.WriteLine(loadMessage);
        w.Close();
    }

    void Load()
    {
        StreamReader r = File.OpenText(Application.dataPath + "\\" + "adoptablesFile.txt");
        string info = r.ReadToEnd();
        r.Close();
        //data = info;
    }
}