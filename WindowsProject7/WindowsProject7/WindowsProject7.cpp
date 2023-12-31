// WindowsProject7.cpp : Defines the entry point for the application.
//
#include <windows.h>
#include <CommCtrl.h>
#include <string>
#include "framework.h"
#include "WindowsProject7.h"
#include <unordered_map>
#include <iomanip>  // For std::fixed and std::setprecision
#include <sstream>  // For std::wstringstream
#include "Part.h"  // Include the Part class definition

#define MAX_LOADSTRING 100

// Global Variables:
HINSTANCE hInst;                                // current instance
WCHAR szTitle[MAX_LOADSTRING];                  // The title bar text
WCHAR szWindowClass[MAX_LOADSTRING];            // the main window class name
HWND comboCPU, comboGPU, comboRAM, buttonCalculate, staticResult, checkboxBluetooth, checkboxInsurance, editCustomMessage, buttonReset,
    comboMotherboard, comboSSD, comboHDD, comboPowerSupply, comboCooling, comboCase, comboOS, listBoxSelected;

// Forward declarations of functions included in this code module:
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK PCConfiguratorDialog(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam);
void AddComponentToListBox(HWND listBox, const std::wstring& category, const std::wstring& componentName);

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

Part motherboard_asus1(L"ASUS ROG Strix B550-F Gaming", 250.0, PartType::Motherboard);
Part motherboard_msi1(L"MSI MPG Z490 Gaming Edge WiFi", 350.0, PartType::Motherboard);
Part motherboard_gigabyte1(L"Gigabyte B450 AORUS Elite", 210.0, PartType::Motherboard);
Part motherboard_asrock1(L"ASRock B550M-ITX/ac", 150.0, PartType::Motherboard);

Part ssd_samsung1(L"Samsung 970 EVO Plus 500GB (NVMe)", 170.0, PartType::SSD);
Part ssd_crucial1(L"Crucial MX500 1TB (SATA)", 120.0, PartType::SSD);
Part ssd_wd1(L"WD Black SN750 1TB (NVMe)", 190.0, PartType::SSD);
Part ssd_kingston1(L"Kingston A2000 250GB (NVMe)", 110.0, PartType::SSD);

Part hdd_seagate1(L"Seagate Barracuda 2TB (7200 RPM)", 115.0, PartType::HDD);
Part hdd_western1(L"Western Digital Blue 4TB (5400 RPM)", 185.0, PartType::HDD);
Part hdd_toshiba1(L"Toshiba P300 1TB (7200 RPM)", 99.0, PartType::HDD);

Part powerSupply_evga1(L"EVGA SuperNOVA 650 G5, 80 Plus Gold 650W", 60.0, PartType::PowerSupply);
Part powerSupply_corsair1(L"Corsair RM750x, 80 Plus Gold 750W", 85.0, PartType::PowerSupply);
Part powerSupply_seasonic1(L"Seasonic FOCUS GX-850, 80 Plus Gold 850W", 50.0, PartType::PowerSupply);

Part cooling_noctua1(L"Noctua NH-D15 (Air Cooling)", 30.0, PartType::Cooling);
Part cooling_corsair1(L"Corsair Platinum (Liquid Cooling)", 40.0, PartType::Cooling);
Part cooling_nzxt1(L"NZXT Kraken X63 (Liquid Cooling)", 95.0, PartType::Cooling);

Part case_nzxt1(L"NZXT H510i", 60.0, PartType::Case);
Part case_coolermaster1(L"Cooler Master MasterBox Q300L", 29.0, PartType::Case);
Part case_phanteks1(L"Phanteks Enthoo Pro", 120.0, PartType::Case);

Part os_windows(L"Windows 11 (Pro)", 100.0, PartType::OS);
Part os_linux(L"Linux (Ubuntu)", 80.0, PartType::OS);
Part os_macOS(L"macOS (Big Sur)", 120.0, PartType::OS);
Part os_none(L"None", 0.0, PartType::OS);

std::vector<Part> parts = {
    intel_i5, amd_ryzen_7, intel_i9, amd_ryzen_9,
    nvidia_rtx3060, nvidia_rtx3070, nvidia_rtx3080, amd_rx6700xt, amd_rx6800xt, amd_rx6900xt,
    ram_16gb_ddr4, ram_32gb_ddr4, ram_64gb_ddr4,
    motherboard_asus1, motherboard_msi1, motherboard_gigabyte1, motherboard_asrock1,
    ssd_samsung1, ssd_crucial1, ssd_wd1, ssd_kingston1,
    hdd_seagate1, hdd_western1, hdd_toshiba1, 
    powerSupply_evga1, powerSupply_corsair1, powerSupply_seasonic1, 
    cooling_noctua1, cooling_corsair1, cooling_nzxt1, 
    case_nzxt1, case_coolermaster1, case_phanteks1, 
    os_windows, os_linux, os_macOS, os_none
};

std::vector<Part> cpuParts;
std::vector<Part> gpuParts;
std::vector<Part> ramParts;
std::vector<Part> motherboardParts;
std::vector<Part> ssdParts;
std::vector<Part> hddParts;
std::vector<Part> powerSupplyParts;
std::vector<Part> coolingParts;
std::vector<Part> casesParts;
std::vector<Part> osParts;

INT_PTR CALLBACK PCConfiguratorDialog(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        // Combo boxes
        comboCPU = GetDlgItem(hDlg, IDC_COMBO_CPU); // Slojil sum Sort=False
        comboGPU = GetDlgItem(hDlg, IDC_COMBO_GPU); 
        comboRAM = GetDlgItem(hDlg, IDC_COMBO_RAM); 
        comboMotherboard = GetDlgItem(hDlg, IDC_COMBO_MOTHERBOARD);
        comboSSD = GetDlgItem(hDlg, IDC_COMBO_SSD);
        comboHDD = GetDlgItem(hDlg, IDC_COMBO_HDD);
        comboPowerSupply = GetDlgItem(hDlg, IDC_COMBO_POWERSUPPLY);
        comboCooling = GetDlgItem(hDlg, IDC_COMBO_COOLING);
        comboCase = GetDlgItem(hDlg, IDC_COMBO_CASE);
        comboOS = GetDlgItem(hDlg, IDC_COMBO_OS);
        listBoxSelected = GetDlgItem(hDlg, IDC_LIST1);


        // Populate combo boxes with example options
        for (const auto& part : parts) {
            std::wstringstream ss;
            ss << std::fixed << std::setprecision(2) << part.GetPrice();
            std::wstring priceText = ss.str();

            // Ensure exactly 2 digits after the dot
            size_t dotPos = priceText.find(L'.');
            if (dotPos != std::wstring::npos && priceText.length() > dotPos + 2) {
                priceText = priceText.substr(0, dotPos + 3);  // Keep only two digits after the dot
            } else {
                priceText += L".00";  // Add ".00" if there are less than 2 digits after the dot
            }

            std::wstring itemText = part.GetName() + L" - $" + priceText;

            // Add the string to the respective combo box based on part type
            switch (part.GetPartType()) {
                case PartType::CPU:
                    cpuParts.push_back(part); // Add the part in its PartType Vector
                    SendMessage(comboCPU, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::GPU:
                    gpuParts.push_back(part); 
                    SendMessage(comboGPU, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::RAM:
                    ramParts.push_back(part); 
                    SendMessage(comboRAM, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::Motherboard:
                    motherboardParts.push_back(part);
                    SendMessage(comboMotherboard, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                 case PartType::SSD:
                    ssdParts.push_back(part);
                    SendMessage(comboSSD, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::HDD:
                    hddParts.push_back(part);
                    SendMessage(comboHDD, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::PowerSupply:
                    powerSupplyParts.push_back(part);
                    SendMessage(comboPowerSupply, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::Cooling:
                    coolingParts.push_back(part);
                    SendMessage(comboCooling, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::Case:
                    casesParts.push_back(part);
                    SendMessage(comboCase, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
                    break;
                case PartType::OS:
                    osParts.push_back(part);
                    SendMessage(comboOS, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
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

            SendMessage(listBoxSelected, LB_RESETCONTENT, 0, 0); // Clear the ListBox

            // Get the selected options from combo boxes
            int indexCPU = SendMessage(comboCPU, CB_GETCURSEL, 0, 0);
            int indexGPU = SendMessage(comboGPU, CB_GETCURSEL, 0, 0);
            int indexRAM = SendMessage(comboRAM, CB_GETCURSEL, 0, 0);
            int indexMotherboard = SendMessage(comboMotherboard, CB_GETCURSEL, 0, 0);
            int indexSSD = SendMessage(comboSSD, CB_GETCURSEL, 0, 0);
            int indexHDD = SendMessage(comboHDD, CB_GETCURSEL, 0, 0);
            int indexPowersupply = SendMessage(comboPowerSupply, CB_GETCURSEL, 0, 0);
            int indexCooling = SendMessage(comboCooling, CB_GETCURSEL, 0, 0);
            int indexCase = SendMessage(comboCase, CB_GETCURSEL, 0, 0);
            int indexOS = SendMessage(comboOS, CB_GETCURSEL, 0, 0);

            double cpuPrice = 0;
            double gpuPrice = 0;
            double ramPrice = 0;
            double motherboardPrice = 0;
            double ssdPrice = 0;
            double hddPrice = 0;
            double powersupplyPrice = 0;
            double coolingPrice = 0;
            double casePrice = 0;
            double osPrice = 0;

            // Check if any selection is not made
            if (indexCPU != CB_ERR && indexCPU < parts.size()) {
                cpuPrice = cpuParts[indexCPU].GetPrice();
                AddComponentToListBox(listBoxSelected, L"CPU", cpuParts[indexCPU].GetName());
            }        
            if (indexGPU != CB_ERR && indexGPU < parts.size()) {
                gpuPrice = gpuParts[indexGPU].GetPrice();
                AddComponentToListBox(listBoxSelected, L"GPU", gpuParts[indexGPU].GetName());
            }
            if (indexRAM != CB_ERR && indexRAM < parts.size()) {
                ramPrice = ramParts[indexRAM].GetPrice();
                AddComponentToListBox(listBoxSelected, L"RAM", ramParts[indexRAM].GetName());
            }
            if (indexMotherboard != CB_ERR) {
                motherboardPrice = motherboardParts[indexMotherboard].GetPrice();
                AddComponentToListBox(listBoxSelected, L"Motherboard", motherboardParts[indexMotherboard].GetName());
            }
            if (indexSSD != CB_ERR) {
                ssdPrice = ssdParts[indexSSD].GetPrice();
                AddComponentToListBox(listBoxSelected, L"SSD", ssdParts[indexSSD].GetName());
            }
            if (indexHDD != CB_ERR) {
                hddPrice = hddParts[indexHDD].GetPrice();
                AddComponentToListBox(listBoxSelected, L"HDD", hddParts[indexHDD].GetName());
            }
            if (indexPowersupply != CB_ERR) {
                powersupplyPrice = powerSupplyParts[indexPowersupply].GetPrice();
                AddComponentToListBox(listBoxSelected, L"PowerSupply", powerSupplyParts[indexPowersupply].GetName());
            }
            if (indexCooling != CB_ERR) {
                coolingPrice = coolingParts[indexCooling].GetPrice();
                AddComponentToListBox(listBoxSelected, L"Cooling", coolingParts[indexCooling].GetName());
            }
            if (indexCase != CB_ERR) {
                casePrice = casesParts[indexCase].GetPrice();
                AddComponentToListBox(listBoxSelected, L"Case", casesParts[indexCase].GetName());
            }
            if (indexOS != CB_ERR) {
                osPrice = osParts[indexOS].GetPrice();
                AddComponentToListBox(listBoxSelected, L"OS", osParts[indexOS].GetName());
            }

            double totalPrice = cpuPrice + gpuPrice + ramPrice 
                + motherboardPrice + ssdPrice + hddPrice + powersupplyPrice 
                + coolingPrice + casePrice + osPrice;

            // Adjust total price if Bluetooth checkbox is checked
            if (SendMessage(checkboxBluetooth, BM_GETCHECK, 0, 0) == BST_CHECKED) {
                totalPrice += 50.0;
                AddComponentToListBox(listBoxSelected, L"Other", L"Bluetooth");
            }
            // Adjust total price if Insurance checkbox is checked
            if (SendMessage(checkboxInsurance, BM_GETCHECK, 0, 0) == BST_CHECKED) {
                totalPrice += 60.0;
                AddComponentToListBox(listBoxSelected, L"Other", L"Insurance");
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
            SendMessage(comboCPU, CB_SETCURSEL, -1, 0);  
            SendMessage(comboGPU, CB_SETCURSEL, -1, 0);  
            SendMessage(comboRAM, CB_SETCURSEL, -1, 0);  
            SendMessage(checkboxBluetooth, BM_SETCHECK, BST_UNCHECKED, 0); 
            SendMessage(checkboxInsurance, BM_SETCHECK, BST_UNCHECKED, 0); 
            SetWindowText(editCustomMessage, L"");  
            SetWindowText(staticResult, L"Total Price: $0.00");  
            SendMessage(comboMotherboard, CB_SETCURSEL, -1, 0); 
            SendMessage(comboSSD, CB_SETCURSEL, -1, 0); 
            SendMessage(comboHDD, CB_SETCURSEL, -1, 0); 
            SendMessage(comboPowerSupply, CB_SETCURSEL, -1, 0); 
            SendMessage(comboCooling, CB_SETCURSEL, -1, 0); 
            SendMessage(comboCase, CB_SETCURSEL, -1, 0); 
            SendMessage(comboOS, CB_SETCURSEL, -1, 0); 
            SendMessage(listBoxSelected, LB_RESETCONTENT, 0, 0);
        }

        break;
    }

    return (INT_PTR)FALSE;
}

void AddComponentToListBox(HWND listBox, const std::wstring& category, const std::wstring& componentName)
{
    // Assuming you have a std::wstring named itemText
    std::wstring itemText = category + L": " + componentName;
    SendMessage(listBox, LB_ADDSTRING, 0, reinterpret_cast<LPARAM>(itemText.c_str()));
}

