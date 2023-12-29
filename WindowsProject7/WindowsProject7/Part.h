#pragma once
#include <string>
#include <vector>

class Part {
public:
    std::wstring name;
    double price;

    // Constructor to initialize the part with a name and price
    Part(const std::wstring& n, double p) : name(n), price(p) {}
};

// Function to get the price of a selected part
double GetPartPrice(const std::wstring& selectedPart, const std::vector<Part>& parts) {
    for (const Part& part : parts) {
        if (part.name == selectedPart) {
            return part.price;
        }
    }
    return 0.0;  // Default to 0 if part is not found (you can handle this differently based on your needs)
}
