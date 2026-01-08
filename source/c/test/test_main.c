// source/c/test/test_main.c
#include <stdio.h>
#include <string.h>
#include <assert.h> // For simple assert

// Include the greet function directly for testing
// In a more complex project, you'd link against the object file/library
void greet(char* buffer, int buffer_size, const char* name) {
    snprintf(buffer, buffer_size, "Hello, %s!", name);
}

void test_greet() {
    char buffer[100];

    // Test case 1
    greet(buffer, sizeof(buffer), "World");
    assert(strcmp(buffer, "Hello, World!") == 0);
    printf("Test 'World' passed.\n");

    // Test case 2
    greet(buffer, sizeof(buffer), "C Programming");
    assert(strcmp(buffer, "Hello, C Programming!") == 0);
    printf("Test 'C Programming' passed.\n");
}

int main() {
    test_greet();
    return 0;
}
