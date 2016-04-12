using UnityEngine;

namespace Test
{
    [ExecuteInEditMode]
    public class SimpleImageEffect : MonoBehaviour
    {
        #region Exposed properties

        [SerializeField]
        Shader _shader;

        #endregion

        #region Private objects

        Material _material;

        #endregion

        #region MonoBehaviour functions

        void OnEnable()
        {
            var shader = Shader.Find("Hidden/Test/SimpleImageEffect");
            _material = new Material(shader);
            _material.hideFlags = HideFlags.DontSave;
        }

        void OnDisable()
        {
            DestroyImmediate(_material);
            _material = null;
        }

        void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            Graphics.Blit(source, destination, _material, 0);
        }

        #endregion
    }
}
