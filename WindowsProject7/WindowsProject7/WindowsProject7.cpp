// WindowsProject7.cpp : Defines the entry point for the application.
//

#include <windows.h>
#include <CommCtrl.h>
#include <string>
#include "framework.h"
#include "WindowsProject7.h"
#include <unordered_map>

#define MAX_LOADSTRING 100

// Global Variables:
HINSTANCE hInst;                                // current instance
WCHAR szTitle[MAX_LOADSTRING];                  // The title bar text
WCHAR szWindowClass[MAX_LOADSTRING];            // the main window class name
HWND comboCPU, comboGPU, comboRAM, buttonCalculate, staticResult;

// Forward declarations of functions included in this code module:
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK PCConfiguratorDialog(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam);

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    // Initialize global strings
    LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
    LoadStringW(hInstance, IDC_WINDOWSPROJECT7, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_WINDOWSPROJECT7));

    MSG msg;

    // Main message loop:
    while (GetMessage(&msg, nullptr, 0, 0))
    {
        if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
        {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
    }

    return (int) msg.wParam;
}

ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW wcex;

    wcex.cbSize = sizeof(WNDCLASSEX);

    wcex.style          = CS_HREDRAW | CS_VREDRAW;
    wcex.lpfnWndProc    = WndProc;
    wcex.cbClsExtra     = 0;
    wcex.cbWndExtra     = 0;
    wcex.hInstance      = hInstance;
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_WINDOWSPROJECT7));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOW+1);
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDC_WINDOWSPROJECT7);
    wcex.lpszClassName  = szWindowClass;
    wcex.hIconSm        = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&wcex);
}

BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // Store instance handle in our global variable

   HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, nullptr, nullptr, hInstance, nullptr);

   if (!hWnd)
   {
      return FALSE;
   }

   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);

   return TRUE;
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    switch (message)
    {
    case WM_COMMAND:
        {
            int wmId = LOWORD(wParam);
            switch (wmId)
            {
            case IDM_ABOUT:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
                break;
            case IDM_EXIT:
                DestroyWindow(hWnd);
                break;
            case IDM_CONFIGURATOR:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_CONFIGURATOR), hWnd, PCConfiguratorDialog);
                break;
            default:
                return DefWindowProc(hWnd, message, wParam, lParam);
            }
        }
        break;
    case WM_PAINT:
        {
            PAINTSTRUCT ps;
            HDC hdc = BeginPaint(hWnd, &ps);
            // TODO: Add any drawing code that uses hdc here...
            EndPaint(hWnd, &ps);
        }
        break;
    case WM_DESTROY:
        PostQuitMessage(0);
        break;
    default:
        return DefWindowProc(hWnd, message, wParam, lParam);
    }
    return 0;
}

INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}


using PartPriceMap = std::unordered_map<std::wstring, double>;

double GetPartPrice(const std::wstring& selectedPart, const PartPriceMap& partPrices) {
    auto it = partPrices.find(selectedPart);
    if (it != partPrices.end()) {
        return it->second;
    }
    return 0.0;  // Default to 0 if part is not found
}

PartPriceMap partPrices = {
    { L"Intel i5", 200.0 },
    { L"AMD Ryzen 7", 250.0 },
    { L"Intel i9", 400.0 },
    { L"AMD Ryzen 9", 450.0 },
    { L"NVIDIA RTX 3060", 300.0 },
    { L"NVIDIA RTX 3070", 450.0 },
    { L"NVIDIA RTX 3080", 600.0 },
    { L"AMD Radeon RX 6700 XT", 400.0 },
    { L"AMD Radeon RX 6800 XT", 550.0 },
    { L"AMD Radeon RX 6900 XT", 700.0 },
    { L"16GB DDR4", 80.0 },
    { L"32GB DDR4", 150.0 },
    { L"64GB DDR4", 280.0 },
};

INT_PTR CALLBACK PCConfiguratorDialog(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        // Combo boxes for CPU, GPU, and RAM
        comboCPU = GetDlgItem(hDlg, IDC_COMBO_CPU);
        comboGPU = GetDlgItem(hDlg, IDC_COMBO_GPU);
        comboRAM = GetDlgItem(hDlg, IDC_COMBO_RAM);

         // Populate combo boxes with example options
        for (const wchar_t* cpu : { L"Intel i5", L"AMD Ryzen 7", L"Intel i9" }) {
            SendMessage(comboCPU, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(cpu));
        }

        for (const wchar_t* gpu : { L"NVIDIA RTX 3060", L"AMD Radeon RX 6700 XT", L"NVIDIA RTX 3080" }) {
            SendMessage(comboGPU, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(gpu));
        }

        for (const wchar_t* ram : { L"16GB DDR4", L"32GB DDR4", L"64GB DDR4" }) {
            SendMessage(comboRAM, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(ram));
        }

        buttonCalculate = GetDlgItem(hDlg, IDC_BUTTON_CALCULATE);   // Button for calculation

        staticResult = GetDlgItem(hDlg, IDC_STATIC_RESULT); // Static text for displaying the result
        break;

    case WM_COMMAND:

        if (LOWORD(wParam) == IDC_BUTTON_CALCULATE) {
            // Handle the Calculate button click
            // MessageBox(hDlg, L"Calculating total price...", L"Calculate", MB_OK | MB_ICONINFORMATION);

             // Get the selected options from combo boxes
            wchar_t selectedCPU[256], selectedGPU[256], selectedRAM[256];
            SendMessage(comboCPU, CB_GETLBTEXT, SendMessage(comboCPU, CB_GETCURSEL, 0, 0), reinterpret_cast<LPARAM>(selectedCPU));
            SendMessage(comboGPU, CB_GETLBTEXT, SendMessage(comboGPU, CB_GETCURSEL, 0, 0), reinterpret_cast<LPARAM>(selectedGPU));
            SendMessage(comboRAM, CB_GETLBTEXT, SendMessage(comboRAM, CB_GETCURSEL, 0, 0), reinterpret_cast<LPARAM>(selectedRAM));

            // Look up prices based on selected options
            double cpuPrice = GetPartPrice(selectedCPU, partPrices);
            double gpuPrice = GetPartPrice(selectedGPU, partPrices);
            double ramPrice = GetPartPrice(selectedRAM, partPrices);

            // Calculate total price
            double totalPrice = cpuPrice + gpuPrice + ramPrice;

            // Display the total price in the static text control
            wchar_t resultText[256];
            swprintf_s(resultText, L"Total Price: $%.2f", totalPrice);
            SetWindowText(staticResult, resultText);


        } else if (LOWORD(wParam) == IDCANCEL) {
            // Handle the Close button
            EndDialog(hDlg, IDCANCEL);
        }
        break;
    }

    return (INT_PTR)FALSE;
}