# C++ CI/CD 학습 가이드

## 프로젝트 구조

```
source/cpp/
├── main.cpp          # 메인 소스 코드
├── CMakeLists.txt    # CMake 빌드 설정
└── test/             # 테스트 코드
    └── main_test.cpp
```

## 테스트 환경

- 컴파일러: `g++`
- 빌드 시스템: `CMake`
- CI 환경: `ubuntu-latest`

## GitHub Actions 워크플로우

### 워크플로우 단계

1. **Configure CMake**: 빌드 디렉토리 설정
2. **Build**: cmake --build 실행
3. **Test**: ctest 실행

### 주요 설정

```yaml
working-directory: source/cpp
runs-on: ubuntu-latest
```

## 로컬 테스트 방법

```bash
cd source/cpp
cmake -B build
cmake --build build --config Release
cd build
ctest
```

## CI/CD 테스트 결과

### 2026-01-08 - 초기 설정 및 성공

- **결과**: ✅ 성공
- **빌드**: CMake 설정 및 빌드 성공
- **테스트**: ctest 실행 성공
