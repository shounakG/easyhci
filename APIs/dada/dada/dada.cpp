// dada.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "frm1.h"
#include "formevents.h"
#using "G:\SURF\SurfDLL\SurfDLL\bin\Debug\SurfDLL.dll"

using namespace SurfDLL;
using namespace dada;
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	//frmSURF ^surf = gcnew frmSURF("E:/camshift/cam1.jpg");
	int px, py;
	frmSURF ^form = gcnew frmSURF("E:/camshift/cam1.jpg");
	//printf((const char*) (Marshal::StringToHGlobalAnsi(form->Text)).ToPointer());

	form->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(form, &frmSURF::getPoints);
	Application::Run(form);
	px = form->arrImgPoints[0];
	py = form->arrImgPoints[1];
	if(px == -1 && py == -1)
	{
		printf("object has been lost completely");
	}
	else
	{
		printf("%d\t%d",px,py);
	}
	getchar();
}

