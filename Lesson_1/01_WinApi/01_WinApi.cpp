// 01_WinApi.cpp : Defines the entry point for the application.
//

#include "stdafx.h"
#include "01_WinApi.h"

LRESULT CALLBACK WindowProcedure(HWND, UINT, WPARAM, LPARAM);

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
	wchar_t szNameOfApplication[] = L"�� ����� ������� ����";
	wchar_t szNameOfWindowClass[] = L"MyWindowClass";

	//////////////////////      I.   ������� ������� ����        ///////////////////////////
	WNDCLASSEX	wc;
	wc.cbSize = sizeof(WNDCLASSEX);					// ����� ��������� � ������
	wc.style = CS_VREDRAW | CS_HREDRAW;				// ����� ���� : ������ ��� ���� ����������������� ��� ��� ������ �� ���������� � ��������
	wc.lpfnWndProc = WindowProcedure;						// �������� �� ������ ���������
	wc.cbClsExtra = 0;									// �-�� ����, �� ������������ ����� �� ���������� �����
	wc.cbWndExtra = 0;									// �-�� ����, �� ������������ ����� �� ����������� ����
	wc.hInstance = hInstance;							// ����� �������, �� ������� ���� (���� �����)
	wc.hIcon = LoadIcon(NULL, IDI_QUESTION);			// ������� ������ ����
	wc.hIconSm = LoadIcon(NULL, IDI_WARNING);	// ������� ����� ������ ����
	wc.hCursor = LoadCursor(NULL, IDC_HAND);		// ������� ������ ������� ����
	wc.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);	// ������� ��� ����
															//wc.hbrBackground= (HBRUSH)GetStockObject( GRAY_BRUSH);	// ������� ��� ����
															//wc.hbrBackground= CreateSolidBrush( RGB( 255, 255, 0 ) ); 
															//wc.hbrBackground= CreateSolidBrush( RGB( 24, 77, 111 ) ); 
	wc.lpszMenuName = NULL;									// ������� ���� ����
	wc.lpszClassName = szNameOfWindowClass;					// ������� ��'� �������� �����


	if (!RegisterClassEx(&wc))
	{
		MessageBox(NULL, L"�� ������� ������������ ������� ����!", L"����!", MB_ICONERROR | MB_OK);
		return 0;
	}

	/////////////////////     III.   ��������� ���� �� ����� ���庺���������� �������� �����     /////////////////////
	HWND hWindow = CreateWindow(
		szNameOfWindowClass,						// ��'� �������� �����, �� ����� ����� �������� ����
		szNameOfApplication,						// ��'� ����
		WS_OVERLAPPEDWINDOW /*| WS_VSCROLL*/,		// ����� ����
		CW_USEDEFAULT,								// � ����� ��������� ���� ���� (CW_USEDEFAULT - ������������ �������� ������ )
		0,											// y ����� ��������� ���� ����
		CW_USEDEFAULT,								// ����� �� X ���� (CW_USEDEFAULT - ������������ �������� ������ )
		0,											// ����� �� Y ���� 
		NULL,										// ����� ������������ ����, ���� � �������� �������� ������ WS_CHILD ��� WS_CHILDWINDOW
		NULL,										// ����� ����
		hInstance,									// ����� ���������� ��������
		NULL										// lParam ��� ����������� WM_CREATE
	);

	/////////////////////     IV.   ³��������� ����      ///////////////////////////////////
	ShowWindow(hWindow, nCmdShow);

	MSG msg;	// ���������� ��������� �����������
	while (GetMessage(&msg, NULL, 0, 0))		// GetMessage() ������� ������ TRUE, ��� ���� ������� WM_QUIT
	{
		TranslateMessage(&msg);	// "���������" ����������� ��������� �������� �� ������� ���������
		DispatchMessage(&msg);	// ����� ����������� � ����� ����
	}
	return 0;


	int res = MessageBox(NULL, L"Hello", L"My msg box", MB_YESNOCANCEL | MB_ICONASTERISK);
	switch (res)
	{
	case IDYES:
	{
		MessageBox(NULL, L"Hello", L"You press yes", MB_YESNO | MB_ICONASTERISK);
		break;
	}
	default:
		break;
	}
}


LRESULT CALLBACK WindowProcedure
(HWND hWindow,	// ����� ����, ��� ������� ������� ������� (�����, ���� �� ���� ��������� ������� �������� ����?)
	UINT iMsg,		// ID �����������
	WPARAM wParam,	// �������� ���������� �����������
	LPARAM lParam	// �� ���� �������� ���������� �����������
)
{
	switch(iMsg)
	{
	case WM_KEYDOWN:
	{
		MessageBox(NULL, L"You press some button", L"bla-bla", MB_ICONERROR | MB_OK);
		break;
	}
	case WM_PAINT:		//  ����������� ������, ���� ������� ������������ ���� ����, ��� ���� �������
	{

		// 1. �������� �������� �������� ( hdc )
		PAINTSTRUCT ps;
		HDC hdc;
		RECT rectClient;
		COLORREF col = RGB(255, 100, 100);

		//// 2. ������� �� ���������� ���������
		//hdc = BeginPaint(hWindow, &ps);
		//HBRUSH hBrush;
		//hBrush = CreateHatchBrush(HS_FDIAGONAL, RGB(255, 0, 0));
		//SelectObject(hdc, hBrush);
		//Ellipse(hdc, 100, 100, 200, 300); //������ ����� �����������		
		//									//��������� ����		
		//ValidateRect(hWindow, NULL);
		const wchar_t * lpText = L"���-�-�-�! �\n ��� ������ � ���!!!";
		hdc = BeginPaint(hWindow, &ps);
		GetClientRect(hWindow, &rectClient);
		SetTextColor(hdc, col);
		DrawText(hdc, lpText, -1, &rectClient, DT_CENTER | DT_VCENTER /*| DT_SINGLELINE*/);	// ������� ����� � ������������ rcText (��� ��������� ����)
			// 3. ��������� �������� ��������
		EndPaint(hWindow, &ps);
		break;
	}
	case WM_LBUTTONDOWN:
	{
		MessageBox(NULL, L"You press mouse", L"bla-bla", MB_ICONERROR | MB_OK);
		break;
	}
	{
		MessageBox(NULL, L"You press some button", L"bla-bla", MB_ICONERROR | MB_OK);
		break;
	}
	case WM_DESTROY:	//  ����������� ���� ���� ��� �� �����, ����� ����������� ���'�� �������� ����
	//	MessageBox(NULL, L"������������ ����������� WM_DESTROY", L"WM_DESTROY", MB_ICONINFORMATION | MB_OK);
		PostQuitMessage(0);	// ���� �������� ���� ������ �������� �������� --- �������� PostQuitMessage() ��������� ����������� WM_QUIT
		break;
	}
	return DefWindowProc(hWindow, iMsg, wParam, lParam);	// ��� ���������� ��������� �������� � �����������, �� �� �������� �� !
}// LRESULT CALLBACK WindowProcedure( HWND, UINT, WPARAM, LPARAM )



