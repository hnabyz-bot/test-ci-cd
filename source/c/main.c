// source/c/main.c
#include <stdio.h>
#include <string.h>

void greet(char* buffer, int buffer_size, const char* name) {
    snprintf(buffer, buffer_size, "Hello, %s!", name);
}

int main() {
    char buffer[100];
    greet(buffer, sizeof(buffer), "World");
    printf("%s\n", buffer);
    return 0;
}

