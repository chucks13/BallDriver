﻿using UnityEngine;
using System.Collections;
using System.IO;

public class model : MonoBehaviour {
	static float[] vertexs=new float[]
	{
	14.28001f,0.5161915f,5.773503f,
	17.84823f,-5.257311f,3.568221f,
	13.76382f,-5.257311f,8.506508f,
	14.28001f,0.5161915f,5.773503f,
	17.84823f,-5.257311f,3.568221f,
	17.01302f,0f,0f,
	14.28001f,0.5161915f,5.773503f,
	12.07473f,4.084413f,-2.227476E-16f,
	17.01302f,0f,0f,
	17.01302f,0f,0f,
	12.07473f,4.084413f,-2.227476E-16f,
	14.28001f,0.5161915f,-5.773503f,
	12.07473f,4.084413f,-2.227476E-16f,
	8.506508f,3.249197f,-5.257311f,
	14.28001f,0.5161915f,-5.773503f,
	14.28001f,0.5161915f,-5.773503f,
	8.506508f,-1.68909f,-9.341723f,
	8.506508f,3.249197f,-5.257311f,
	8.506508f,3.249197f,-5.257311f,
	2.733005f,0.5161915f,-5.773503f,
	8.506508f,-1.68909f,-9.341723f,
	8.506508f,-1.68909f,-9.341723f,
	2.733005f,0.5161915f,-5.773503f,
	3.249197f,-5.257311f,-8.506508f,
	14.28001f,0.5161915f,5.773503f,
	8.506508f,3.249197f,5.257311f,
	12.07473f,4.084413f,-2.227476E-16f,
	8.506508f,3.249197f,5.257311f,
	12.07473f,4.084413f,-2.227476E-16f,
	4.938287f,4.084413f,-4.445395E-16f,
	12.07473f,4.084413f,-2.227476E-16f,
	4.938287f,4.084413f,-4.445395E-16f,
	8.506508f,3.249197f,-5.257311f,
	4.938287f,4.084413f,-4.445395E-16f,
	2.733005f,0.5161915f,-5.773503f,
	8.506508f,3.249197f,-5.257311f,
	14.28001f,0.5161915f,5.773503f,
	13.76382f,-5.257311f,8.506508f,
	8.506508f,-1.68909f,9.341723f,
	14.28001f,0.5161915f,5.773503f,
	8.506508f,-1.68909f,9.341723f,
	8.506508f,3.249197f,5.257311f,
	8.506508f,3.249197f,5.257311f,
	8.506508f,-1.68909f,9.341723f,
	2.733005f,0.5161915f,5.773503f,
	2.733005f,0.5161915f,5.773503f,
	4.938287f,4.084413f,-4.445395E-16f,
	8.506508f,3.249197f,5.257311f,
	2.733005f,0.5161915f,5.773503f,
	0f,0f,0f,
	4.938287f,4.084413f,-4.445395E-16f,
	0f,0f,0f,
	2.733005f,0.5161915f,-5.773503f,
	4.938287f,4.084413f,-4.445395E-16f,
	2.733005f,0.5161915f,-5.773503f,
	0f,0f,0f,
	-0.8352155f,-5.257311f,-3.568221f,
	2.733005f,0.5161915f,-5.773503f,
	-0.8352155f,-5.257311f,-3.568221f,
	3.249197f,-5.257311f,-8.506508f,
	8.506508f,-1.68909f,9.341723f,
	3.249197f,-5.257311f,8.506508f,
	2.733005f,0.5161915f,5.773503f,
	2.733005f,0.5161915f,5.773503f,
	3.249197f,-5.257311f,8.506508f,
	-0.8352155f,-5.257311f,3.568221f,
	2.733005f,0.5161915f,5.773503f,
	-0.8352155f,-5.257311f,3.568221f,
	0f,0f,0f,
	0f,0f,0f,
	-0.8352155f,-5.257311f,3.568221f,
	-0.8352155f,-5.257311f,-3.568221f,
	13.76382f,-5.257311f,8.506508f,
	8.506508f,-1.68909f,9.341723f,
	8.506508f,-8.825532f,9.341723f,
	8.506508f,-8.825532f,9.341723f,
	3.249197f,-5.257311f,8.506508f,
	8.506508f,-1.68909f,9.341723f,
	8.506508f,-8.825532f,9.341723f,
	3.249197f,-5.257311f,8.506508f,
	2.733005f,-11.03081f,5.773503f,
	-0.8352155f,-5.257311f,3.568221f,
	3.249197f,-5.257311f,8.506508f,
	2.733005f,-11.03081f,5.773503f,
	-0.8352155f,-5.257311f,3.568221f,
	0f,-10.51462f,0f,
	2.733005f,-11.03081f,5.773503f,
	-0.8352155f,-5.257311f,-3.568221f,
	0f,-10.51462f,0f,
	-0.8352155f,-5.257311f,3.568221f,
	-0.8352155f,-5.257311f,-3.568221f,
	2.733005f,-11.03081f,-5.773503f,
	0f,-10.51462f,0f,
	-0.8352155f,-5.257311f,-3.568221f,
	2.733005f,-11.03081f,-5.773503f,
	3.249197f,-5.257311f,-8.506508f,
	8.506508f,-13.76382f,5.257311f,
	8.506508f,-8.825532f,9.341723f,
	2.733005f,-11.03081f,5.773503f,
	2.733005f,-11.03081f,5.773503f,
	4.938287f,-14.59903f,-2.227476E-16f,
	8.506508f,-13.76382f,5.257311f,
	2.733005f,-11.03081f,5.773503f,
	0f,-10.51462f,0f,
	4.938287f,-14.59903f,-2.227476E-16f,
	0f,-10.51462f,0f,
	2.733005f,-11.03081f,-5.773503f,
	4.938287f,-14.59903f,-2.227476E-16f,
	14.28001f,-11.03081f,5.773503f,
	8.506508f,-8.825532f,9.341723f,
	13.76382f,-5.257311f,8.506508f,
	14.28001f,-11.03081f,5.773503f,
	8.506508f,-13.76382f,5.257311f,
	8.506508f,-8.825532f,9.341723f,
	14.28001f,-11.03081f,5.773503f,
	12.07473f,-14.59903f,-8.881233E-16f,
	8.506508f,-13.76382f,5.257311f,
	8.506508f,-13.76382f,5.257311f,
	4.938287f,-14.59903f,-2.227476E-16f,
	12.07473f,-14.59903f,-8.881233E-16f,
	4.938287f,-14.59903f,-2.227476E-16f,
	8.506508f,-13.76382f,-5.257311f,
	12.07473f,-14.59903f,-8.881233E-16f,
	4.938287f,-14.59903f,-2.227476E-16f,
	8.506508f,-13.76382f,-5.257311f,
	2.733005f,-11.03081f,-5.773503f,
	8.506508f,-13.76382f,-5.257311f,
	2.733005f,-11.03081f,-5.773503f,
	8.506508f,-8.825532f,-9.341723f,
	8.506508f,-8.825532f,-9.341723f,
	3.249197f,-5.257311f,-8.506508f,
	2.733005f,-11.03081f,-5.773503f,
	14.28001f,-11.03081f,5.773503f,
	17.01302f,-10.51462f,0f,
	12.07473f,-14.59903f,-8.881233E-16f,
	17.01302f,-10.51462f,0f,
	12.07473f,-14.59903f,-8.881233E-16f,
	14.28001f,-11.03081f,-5.773503f,
	12.07473f,-14.59903f,-8.881233E-16f,
	14.28001f,-11.03081f,-5.773503f,
	8.506508f,-13.76382f,-5.257311f,
	14.28001f,-11.03081f,-5.773503f,
	8.506508f,-8.825532f,-9.341723f,
	8.506508f,-13.76382f,-5.257311f,
	17.84823f,-5.257311f,3.568221f,
	14.28001f,-11.03081f,5.773503f,
	13.76382f,-5.257311f,8.506508f,
	17.84823f,-5.257311f,3.568221f,
	14.28001f,-11.03081f,5.773503f,
	17.01302f,-10.51462f,0f,
	17.84823f,-5.257311f,-3.568221f,
	17.84823f,-5.257311f,3.568221f,
	17.01302f,-10.51462f,0f,
	17.84823f,-5.257311f,-3.568221f,
	14.28001f,-11.03081f,-5.773503f,
	17.01302f,-10.51462f,0f,
	17.84823f,-5.257311f,-3.568221f,
	14.28001f,-11.03081f,-5.773503f,
	13.76382f,-5.257311f,-8.506508f,
	14.28001f,-11.03081f,-5.773503f,
	13.76382f,-5.257311f,-8.506508f,
	8.506508f,-8.825532f,-9.341723f,
	13.76382f,-5.257311f,-8.506508f,
	8.506508f,-1.68909f,-9.341723f,
	8.506508f,-8.825532f,-9.341723f,
	8.506508f,-1.68909f,-9.341723f,
	3.249197f,-5.257311f,-8.506508f,
	8.506508f,-8.825532f,-9.341723f,
	17.01302f,0f,0f,
	17.84823f,-5.257311f,3.568221f,
	17.84823f,-5.257311f,-3.568221f,
	14.28001f,0.5161915f,-5.773503f,
	17.01302f,0f,0f,
	17.84823f,-5.257311f,-3.568221f,
	14.28001f,0.5161915f,-5.773503f,
	13.76382f,-5.257311f,-8.506508f,
	17.84823f,-5.257311f,-3.568221f,
	14.28001f,0.5161915f,-5.773503f,
	13.76382f,-5.257311f,-8.506508f,
	8.506508f,-1.68909f,-9.341723f,
	};

	public bool render;
	public float pixelsize=1.0f;

	void centerModel()
	{
		Vector3 center=new Vector3(0f,0f,0f);
		int i;
		for(i=0;i<vertexs.Length;i+=3)
			center+=new Vector3(vertexs[i+0],vertexs[i+1],vertexs[i+2]);
		center/=(float)(vertexs.Length/3);
		for(i=0;i<vertexs.Length;i+=3)
		{
			vertexs[i+0]-=center.x;
			vertexs[i+1]-=center.y;
			vertexs[i+2]-=center.z;
		}
	}

	public Vector3 getPoint(int n)
	{
		n*=3;
		Vector3 p=new Vector3(vertexs[n+0],vertexs[n+2],vertexs[n+1]);	// y and z swapped
		Quaternion rotation = Quaternion.Euler(0f,0f,31.7f);
		p=rotation*p;
		p*=0.1f;
		return p;
	} 		


	public Vector3 getCenter(Vector3 a,Vector3 b,Vector3 c)
	{
		return new Vector3((a.x+b.x+c.x)/3f,(a.y+b.y+c.y)/3f,(a.z+b.z+c.z)/3f);
	}
	public Vector3 getAverage(int n)
	{
		n*=3;
		return getCenter(getPoint(n+0),getPoint(n+1),getPoint(n+2));
	}
	public float lengthSquared(Vector3 a,Vector3 b)
	{
		float d1=a.x-b.x;
		float d2=a.y-b.y;
		float d3=a.z-b.z;
		return (d1*d1)+(d2*d2)+(d3*d3);
	}

	public GameObject pixelTemplate;
	public GameObject pipeTemplate;
	void OnGUI()
	{
		render=GUI.Toggle(new Rect(0,Screen.height-100,80,20),render,"render");
		if(GUI.Button(new Rect(Screen.width-20,0,20,20),""))
			Application.Quit();
	}

	public void Update()
	{
		if(render)
		{
			for(int panel=0;panel<60;panel++)
			{
				for(int pixel=0;pixel<25;pixel++)
				{
					int i=panel*25+pixel;
					LEDs[i].GetComponent<Renderer>().material.color=colors[i+showframe];
				}
			}
		}
	}

	public GameObject[] LEDs;
	public Vector3[] points;
	private Color[] colors;
	public Vector2[] polar=new Vector2[1500];
	int loadframe=0;
	int showframe=0;

	// Use this for initialization
	void Start () {
		int i;
		centerModel();
		LEDs=new GameObject[60*25];
		colors=new Color[60*25*2];
		points=new Vector3[60*25];
		/*
		// origin
		cube=(GameObject)GameObject.Instantiate(template);
		cube.transform.position=new Vector3(0f,0f,0f);
		cube.transform.localScale=new Vector3(0.1f,0.1f,0.1f);
		cube.GetComponent<Renderer>().material.color=new Color(0f,0f,1f);

		// reference
		cube=(GameObject)GameObject.Instantiate(template);
		cube.transform.position=new Vector3(2f,0f,0f);
		cube.transform.localScale=new Vector3(0.1f,0.1f,0.1f);
		cube.GetComponent<Renderer>().material.color=new Color(1f,1f,1f);
		*/
		for(i=0;i<60;i++)
			makePanel(i);
//		findNeighbors();
	
	}

	bool normalOut(Vector3 a,Vector3 b, Vector3 c)
	{
		float normal=(Vector3.Cross(b-a,c-a)+a).magnitude;
		float radius=a.magnitude;
		return normal>radius;
	}

	void findNeighbors()
	{
		string s="";
		string line="";
		for(int i=0;i<1500;i++)
		{
			if((i%25)==0)
			{
				line+=s+"\n";
				s="";
			}
			int n=0;
			int[] which=new int[3];
			Vector3 pa=points[i];
			for(int j=0;j<1500;j++)
			{
				if(j==i)
					continue;
				Vector3 pb=points[j];
				float len=(pa-pb).magnitude;
				if(len<0.09f)
					which[n++]=j;
			}
			if(n!=3)
				print("warning "+n+"/n");
			// get them in the right order
			if(!normalOut(points[which[0]],points[which[1]],points[which[2]]))
			{
				int x=which[1];
				which[1]=which[2];
				which[2]=x;
			}
			s+=which[0]+","+which[1]+","+which[2]+",";
		}
		line+=s+"\n";
		print(line);
	}



	private int[] gridoffsets=new int[]
	{
		0,0,
		5,8,0,5,-5,8,
		-10,16,-5,13,0,16,5,13,10,16,
		15,24,10,21,5,24,0,21,-5,24,-10,21,-15,24,
		-20,32,-15,29,-10,32,-5,29,0,32,5,29,10,32,15,29,20,32
	};


	void makeline(Vector3 a,Vector3 b,Color c)
	{
//		if(render)
		{
			GameObject tube;
			tube=(GameObject)GameObject.Instantiate(pipeTemplate);
			tube.transform.position=(a+b)/2f;
			tube.transform.localScale=new Vector3(0.015f,Vector3.Magnitude(a-b)/2f,.015f);//);
			tube.transform.LookAt(a);
			tube.transform.Rotate(new Vector3(90f,0f,0f));
			tube.GetComponent<Renderer>().material.color=c;
		}
	}

	void  makePanel(int i)
	{
		GameObject cube;
		int j;
		int triangleidx=i*3;
		float la,lb,lc;
		Vector3 a=getPoint(triangleidx+0);
		Vector3 b=getPoint(triangleidx+1);
		Vector3 c=getPoint(triangleidx+2);
		Vector3 d=getCenter(a,b,c);
		la=lengthSquared(a,d);
		lb=lengthSquared(b,d);
		lc=lengthSquared(c,d);
		float avl=(la+lb+lc)/3f;	// average length
		// make sure a is shortest
		if(lb<avl)
		{
			Vector3 e=a;
			a=b;
			b=e;
		}
		if(lc<avl)
		{
			Vector3 e=a;
			a=c;
			c=e;
		}
		// get proper winding
		Vector3 normal=Vector3.Cross(b-a,c-a);
		normal+=a;
		if(a.magnitude<normal.magnitude)
		{
			Vector3 e=b;
			b=c;
			c=e;
		}
		// draw pipes
		makeline(a,b,new Color(0f,0f,0f));
		makeline(c,b,new Color(0f,0f,0f));
		makeline(a,c,new Color(0f,0f,0f));
		// draw dots
		la=lengthSquared(a,d);
		lb=lengthSquared(b,d);
		lc=lengthSquared(c,d);
		Vector3 center=(b+c)/2f;
		Vector3 away=center-a;
		Vector3 right=b-center;

		float size=0.025f;
		size *= pixelsize;

		for(j=0;j<50;j+=2)
		{
			float x=((float)(gridoffsets[j+0]))/25f;
			float y=((float)(gridoffsets[j+1]+5))/40f;
			Vector3 pix=(away*y)+(right*x)+a;
//			if(render)
			{
				cube=(GameObject)GameObject.Instantiate(pixelTemplate);
				cube.transform.position=pix;
				cube.transform.localScale=new Vector3(size,size,size/2f);
				cube.transform.LookAt(new Vector3(0f,0f,0f));
				cube.GetComponent<Renderer>().material.color=new Color(1f,0f,1f);
				LEDs[(i*25)+(j/2)]=cube;
			}
			points[(i*25)+(j/2)]=pix;
			float scale=180f/Mathf.PI;
			polar[(i*25)+(j/2)]=new Vector2(Mathf.Atan2(pix.x,pix.z)*scale,Mathf.Atan2(pix.y,Vector3.Magnitude(new Vector3(pix.x,0f,pix.z)))*scale);
		}
	}

	void colorport(int port,byte[]data)
	{
		int x,y;
		int z=0;
		for(x=0;x<4;x++)
		{
			int panel=port*4+x;
			for(y=0;y<25;y++)
			{
				Color c=new Color((float)data[z+4]/254f,(float)data[z+5]/254f,(float)data[z+6]/254f);
				colors[(panel*25)+y+loadframe]=c;
				z+=3;
			}
		}
	}


	public void recieve(byte[]data)
	{
		int j;
		if(data[3]==129)// latch
		{ 
			showframe=loadframe;
			loadframe=1500-loadframe;
		}
		if(data[3]==0)// data
		{
			if(data[2]==255)		// broadcast
			{
				for(j=0;j<15;j++)
					colorport(j,data);
				return;
			}
			int panel=data[2];
			if(panel<15)
			{
				colorport(panel,data);
			}
		}
		
	}
}
