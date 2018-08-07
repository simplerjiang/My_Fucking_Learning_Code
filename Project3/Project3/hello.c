#include <windows.h>

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PSTR szCmdLine, int iCmdShow)
{

	MessageBox(NULL, TEXT("这是我第一个程序！"), TEXT("标题！"), MB_YESNO | MB_ICONINFORMATION | MB_DEFBUTTON2);
	
	return 0;

}