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
	wchar_t szNameOfApplication[] = L"Моє перше справжнє вікно";
	wchar_t szNameOfWindowClass[] = L"MyWindowClass";

	//////////////////////      I.   описуємо віконний клас        ///////////////////////////
	WNDCLASSEX	wc;
	wc.cbSize = sizeof(WNDCLASSEX);					// розмір структури у байтах
	wc.style = CS_VREDRAW | CS_HREDRAW;				// стиль вікна : хочемо щоб вікно перемальовувалося при зміні розмірів по горизонталі і вертикалі
	wc.lpfnWndProc = WindowProcedure;						// вказівник на віконну процедуру
	wc.cbClsExtra = 0;									// к-ть байт, що резервуються слідом за структурою класу
	wc.cbWndExtra = 0;									// к-ть байт, що резервуються слідом за екземпляном вікна
	wc.hInstance = hInstance;							// хендл додатку, що створив вікно (нашої проги)
	wc.hIcon = LoadIcon(NULL, IDI_QUESTION);			// визначає значок вікна
	wc.hIconSm = LoadIcon(NULL, IDI_WARNING);	// визначає малий значок вікна
	wc.hCursor = LoadCursor(NULL, IDC_HAND);		// визначає вигляд курсора миші
	wc.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);	// визначає тло вікна
															//wc.hbrBackground= (HBRUSH)GetStockObject( GRAY_BRUSH);	// визначає тло вікна
															//wc.hbrBackground= CreateSolidBrush( RGB( 255, 255, 0 ) ); 
															//wc.hbrBackground= CreateSolidBrush( RGB( 24, 77, 111 ) ); 
	wc.lpszMenuName = NULL;									// визначає меню вікна
	wc.lpszClassName = szNameOfWindowClass;					// визначає ім'я віконного класу


	if (!RegisterClassEx(&wc))
	{
		MessageBox(NULL, L"Не вдалося зареєструвати віконний клас!", L"Хана!", MB_ICONERROR | MB_OK);
		return 0;
	}

	/////////////////////     III.   Створюємо вікно на основі зареєєстрованого віконного класу     /////////////////////
	HWND hWindow = CreateWindow(
		szNameOfWindowClass,						// ім'я віконного класу, на основі якого створити вікно
		szNameOfApplication,						// Ім'я вікна
		WS_OVERLAPPEDWINDOW /*| WS_VSCROLL*/,		// стиль вікна
		CW_USEDEFAULT,								// х лівого верхнього кута вікна (CW_USEDEFAULT - визначаються системою обидва )
		0,											// y лівого верхнього кута вікна
		CW_USEDEFAULT,								// розмір по X вікна (CW_USEDEFAULT - визначаються системою обидва )
		0,											// розмір по Y вікна 
		NULL,										// хендл батьківського вікна, якщо в третьому параметрі вказно WS_CHILD або WS_CHILDWINDOW
		NULL,										// хендл меню
		hInstance,									// хендл екземпляра програми
		NULL										// lParam для повідомлення WM_CREATE
	);

	/////////////////////     IV.   Відображаємо вікно      ///////////////////////////////////
	ShowWindow(hWindow, nCmdShow);

	MSG msg;	// ексземпляр структури повідомлення
	while (GetMessage(&msg, NULL, 0, 0))		// GetMessage() повертає завжди TRUE, крім коли зловить WM_QUIT
	{
		TranslateMessage(&msg);	// "перекладає" повідомлення клавіатури відповідно до поточної розкладки
		DispatchMessage(&msg);	// кладе повідомлення у чергу вікна
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
(HWND hWindow,	// хендл вікна, для котрого надійшла мессага (тобто, одна ВП може обробляти мессаги декількох вікон?)
	UINT iMsg,		// ID повідомлення
	WPARAM wParam,	// параметр одержаного повідомлення
	LPARAM lParam	// ще один параметр одержаного повідомлення
)
{
	switch(iMsg)
	{
	case WM_KEYDOWN:
	{
		MessageBox(NULL, L"You press some button", L"bla-bla", MB_ICONERROR | MB_OK);
		break;
	}
	case WM_PAINT:		//  надсилається щоразу, коли потрібно перемалювати ціле вікно, або його частину
	{

		// 1. отримуємо контекст пристрою ( hdc )
		PAINTSTRUCT ps;
		HDC hdc;
		RECT rectClient;
		COLORREF col = RGB(255, 100, 100);

		//// 2. Малюємо по отриманому контексту
		//hdc = BeginPaint(hWindow, &ps);
		//HBRUSH hBrush;
		//hBrush = CreateHatchBrush(HS_FDIAGONAL, RGB(255, 0, 0));
		//SelectObject(hdc, hBrush);
		//Ellipse(hdc, 100, 100, 200, 300); //эллипс будет заштрихован		
		//									//обновляем окно		
		//ValidateRect(hWindow, NULL);
		const wchar_t * lpText = L"Уря-а-а-а! Я\n вмію писати у вікні!!!";
		hdc = BeginPaint(hWindow, &ps);
		GetClientRect(hWindow, &rectClient);
		SetTextColor(hdc, col);
		DrawText(hdc, lpText, -1, &rectClient, DT_CENTER | DT_VCENTER /*| DT_SINGLELINE*/);	// малюємо текст у прямокутнику rcText (уже посередині вікна)
			// 3. звільняємо контекст пристрою
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
	case WM_DESTROY:	//  надсилається коли вікна уже не видно, перед вивільненням пам'яті струтури вікна
	//	MessageBox(NULL, L"Обробляється повідомлення WM_DESTROY", L"WM_DESTROY", MB_ICONINFORMATION | MB_OK);
		PostQuitMessage(0);	// якщо закриття вікна означає закриття програми --- викликом PostQuitMessage() надсилаємо повідомлення WM_QUIT
		break;
	}
	return DefWindowProc(hWindow, iMsg, wParam, lParam);	// хай стандартна процедура обробить ті повідомлення, які не обробили ми !
}// LRESULT CALLBACK WindowProcedure( HWND, UINT, WPARAM, LPARAM )



