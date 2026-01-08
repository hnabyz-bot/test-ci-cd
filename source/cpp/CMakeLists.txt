# source/cpp/CMakeLists.txt
cmake_minimum_required(VERSION 3.10)
project(HelloWorld CXX)

add_executable(HelloWorld main.cpp)

enable_testing() # Enable testing for CTest

add_executable(run_test test/main_test.cpp)

add_test(NAME GreetTest COMMAND run_test)
