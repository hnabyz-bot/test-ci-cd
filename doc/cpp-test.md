# C++ 테스트 기록

이 문서는 C++ 프로젝트의 CI/CD 테스트 진행 상황을 기록합니다.

## 테스트 환경

- 컴파일러: `g++`/`clang++`/`MSVC`
- 빌드 시스템: `CMake`/`Make`/`MSBuild`
- 운영체제: `Windows/Linux/macOS`

## 테스트 명령어

```shell
# 예시 (CMake)
mkdir build
cd build
cmake ..
make
ctest
```

## 테스트 결과

### [날짜] - [테스트 내용]

- **결과**: 성공/실패
- **로그**:
  ```
  (테스트 결과 로그)
  ```
