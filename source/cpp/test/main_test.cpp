// source/cpp/test/main_test.cpp
#include <cassert>
#include <string>
#include <iostream>

// Assume greet function is available or include it directly for testing purposes
// For a proper unit test, you would link against the library containing greet
std::string greet(const std::string& name) {
    return "Hello, " + name + "!";
}

void test_greet() {
    assert(greet("World") == "Hello, World!");
    assert(greet("Gemini") == "Hello, Gemini!");
    std::cout << "All greet tests passed!" << std::endl;
}

int main() {
    test_greet();
    return 0;
}
