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
	static Dictionary<string, int> gifInfo = new Dictionary<string, int> {
		{ "pacman", 11 }, 
	};
	public void load()
	{
		frames = new List<Texture2D>();
		colors = new List<Color[]>();
		speed = -4;
		spin = 0;
		currentIndex = 0;
	}

	public void LoadGIF(string gifName)
	{
		if (frames == null)
		{
			load();
		}
		if (gifName == null)
		{
			Debug.Log("Why is gifName null?");
			return;
		}

		if (!gifInfo.ContainsKey(gifName))
		{
			Debug.Log("Couldn't find " + gifName);
		}
		frames.Clear();
		colors.Clear();
		int frameCount = gifInfo[gifName];
		for (int i = 0; i < frameCount; ++i)
		{
			string imageName = gifName + "/" + gifName + "-" + i;
			Texture2D tex = LoadPNG(imageName);
			if (!tex)
			{
				Debug.Log("Couldn't load texture for " + imageName + "!");
				return;
			}
			frames.Add(tex);
			colors.Add(tex.GetPixels(0, 0, tex.width, tex.height));
				
		}
		Debug.Log("Loaded frames for " + gifName);
	}

	public static Texture2D LoadPNG(string filePath) {
		Texture2D tex = null;

		tex = Resources.Load(filePath) as Texture2D;
		if (tex == null)
		{
			Debug.Log(filePath + " not found!");
			return null;
		}
		return tex;
	}
	 
	// display is a collection of vect3 which are the colors of the 1500 pixels
	// points are the x,y,z locations of the points in a sphere with a radius slightly less than one.
	// display and points are each 1500 long and have the same index.

	public override void buildFrame(Color[] display,Vector3[] points)
	{
		if (frames == null || frames.Count == 0)
		{
			Debug.Log("Can't draw when you ain't got frames!");
			return;
		}
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