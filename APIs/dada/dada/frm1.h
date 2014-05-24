#pragma once

namespace dada {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Runtime::InteropServices;

	/// <summary>
	/// Summary for frm1
	/// </summary>
	public ref class frm1 : public System::Windows::Forms::Form
	{

	public: static char* sttr = "this is a form";
	public:
		frm1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~frm1()
		{
			if (components)
			{
				delete components;
			}
		}

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->SuspendLayout();
			// 
			// frm1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(284, 262);
			this->Name = L"frm1";
			this->Text = L"frm1";
			this->Load += gcnew System::EventHandler(this, &frm1::frm1_Load);
			this->ResumeLayout(false);
			//this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &frm1::frm1_Close);
			//this->Text->TextChanged += gcnew System::Windows::Forms::TextChanged(this, &frm1::frm1_TextChanged);
		}
#pragma endregion
	private: System::Void frm1_Load(System::Object^  sender, System::EventArgs^  e) {
				 printf("\n\n\nopen");
			 }

	public: System::Void frm1_Close(System::Object^  sender, System::Windows::Forms::FormClosedEventArgs^  e) {
				 printf("\n\n\n\n\nForm is closed");
			 }

	/*private: System::Void frm1_TextChanged(System::Object^  sender, EventArgs^  e) {
				 printf("textchanged");
			 }*/

	};
}
