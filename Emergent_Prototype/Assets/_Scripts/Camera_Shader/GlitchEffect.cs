using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GlitchEffect : MonoBehaviour
{
    public Material EffectMaterial;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, EffectMaterial);
    }

    public IEnumerator Glitch1()
    {
        EffectMaterial.SetFloat("_Magnitude", 0.1f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.05f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.1f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.05f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0f);
    }

    public IEnumerator Glitch2()
    {
        EffectMaterial.SetFloat("_Magnitude", 0.1f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.02f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.03f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.04f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.05f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.06f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.07f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.08f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.09f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0.1f);
        yield return new WaitForSeconds(0.05f);
        EffectMaterial.SetFloat("_Magnitude", 0f);
    }
}
