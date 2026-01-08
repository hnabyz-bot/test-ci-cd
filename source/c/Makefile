# source/c/Makefile
CC = gcc
CFLAGS = -Wall -Wextra -std=c11

all: hello_world test_runner

hello_world: main.o
	$(CC) $(CFLAGS) main.o -o hello_world

main.o: main.c
	$(CC) $(CFLAGS) -c main.c

test_runner: test_main.o
	$(CC) $(CFLAGS) test_main.o -o test_runner

test_main.o: test/test_main.c
	$(CC) $(CFLAGS) -c test/test_main.c -o test_main.o

test: test_runner
	./test_runner

clean:
	rm -f *.o hello_world test_runner
