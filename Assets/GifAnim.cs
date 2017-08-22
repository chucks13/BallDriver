﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class GifAnim : FullBallEffect {
	List<Texture2D> frames = null;
	List<Color[]> colors = null;
	float spin;
	float speed;
	int currentIndex;

	public override void init()
	{
		frames = new List<Texture2D>();
		speed=(Random.Range(0,2)*8)-4;
		spin = 0;
		currentIndex = 0;
	}

	public void LoadGIF(string gifName)
	{
		if (frames == null)
		{
			init();
		}
		Dictionary<string, int> gifInfo = new Dictionary<string, int> {
			{ "pacman", 11 }, 
		};
		if (!gifInfo.ContainsKey(gifName))
		{
			Debug.Log("Couldn't find " + gifName);
		}
		frames.Clear();
		colors.Clear();
		int frameCount = gifInfo[gifName];
		for (int i = 0; i < frameCount; ++i)
		{
			string imageName = Application.dataPath + "/Resources/" + gifName + "/" + gifName + "-" + i + ".png";
			Texture2D tex = LoadPNG(imageName);
			frames.Add(tex);
			colors.Add(tex.GetPixels(0, 0, tex.width, tex.height);
				
		}
		Debug.Log("Loaded frames for " + gifName);
	}

	public static Texture2D LoadPNG(string filePath) {
		Texture2D tex = null;
		byte[] fileData;

		if (File.Exists(filePath))     {
			fileData = File.ReadAllBytes(filePath);
			tex = new Texture2D(2, 2);
			tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
		}
		return tex;
	}
	 
	// display is a collection of vect3 which are the colors of the 1500 pixels
	// points are the x,y,z locations of the points in a sphere with a radius slightly less than one.
	// display and points are each 1500 long and have the same index.

	public override void buildFrame(Color[] display,Vector3[] points)
	{
		Texture2D source = frames[currentIndex];
		Color[] pix = colors[currentIndex];
		currentIndex = (currentIndex + 1) % frames.Count;

		spin-=speed;
		spin+=360;
		spin%=360;

		for(int i=0;i<1500;i++)
		{
			float x=master.polar[i].x;
			float y=master.polar[i].y;
			x+=spin;
			x+=360;
			x%=360;
			x/=360f;
			y/=180f;
			y+=.5f;
			x=1f-x;
			x*=source.width;
			y*=source.height;
			int n=(int)y*source.width+(int)x;
			display[i]=pix[n];
		}
	}
}