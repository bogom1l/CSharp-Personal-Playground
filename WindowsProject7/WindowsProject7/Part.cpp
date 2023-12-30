#include "Part.h"

// Constructor
Part::Part(const std::wstring& name, double price, PartType type)
    : name(name), price(price), type(type) {}

// Getter methods
const std::wstring& Part::GetName() const {
    return name;
}

double Part::GetPrice() const {
    return price;
}

PartType Part::GetPartType() const {
    return type;
}