using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MaterialChanger : MonoBehaviour
{
    MeshRenderer meshRenderer;

    [SerializeField] Button button;
    [SerializeField] TMP_Text outputIndex;
    [SerializeField] TMP_Text outputName;
    [SerializeField] TMP_Text outputHex;
    
    [SerializeField] Material[] materials;

    private int currentMaterialIndex = 0;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = materials[currentMaterialIndex];

        // Set text to first material
        OutputText(currentMaterialIndex);

        button.onClick.AddListener(ChangeMaterial);
    }

    private void OutputText(int currentMaterialIndex)
    {
        outputIndex.text = "Index: " + currentMaterialIndex;
        outputName.text = "Name: " + materials[currentMaterialIndex].name;
        outputHex.text = "Hex: " + materials[currentMaterialIndex].color.ToHexString();
        
        outputIndex.color = materials[currentMaterialIndex].color;
        outputName.color = materials[currentMaterialIndex].color;
        outputHex.color = materials[currentMaterialIndex].color;
    }

    void ChangeMaterial()
    {
        currentMaterialIndex = (currentMaterialIndex + 1) % materials.Length;
        meshRenderer.material = materials[currentMaterialIndex];

        OutputText(currentMaterialIndex);
    }
}
