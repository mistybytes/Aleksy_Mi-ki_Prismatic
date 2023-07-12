using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public GoogleSave googleSave;
    public SkinManager skinManager;
    
    bool afterBoot = false;

    void Start() {
        afterBoot = false;
    }
    
    void Update() {
        if(afterBoot == false) {
   //         LocalLoadGame();
   //         OnlineLoadGame();
            afterBoot = true;
        }
    }

    public void LocalSaveGame() {
     //   SaveData tData = CreateSavefile();
        //string JSONSave = JsonUtility.ToJson(tData);

       // PlayerPrefs.SetString(saveFilePath, JSONSave);
        PlayerPrefs.Save();
    }
    // Update is called once per frame
}
