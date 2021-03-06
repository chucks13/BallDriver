﻿using UnityEngine;
using System.Collections;
using System.IO;

public class pumpkin : FullBallEffect {
	Vector3 normal;
	Vector3 rot;
	Texture2D source;	
	float spin;
	float speed;
	float destx=0;
	float curx=0;

	public override void init()  // select the color
	{
		Texture2D[] images=master.imageList;
		source=images[6];
		speed=0;
		spin=0;
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
		if(master.specialMode>0)
			master.framecounter=10;
		Color[] pix = source.GetPixels(0, 0, source.width, source.height);
		curx+=((destx-curx)/20);
		spin=curx;
		spin+=360;
		spin%=360;
		if(((destx-curx)*(destx-curx))<10)
			destx=Random.Range(-30,30);

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
