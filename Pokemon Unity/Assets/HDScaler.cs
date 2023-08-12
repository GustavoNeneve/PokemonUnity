using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDScaler : MonoBehaviour {

	[Header("Scale Multiplier")]
    public float hdScaleMultiplier = 5;

	private GameObject DialogBox;
    private GUIText DialogBoxText;
    private GUIText DialogBoxTextShadow;
	private GUITexture DialogBoxTexture;
    private GUITexture DialogBoxBorder;
	 private DialogBoxHandler Dialog;
	 private GameObject ChoiceBox;
    private GUITexture ChoiceBoxTexture;
    private GUIText ChoiceBoxText;
    private GUIText ChoiceBoxTextShadow;
    private GUITexture ChoiceBoxSelect;
	 public int defaultChoiceWidth = 86;
    public int defaultChoiceY = 0;
    public int defaultDialogLines = 2;

    private GUITexture selectRow;
	private GUIText
        textSpeed,
        textSpeedShadow,
        textSpeedHighlight,
        musicVolume,
        musicVolumeShadow,
        musicVolumeHighlight,
        sfxVolume,
        sfxVolumeShadow,
        sfxVolumeHighlight,
        frameStyle,
        frameStyleShadow,
        battleScene,
        battleSceneShadow,
        battleSceneHighlight,
        battleStyle,
        battleStyleShadow,
        battleStyleHighlight,
        screenSize,
        screenSizeShadow,
        screenSizeHighlight,
        fullscreen,
        fullscreenShadow,
        fullscreenHighlight;

    private bool running;
    private int selectedOption;

	void Awake()
	{
		        Dialog = gameObject.GetComponent<DialogBoxHandler>();

        selectRow = transform.Find("selectRow").GetComponent<GUITexture>();
		DialogBox = gameObject.transform.Find("DialogBox").gameObject;
        //link the ChoiceBoxTexture variable to the Object's texture
        DialogBoxTexture = DialogBox.GetComponent<GUITexture>();
        //link the DialogBoxText variable to the Text Component
        DialogBoxText = DialogBox.transform.Find("BoxText").GetComponent<GUIText>();
        //link the DialogBoxTextShadow variable to the Text Component
        DialogBoxTextShadow = DialogBox.transform.Find("BoxTextShadow").GetComponent<GUIText>();
        //link the DialogBoxBorder variable to the Texture Component
        DialogBoxBorder = DialogBox.transform.Find("BoxBorder").GetComponent<GUITexture>();

        textSpeed = transform.Find("TextSpeed").GetComponent<GUIText>();
        textSpeedShadow = textSpeed.transform.Find("TextSpeedShadow").GetComponent<GUIText>();
        textSpeedHighlight = textSpeed.transform.Find("TextSpeedHighlight").GetComponent<GUIText>();
        musicVolume = transform.Find("MusicVolume").GetComponent<GUIText>();
        musicVolumeShadow = musicVolume.transform.Find("MusicVolumeShadow").GetComponent<GUIText>();
        musicVolumeHighlight = musicVolume.transform.Find("MusicVolumeHighlight").GetComponent<GUIText>();
        sfxVolume = transform.Find("SFXVolume").GetComponent<GUIText>();
        sfxVolumeShadow = sfxVolume.transform.Find("SFXVolumeShadow").GetComponent<GUIText>();
        sfxVolumeHighlight = sfxVolume.transform.Find("SFXVolumeHighlight").GetComponent<GUIText>();
        frameStyle = transform.Find("FrameStyle").GetComponent<GUIText>();
        frameStyleShadow = frameStyle.transform.Find("FrameStyleShadow").GetComponent<GUIText>();
        battleScene = transform.Find("BattleScene").GetComponent<GUIText>();
        battleSceneShadow = battleScene.transform.Find("BattleSceneShadow").GetComponent<GUIText>();
        battleSceneHighlight = battleScene.transform.Find("BattleSceneHighlight").GetComponent<GUIText>();
        battleStyle = transform.Find("BattleStyle").GetComponent<GUIText>();
        battleStyleShadow = battleStyle.transform.Find("BattleStyleShadow").GetComponent<GUIText>();
        battleStyleHighlight = battleStyle.transform.Find("BattleStyleHighlight").GetComponent<GUIText>();
        screenSize = transform.Find("ScreenSize").GetComponent<GUIText>();
        screenSizeShadow = screenSize.transform.Find("ScreenSizeShadow").GetComponent<GUIText>();
        screenSizeHighlight = screenSize.transform.Find("ScreenSizeHighlight").GetComponent<GUIText>();
        fullscreen = transform.Find("Fullscreen").GetComponent<GUIText>();
        fullscreenShadow = fullscreen.transform.Find("FullscreenShadow").GetComponent<GUIText>();
        fullscreenHighlight = fullscreen.transform.Find("FullscreenHighlight").GetComponent<GUIText>();

        DialogBox = transform.Find("Description").gameObject;
        DialogBoxText = DialogBox.transform.Find("DescriptionText").GetComponent<GUIText>();
        DialogBoxTextShadow = DialogBox.transform.Find("DescriptionTextShadow").GetComponent<GUIText>();
        DialogBoxBorder = DialogBox.transform.Find("DescriptionBorder").GetComponent<GUITexture>();

		//link the ChoiceBox variable to the Object
        ChoiceBox = gameObject.transform.Find("ChoiceBox").gameObject;
        //link the ChoiceBoxTexture variable to the Object's texture
        ChoiceBoxTexture = ChoiceBox.GetComponent<GUITexture>();
        //link the ChoiceBoxText variable to the Text Component
        ChoiceBoxText = ChoiceBox.transform.Find("BoxText").GetComponent<GUIText>();
        //link the ChoiceBoxTextShadow variable to the TextShadow Component
        ChoiceBoxTextShadow = ChoiceBox.transform.Find("BoxTextShadow").GetComponent<GUIText>();
        //link the ChoiceBoxSelect variable to the Texture Component
        ChoiceBoxSelect = ChoiceBox.transform.Find("BoxSelect").GetComponent<GUITexture>();
	}
	// Use this for initialization
	void Start () {
		
		boxTexture();
		boxTextSize();
		
	

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void boxTextSize()
	{
		selectRow.pixelInset.Set(selectRow.pixelInset.x * hdScaleMultiplier, selectRow.pixelInset.y * hdScaleMultiplier, selectRow.pixelInset.width * hdScaleMultiplier, selectRow.pixelInset.height * hdScaleMultiplier);
		textSpeed.pixelOffset.Set(textSpeed.pixelOffset.x * hdScaleMultiplier, textSpeed.pixelOffset.y * hdScaleMultiplier);
		textSpeedShadow.pixelOffset.Set(textSpeedShadow.pixelOffset.x * hdScaleMultiplier, textSpeedShadow.pixelOffset.y * hdScaleMultiplier);
		textSpeedHighlight.pixelOffset.Set(textSpeedHighlight.pixelOffset.x * hdScaleMultiplier, textSpeedHighlight.pixelOffset.y * hdScaleMultiplier);
		musicVolume.pixelOffset.Set(musicVolume.pixelOffset.x * hdScaleMultiplier, musicVolume.pixelOffset.y * hdScaleMultiplier);
		musicVolumeShadow.pixelOffset.Set(musicVolumeShadow.pixelOffset.x * hdScaleMultiplier, musicVolumeShadow.pixelOffset.y * hdScaleMultiplier);
		musicVolumeHighlight.pixelOffset.Set(musicVolumeHighlight.pixelOffset.x * hdScaleMultiplier, musicVolumeHighlight.pixelOffset.y * hdScaleMultiplier);
		sfxVolume.pixelOffset.Set(sfxVolume.pixelOffset.x * hdScaleMultiplier, sfxVolume.pixelOffset.y * hdScaleMultiplier);
		sfxVolumeShadow.pixelOffset.Set(sfxVolumeShadow.pixelOffset.x * hdScaleMultiplier, sfxVolumeShadow.pixelOffset.y * hdScaleMultiplier);
		sfxVolumeHighlight.pixelOffset.Set(sfxVolumeHighlight.pixelOffset.x * hdScaleMultiplier, sfxVolumeHighlight.pixelOffset.y * hdScaleMultiplier);
		frameStyle.pixelOffset.Set(frameStyle.pixelOffset.x * hdScaleMultiplier, frameStyle.pixelOffset.y * hdScaleMultiplier);
		frameStyleShadow.pixelOffset.Set(frameStyleShadow.pixelOffset.x * hdScaleMultiplier, frameStyleShadow.pixelOffset.y * hdScaleMultiplier);
		battleScene.pixelOffset.Set(battleScene.pixelOffset.x * hdScaleMultiplier, battleScene.pixelOffset.y * hdScaleMultiplier);
		battleSceneShadow.pixelOffset.Set(battleSceneShadow.pixelOffset.x * hdScaleMultiplier, battleSceneShadow.pixelOffset.y * hdScaleMultiplier);
		battleSceneHighlight.pixelOffset.Set(battleSceneHighlight.pixelOffset.x * hdScaleMultiplier, battleSceneHighlight.pixelOffset.y * hdScaleMultiplier);
		battleStyle.pixelOffset.Set(battleStyle.pixelOffset.x * hdScaleMultiplier, battleStyle.pixelOffset.y * hdScaleMultiplier);
		battleStyleShadow.pixelOffset.Set(battleStyleShadow.pixelOffset.x * hdScaleMultiplier, battleStyleShadow.pixelOffset.y * hdScaleMultiplier);
		battleStyleHighlight.pixelOffset.Set(battleStyleHighlight.pixelOffset.x * hdScaleMultiplier, battleStyleHighlight.pixelOffset.y * hdScaleMultiplier);
		screenSize.pixelOffset.Set(screenSize.pixelOffset.x * hdScaleMultiplier, screenSize.pixelOffset.y * hdScaleMultiplier);
		screenSizeShadow.pixelOffset.Set(screenSizeShadow.pixelOffset.x * hdScaleMultiplier, screenSizeShadow.pixelOffset.y * hdScaleMultiplier);
		screenSizeHighlight.pixelOffset.Set(screenSizeHighlight.pixelOffset.x * hdScaleMultiplier, screenSizeHighlight.pixelOffset.y * hdScaleMultiplier);
		fullscreen.pixelOffset.Set(fullscreen.pixelOffset.x * hdScaleMultiplier, fullscreen.pixelOffset.y * hdScaleMultiplier);
		fullscreenShadow.pixelOffset.Set(fullscreenShadow.pixelOffset.x * hdScaleMultiplier, fullscreenShadow.pixelOffset.y * hdScaleMultiplier);
		fullscreenHighlight.pixelOffset.Set(fullscreenHighlight.pixelOffset.x * hdScaleMultiplier, fullscreenHighlight.pixelOffset.y * hdScaleMultiplier);

		
	}
	void boxTexture()
	{
		int lines = -1;
      
	}
		
			
}
