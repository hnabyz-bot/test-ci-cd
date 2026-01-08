# C# CI/CD 학습 가이드

## 프로젝트 구조

```
source/csharp/
├── HelloWorld.csproj      # 메인 프로젝트 파일
├── Program.cs             # 프로그램 진입점 및 비즈니스 로직
└── Tests/
    ├── Tests.csproj       # 테스트 프로젝트 파일
    └── GreeterTests.cs    # xUnit 테스트
```

## 주요 구성 요소

### 1. 프로젝트 파일 (HelloWorld.csproj)
- **.NET SDK 프로젝트**: `Sdk="Microsoft.NET.Sdk"`
- **출력 타입**: 콘솔 애플리케이션
- **타겟 프레임워크**: .NET 8.0

### 2. 소스 코드 (Program.cs)
- **Greeter 클래스**: 인사말 생성 로직
- **테스트 가능한 구조**: public static 메서드로 테스트 용이

### 3. 테스트 프로젝트 (Tests/)
- **xUnit 프레임워크**: .NET에서 널리 사용되는 테스트 프레임워크
- **프로젝트 참조**: 메인 프로젝트를 참조하여 테스트
- **Fact 특성**: 개별 테스트 메서드 표시

## GitHub Actions 워크플로우

### 워크플로우 단계

1. **Setup .NET**: .NET 8.0 SDK 설치
2. **Restore dependencies**: NuGet 패키지 복원
3. **Build**: 프로젝트 및 테스트 빌드
4. **Test**: xUnit 테스트 실행

### 주요 설정

```yaml
working-directory: source/csharp  # 작업 디렉토리 지정
dotnet-version: '8.0.x'            # .NET 버전 지정
--no-restore                       # 이미 복원된 패키지 재사용
--no-build                         # 이미 빌드된 바이너리 재사용
```

## 로컬 테스트 방법

### Windows (PowerShell)
```powershell
cd source/csharp
dotnet restore
dotnet build
dotnet test Tests/Tests.csproj
```

### 개별 테스트 실행
```powershell
dotnet test Tests/Tests.csproj --filter "FullyQualifiedName~Greet_WithName"
```

### 자세한 출력
```powershell
dotnet test Tests/Tests.csproj --verbosity detailed
```

## 학습 포인트

### 1. .NET 프로젝트 구조
- `.csproj` 파일: 프로젝트 설정 및 의존성 관리
- 네임스페이스: 코드 조직화
- 프로젝트 참조: 테스트와 메인 프로젝트 연결

### 2. xUnit 테스트 작성
- **[Fact]**: 매개변수가 없는 단순 테스트
- **Arrange-Act-Assert**: 테스트 구조화 패턴
- **Assert.Equal**: 값 비교 검증

### 3. CI/CD 파이프라인
- **의존성 복원**: 빌드 전 필요한 패키지 다운로드
- **빌드**: 소스 코드를 실행 가능한 바이너리로 컴파일
- **테스트**: 자동화된 테스트로 코드 검증
- **캐싱**: `--no-restore`, `--no-build`로 빌드 속도 향상

## 일반적인 문제 해결

### 테스트 실패
```bash
# 테스트가 실패하면 CI는 자동으로 실패 상태가 됩니다
# 로그를 확인하고 Assert 조건을 확인하세요
```

### 빌드 오류
```bash
# 프로젝트 참조가 올바른지 확인
# .NET SDK 버전이 일치하는지 확인
```

### 패키지 복원 실패
```bash
# NuGet 소스가 접근 가능한지 확인
# 패키지 버전이 존재하는지 확인
```

## 실제 발생한 문제 및 해결 사례

### 사례 1: Tests 폴더가 메인 프로젝트에 포함되어 컴파일 오류 발생

**문제**:
```
error CS0246: The type or namespace name 'FactAttribute' could not be found
```

**원인**: .NET SDK 프로젝트는 기본적으로 프로젝트 폴더의 모든 `.cs` 파일을 자동으로 포함합니다. Tests 폴더의 테스트 코드가 메인 프로젝트에 포함되어, xUnit 패키지가 없는 상태에서 `[Fact]` 특성을 인식하지 못했습니다.

**해결**:
HelloWorld.csproj에 Tests 폴더 제외 설정 추가:
```xml
<ItemGroup>
  <Compile Remove="Tests/**" />
</ItemGroup>
```

### 사례 2: xUnit using 문 누락

**문제**:
```
error CS0246: The type or namespace name 'Fact' could not be found
```

**원인**: GreeterTests.cs 파일에 `using Xunit;` 선언이 누락되어 xUnit의 `[Fact]` 특성을 인식하지 못했습니다.

**해결**:
GreeterTests.cs 파일 상단에 추가:
```csharp
using Xunit;
```

### 사례 3: CI/CD 최종 성공 (2026-01-08)

**상태**: ✅ 성공

**워크플로우 단계**:
1. Setup .NET 8.0 - 성공
2. Restore dependencies - 성공
3. Build HelloWorld.csproj - 성공
4. Build Tests/Tests.csproj - 성공
5. Test - 성공 (2개 테스트 통과)

**교훈**:
- 로컬에서 먼저 테스트 후 푸시할 것
- .NET 프로젝트 구조와 자동 파일 포함 규칙 이해 필요
- using 문은 필수

## 추가 학습 자료

- [.NET 공식 문서](https://docs.microsoft.com/dotnet/)
- [xUnit 문서](https://xunit.net/)
- [GitHub Actions for .NET](https://docs.github.com/actions/automating-builds-and-tests/building-and-testing-net)
