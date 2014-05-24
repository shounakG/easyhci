namespace dada {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Runtime::InteropServices;

	public ref class formevents : public System::Windows::Forms::Form
	{
		public: System::Void frmSURF_Close(System::Object^  sender, System::Windows::Forms::FormClosedEventArgs^  e) {
				 printf("\n\n\n\n\nForm is closed");
			 }
	};
}