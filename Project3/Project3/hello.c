#include <windows.h>

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PSTR szCmdLine, int iCmdShow)
{

	MessageBox(NULL, TEXT("�����ҵ�һ������"), TEXT("���⣡"), MB_YESNO | MB_ICONINFORMATION | MB_DEFBUTTON2);
	
	return 0;

}