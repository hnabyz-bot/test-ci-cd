# C CI/CD 학습 가이드

## 프로젝트 구조

```
source/c/
├── main.c           # 메인 소스 코드
├── Makefile         # 빌드 스크립트
└── test/            # 테스트 코드
    └── test_main.c
```

## 테스트 환경

- 컴파일러: `gcc`
- 빌드 시스템: `Make`
- CI 환경: `ubuntu-latest`

## GitHub Actions 워크플로우

### 워크플로우 단계

1. **Build**: `make all` 실행
2. **Test**: `make test` 실행

### 주요 설정

```yaml
working-directory: source/c
runs-on: ubuntu-latest
```

## 로컬 테스트 방법

```bash
cd source/c
make all
make test
```

## CI/CD 테스트 결과

### 2026-01-08 - 초기 설정 및 성공

- **결과**: ✅ 성공
- **빌드**: gcc로 컴파일 성공
- **테스트**: 테스트 실행 성공
