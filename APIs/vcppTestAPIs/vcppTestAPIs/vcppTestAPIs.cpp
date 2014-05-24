// vcppTestAPIs.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <Windows.h>
#using "SwitchWindows.dll"

using namespace SwitchWindows;
using namespace std;
using namespace AllExplorerWindowOperations;
using namespace System;
using namespace MiscellaniousAPI;

int _tmain(int argc, _TCHAR* argv[])
{
	/*int switchProc;

	switchwin^ nwin = gcnew switchwin();
	nwin->procArray = nwin->getAllWindowNames();
	
	for(int i=0 ; i< nwin->proNum ; i++)
		printf("%d. %s\n",i+1,nwin->procArray[i].prName);

	for(int i=0;; i++)
	{
		if(i==nwin->proNum-1) 
			i=0;
		nwin->switchWindow(i);
		printf("Continue?");
		scanf("%d",&switchProc);
		if(switchProc==0)
			break;
	}*/

	clsMisc^ nmisc = gcnew clsMisc();
	IntPtr hwnd(FindWindow(NULL,TEXT("Calculator")));
	nmisc->muteUnmute(hwnd);
	
	getchar();
	return 0;
}

