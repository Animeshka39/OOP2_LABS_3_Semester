object Form2: TForm2
  Left = 0
  Top = 0
  BorderStyle = bsDialog
  Caption = 'Calculator'
  ClientHeight = 407
  ClientWidth = 271
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poDesktopCenter
  PixelsPerInch = 96
  TextHeight = 13
  object SpeedButton2: TSpeedButton
    Left = 32
    Top = 184
    Width = 50
    Height = 50
    Caption = '7'
    OnClick = SpeedButton4Click
  end
  object SpeedButton3: TSpeedButton
    Left = 32
    Top = 232
    Width = 50
    Height = 50
    Caption = '4'
    OnClick = SpeedButton4Click
  end
  object SpeedButton4: TSpeedButton
    Left = 32
    Top = 280
    Width = 50
    Height = 50
    Caption = '1'
    OnClick = SpeedButton4Click
  end
  object SpeedButton5: TSpeedButton
    Left = 32
    Top = 328
    Width = 50
    Height = 50
    Caption = '.'
    OnClick = SpeedButton5Click
  end
  object SpeedButton7: TSpeedButton
    Left = 80
    Top = 184
    Width = 50
    Height = 50
    Caption = '8'
    OnClick = SpeedButton4Click
  end
  object SpeedButton8: TSpeedButton
    Left = 80
    Top = 232
    Width = 50
    Height = 50
    Caption = '5'
    OnClick = SpeedButton4Click
  end
  object SpeedButton9: TSpeedButton
    Left = 80
    Top = 280
    Width = 50
    Height = 50
    Caption = '2'
    OnClick = SpeedButton4Click
  end
  object SpeedButton10: TSpeedButton
    Left = 80
    Top = 328
    Width = 50
    Height = 50
    Caption = '0'
    OnClick = SpeedButton4Click
  end
  object SpeedButton11: TSpeedButton
    Left = 32
    Top = 136
    Width = 146
    Height = 50
    Caption = 'C'
    OnClick = SpeedButton11Click
  end
  object SpeedButton12: TSpeedButton
    Left = 128
    Top = 184
    Width = 50
    Height = 50
    Caption = '9'
    OnClick = SpeedButton4Click
  end
  object SpeedButton13: TSpeedButton
    Left = 128
    Top = 232
    Width = 50
    Height = 50
    Caption = '6'
    OnClick = SpeedButton4Click
  end
  object SpeedButton14: TSpeedButton
    Left = 128
    Top = 280
    Width = 50
    Height = 50
    Caption = '3'
    OnClick = SpeedButton4Click
  end
  object SpeedButton16: TSpeedButton
    Left = 176
    Top = 136
    Width = 50
    Height = 50
    Caption = '/'
    OnClick = SpeedButton16Click
  end
  object SpeedButton17: TSpeedButton
    Left = 176
    Top = 184
    Width = 50
    Height = 50
    Caption = '*'
    OnClick = SpeedButton17Click
  end
  object SpeedButton18: TSpeedButton
    Left = 176
    Top = 232
    Width = 50
    Height = 50
    Caption = '-'
    OnClick = SpeedButton18Click
  end
  object SpeedButton19: TSpeedButton
    Left = 176
    Top = 280
    Width = 50
    Height = 50
    Caption = '+'
    OnClick = SpeedButton19Click
  end
  object SpeedButton20: TSpeedButton
    Left = 128
    Top = 328
    Width = 98
    Height = 50
    Caption = '='
    OnClick = SpeedButton20Click
  end
  object Label1: TLabel
    Left = 32
    Top = 48
    Width = 12
    Height = 20
    Caption = '0'
    Font.Charset = OEM_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Terminal'
    Font.Style = [fsBold]
    ParentFont = False
  end
end
