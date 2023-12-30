#pragma once
#include <string>
#include "PartType.h"  // Include the file with the enum definition

class Part {
public:
    Part(const std::wstring& name, double price, PartType type);

    const std::wstring& GetName() const;
    double GetPrice() const;
    PartType GetPartType() const;

private:
    std::wstring name;
    double price;
    PartType type;
};