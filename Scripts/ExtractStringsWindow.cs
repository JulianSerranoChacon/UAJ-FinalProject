using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExtractStringsWindow : EditorWindow
{
    // Incluye una entrada en el menu superior de Unity
    [MenuItem("Custom Plugins/Extract UI Strings from Build Scenes")]
    public static void ShowWindow()
    {
        // Nombre del "Tab" en la ventna del editor
        GetWindow<ExtractStringsWindow>("UI Strings Extractor");
    }

    // Dibuja la interfaz en la ventana del editor
    void OnGUI()
    {
        GUILayout.Label("Plugin Configuration", EditorStyles.boldLabel);
        EditorGUILayout.Space();

        // Boton que ejecuta el script de extraccion
        if (GUILayout.Button("Extract All Strings"))
        {
            ExtractStrings();
        }
    }

    void ExtractStrings()
    {
        Debug.Log("Poner el script de extraccion aqui");
    }
}
