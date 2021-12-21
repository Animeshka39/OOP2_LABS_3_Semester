//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Calculator.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm2 *Form2;
int a,b,c,d=0,e;
//---------------------------------------------------------------------------
__fastcall TForm2::TForm2(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm2::SpeedButton4Click(TObject *Sender)
{
if(Label1->Caption == "0")
{
 Label1->Caption = (( TSpeedButton*)Sender)->Caption;
}
 else
 {
  Label1->Caption = Label1->Caption + (( TSpeedButton*)Sender)->Caption;
}
}
//---------------------------------------------------------------------------
void __fastcall TForm2::SpeedButton19Click(TObject *Sender)
{
	d=1;
	a= Label1->Caption.ToInt();
    Label1->Caption = "";
}
//---------------------------------------------------------------------------
void __fastcall TForm2::SpeedButton20Click(TObject *Sender)
{
 b = Label1->Caption.ToInt();
 switch(d)
 {
	 case 1: c= a+b; break;
	 case 2: c= a-b; break;
	 case 3: c= a*b; break;
	 case 4: c= a/b; break;
 }
 Label1->Caption = c;
}
//---------------------------------------------------------------------------
void __fastcall TForm2::SpeedButton11Click(TObject *Sender)
{
    Label1->Caption = "0";
}
//---------------------------------------------------------------------------
void __fastcall TForm2::SpeedButton18Click(TObject *Sender)
{
    d=2;
	a = Label1->Caption.ToInt();
	Label1->Caption = "";
}
//---------------------------------------------------------------------------
void __fastcall TForm2::SpeedButton17Click(TObject *Sender)
{
d=3;
	a= Label1->Caption.ToInt();
	Label1->Caption = "";
}
//---------------------------------------------------------------------------
void __fastcall TForm2::SpeedButton16Click(TObject *Sender)
{
d=4;
	a= Label1->Caption.ToInt();
	Label1->Caption = "";
}
//---------------------------------------------------------------------------

void __fastcall TForm2::SpeedButton5Click(TObject *Sender)
{
	Label1->AddDecimalSeparator();
}
//---------------------------------------------------------------------------

