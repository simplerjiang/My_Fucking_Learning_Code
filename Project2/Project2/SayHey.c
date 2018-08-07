#include <Windows.h>

int WINAPI WinMain(HINSTANCE hInstance , HINSTANCE hPrevInstance , PSTR szCmdLine, int iCmdShow)
{
	MessageBox(NULL, TEXT("这是我的第一个程序！"), TEXT("打招呼"), MB_OK);
	return 0;
}