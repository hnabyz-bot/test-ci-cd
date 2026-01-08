# source/python/test_hello.py
from hello import greet

def test_greet():
    assert greet("World") == "Hello, World!"
    assert greet("Gemini") == "Hello, Gemini!"
