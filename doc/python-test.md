# Python CI/CD 학습 가이드

## 프로젝트 구조

```
source/python/
├── hello.py          # 메인 소스 코드
├── test_hello.py     # pytest 테스트
└── requirements.txt  # 의존성 패키지
```

## 테스트 환경

- Python 버전: `3.x`
- 테스트 프레임워크: `pytest`
- CI 환경: `ubuntu-latest`

## 주요 구성 요소

### hello.py
```python
def greet(name):
    return f"Hello, {name}!"
```

### test_hello.py
```python
from hello import greet

def test_greet():
    assert greet("World") == "Hello, World!"
    assert greet("Gemini") == "Hello, Gemini!"
```

## GitHub Actions 워크플로우

### 워크플로우 단계

1. **Setup Python**: Python 3.x 설치
2. **Install dependencies**: pip로 pytest 설치
3. **Run tests**: `python -m pytest -v` 실행

### 주요 설정

```yaml
working-directory: source/python
python-version: '3.x'
```

## 로컬 테스트 방법

```bash
cd source/python
pip install pytest
python -m pytest -v
```

## CI/CD 테스트 결과

### 2026-01-08 - 초기 설정 및 성공

- **결과**: ✅ 성공
- **테스트**: 2개 통과
- **실행 시간**: ~10초

**워크플로우**:
1. Python 3.x 설치 - 성공
2. pip install pytest - 성공
3. pytest 실행 - 2개 테스트 통과
