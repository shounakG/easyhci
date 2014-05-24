#using <System.dll>

namespace winAPI
{
	using namespace System;
	using namespace System::Diagnostics;
	using namespace System::ComponentModel;
    
	void taskmgr()
	{
		System::Diagnostics::Process::Start("taskmgr.exe");
	}

	void calc()
	{
			System::Diagnostics::Process::Start("calc.exe");
	}

	void cmdshell()
	{
			System::Diagnostics::Process::Start("cmd.exe");
	}

	void shutdown60()
	{
			System::Diagnostics::Process::Start("shutdown.exe","-s -t 60");
	}

	void notepad()
	{
		System::Diagnostics::Process::Start("notepad.exe");
	}

	void paint()
	{
		System::Diagnostics::Process::Start("mspaint.exe");
	}

	void browser()
	{
		System::Diagnostics::Process::Start("www.google.com");
	}

	void abortShutdown()
	{
		System::Diagnostics::Process::Start("shutdown.exe","-a");
	}
}