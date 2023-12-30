// WindowsProject7.cpp : Defines the entry point for the application.
//
#include <windows.h>
#include <CommCtrl.h>
#include <string>
#include "framework.h"
#include "WindowsProject7.h"
#include <unordered_map>
#include "Part.h"  // Include the Part class definition

#define MAX_LOADSTRING 100

// Global Variables:
HINSTANCE hInst;                                // current instance
WCHAR szTitle[MAX_LOADSTRING];                  // The title bar text
WCHAR szWindowClass[MAX_LOADSTRING];            // the main window class name
HWND comboCPU, comboGPU, comboRAM, buttonCalculate, staticResult, checkboxBluetooth, checkboxInsurance, editCustomMessage, buttonReset;

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


Part intel_i5(L"Intel i5", 200.0, PartType::CPU);
Part amd_ryzen_7(L"AMD Ryzen 7", 250.0, PartType::CPU);
Part intel_i9(L"Intel i9", 400.0, PartType::CPU);
Part amd_ryzen_9(L"AMD Ryzen 9", 450.0, PartType::CPU);
Part nvidia_rtx3060(L"NVIDIA RTX 3060", 300.0, PartType::GPU);
Part nvidia_rtx3070(L"NVIDIA RTX 3070", 450.0, PartType::GPU);
Part nvidia_rtx3080(L"NVIDIA RTX 3080", 600.0, PartType::GPU);
Part amd_rx6700xt(L"AMD Radeon RX 6700 XT", 400.0, PartType::GPU);
Part amd_rx6800xt(L"AMD Radeon RX 6800 XT", 550.0, PartType::GPU);
Part amd_rx6900xt(L"AMD Radeon RX 6900 XT", 700.0, PartType::GPU);
Part ram_16gb_ddr4(L"16GB DDR4", 80.0, PartType::RAM);
Part ram_32gb_ddr4(L"32GB DDR4", 150.0, PartType::RAM);
Part ram_64gb_ddr4(L"64GB DDR4", 280.0, PartType::RAM);

std::vector<Part> parts = {
    intel_i5, amd_ryzen_7, intel_i9, amd_ryzen_9,
    nvidia_rtx3060, nvidia_rtx3070, nvidia_rtx3080, amd_rx6700xt, amd_rx6800xt, amd_rx6900xt,
    ram_16gb_ddr4, ram_32gb_ddr4, ram_64gb_ddr4
};

std::vector<Part> cpuParts;
std::vector<Part> gpuParts;
std::vector<Part> ramParts;

INT_PTR CALLBACK PCConfiguratorDialog(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        // Combo boxes for CPU, GPU, and RAM
        comboCPU = GetDlgItem(hDlg, IDC_COMBO_CPU); // Slojil sum Sort=False
        comboGPU = GetDlgItem(hDlg, IDC_COMBO_GPU); // Slojil sum Sort=False
        comboRAM = GetDlgItem(hDlg, IDC_COMBO_RAM); // Slojil sum Sort=False

        // Populate combo boxes with example options
        for (const auto& part : parts) {
            std::wstring itemText = part.GetName() + L" - $" + std::to_wstring(part.GetPrice());

            // Add the string to the respective combo box based on part type
            switch (part.GetPartType()) {
                case PartType::CPU:
                    cpuParts.push_back(part); // Add the part in its PartType Vector
                    SendMessage(comboCPU, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::GPU:
                    gpuParts.push_back(part); // Add the part in its PartType Vector
                    SendMessage(comboGPU, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::RAM:
                    ramParts.push_back(part); // Add the part in its PartType Vector
                    SendMessage(comboRAM, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                // Add similar cases for other part types

            }
        }


        checkboxBluetooth = GetDlgItem(hDlg, IDC_CHECK_BLUETOOTH);
        checkboxInsurance = GetDlgItem(hDlg, IDC_CHECK_INSURANCE);
        editCustomMessage = GetDlgItem(hDlg, IDC_EDIT_CUSTOMMESSAGE);
        buttonCalculate = GetDlgItem(hDlg, IDC_BUTTON_CALCULATE);
        staticResult = GetDlgItem(hDlg, IDC_STATIC_RESULT);
        buttonReset = GetDlgItem(hDlg, IDC_BUTTON_RESET);

        break;

    case WM_COMMAND:

         if (LOWORD(wParam) == IDC_BUTTON_CALCULATE) {
            // Get the selected options from combo boxes
            int indexCPU = SendMessage(comboCPU, CB_GETCURSEL, 0, 0);
            int indexGPU = SendMessage(comboGPU, CB_GETCURSEL, 0, 0);
            int indexRAM = SendMessage(comboRAM, CB_GETCURSEL, 0, 0);

            double cpuPrice = 0;
            double gpuPrice = 0;
            double ramPrice = 0;

            // Check if any selection is not made
            if (indexCPU != CB_ERR && indexCPU < parts.size()) {
                cpuPrice = cpuParts[indexCPU].GetPrice();
            }        
            
            if (indexGPU != CB_ERR && indexGPU < parts.size()) {
                gpuPrice = gpuParts[indexGPU].GetPrice();
            }
            if (indexRAM != CB_ERR && indexRAM < parts.size()) {
                ramPrice = ramParts[indexRAM].GetPrice();
            }

            double totalPrice = cpuPrice + gpuPrice + ramPrice;

            // Adjust total price if Bluetooth checkbox is checked
            if (SendMessage(checkboxBluetooth, BM_GETCHECK, 0, 0) == BST_CHECKED) {
                totalPrice += 50.0;
            }
            // Adjust total price if Insurance checkbox is checked
            if (SendMessage(checkboxInsurance, BM_GETCHECK, 0, 0) == BST_CHECKED) {
                totalPrice += 60.0;
            }

            // Display the total price in the static text control
            wchar_t resultText[256];
            swprintf_s(resultText, L"Total Price: $%.2f", totalPrice);
            SetWindowText(staticResult, resultText);
         }





        else if (LOWORD(wParam) == IDCANCEL) { // Handle the Close button
            EndDialog(hDlg, IDCANCEL);
        } 
      
        else if (LOWORD(wParam) == IDC_BUTTON_RESET) { // Handle the Reset button click
            SendMessage(comboCPU, CB_SETCURSEL, -1, 0);  // Clear CPU selection
            SendMessage(comboGPU, CB_SETCURSEL, -1, 0);  // Clear GPU selection
            SendMessage(comboRAM, CB_SETCURSEL, -1, 0);  // Clear RAM selection
            SendMessage(checkboxBluetooth, BM_SETCHECK, BST_UNCHECKED, 0);  // Uncheck Bluetooth
            SendMessage(checkboxInsurance, BM_SETCHECK, BST_UNCHECKED, 0);  // Uncheck Insurance
            SetWindowText(editCustomMessage, L"");  // Clear custom message
            SetWindowText(staticResult, L"Total Price: $0.00");  // Reset total price display

        }

        break;
    }

    return (INT_PTR)FALSE;
}