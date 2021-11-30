using System.Collections;
using System.IO;
using UnityEditor;
using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEditor.Recorder;
using UnityEditor.Recorder.Input;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.SceneManagement;

namespace E7.AhLcgMiniDivider
{
    internal class Runner : MonoBehaviour
    {
        [SerializeField] private Applier applier;
        [SerializeField] private Locale[] locales;
        [SerializeField] private PdfSpec[] specs;

        private void Awake()
        {
            StartCoroutine(CaptureRoutine());
        }

        IEnumerator CaptureRoutine()
        {
            var controllerSettings = ScriptableObject.CreateInstance<RecorderControllerSettings>();
            var imageRecorder = ScriptableObject.CreateInstance<ImageRecorderSettings>();
            imageRecorder.name = "Divider Recorder";
            imageRecorder.Enabled = true;
            imageRecorder.OutputFormat = ImageRecorderSettings.ImageRecorderOutputFormat.PNG;
            imageRecorder.imageInputSettings = new GameViewInputSettings {OutputWidth = 1098, OutputHeight = 804};
            controllerSettings.AddRecorderSettings(imageRecorder);
            controllerSettings.FrameRate = 30;
            controllerSettings.SetRecordModeToManual();
            var recorderController = new RecorderController(controllerSettings);
            recorderController.PrepareRecording();

            for (var i = 0; i < 3; i++)
            {
                yield return null;
            }

            var dividersFolder = Path.Combine(Application.dataPath, "..", "..", "..", "Dividers");
            Directory.CreateDirectory(dividersFolder);
            Directory.Delete(dividersFolder, true);

            recorderController.StartRecording();
            foreach (var l in locales)
            {
                LocalizationSettings.SelectedLocale = l;
                foreach (var v in specs)
                {
                    for (var i = 0; i < v.genSpecs.Length; i++)
                    {
                        var s = v.genSpecs[i];

                        var fullDestinationFolder = Path.Combine(dividersFolder,
                            l.Identifier.Code,
                            v.pdfName + " x" + v.genSpecs.Length);
                        Directory.CreateDirectory(fullDestinationFolder);
                        var fileName = string.Join("_", l.Identifier.Code, v.pdfName, (i + 1).ToString("00"), s.name);
                        imageRecorder.FileNameGenerator.Root = OutputPath.Root.Absolute;
                        imageRecorder.FileNameGenerator.Leaf = fullDestinationFolder;
                        imageRecorder.FileNameGenerator.FileName = fileName;
                        applier.Gen(s);
                        yield return null;
                    }
                }
            }

            recorderController.StopRecording();
            EditorApplication.ExitPlaymode();
        }
    }
}