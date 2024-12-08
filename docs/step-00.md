# STEP 00: 개발 환경 설정하기

이 단계에서는 워크샵 진행을 위해 필요한 개발 환경을 설정합니다.

## 사전 준비 사항

- [.NET SDK 9](https://dotnet.microsoft.com/download/dotnet/9.0) 설치
- [Powershell 7](https://learn.microsoft.com/powershell/scripting/install/installing-powershell) 설치
- [GIT CLI](https://git-scm.com/downloads) 설치
- [Azure Developer CLI](https://learn.microsoft.com/ko-kr/azure/developer/azure-developer-cli/install-azd) 설치(Azure CLI 아님 주의!)
- [Docker Desktop](https://docs.docker.com/get-started/introduction/get-docker-desktop/) 설치
- [Visual Studio Code](https://code.visualstudio.com/) 설치

## .NET SDK 설치 확인

1. 터미널에서 아래 명령어를 실행시켜 현재 .NET SDK를 설치했는지 확인합니다.

    ```bash
    dotnet --list-sdks
    ```

   해당 명령을 실행할 수 없다면 [.NET SDK 설치 페이지](https://dotnet.microsoft.com/download/dotnet/9.0)에서 최신 버전을 다운로드 받아 설치합니다.

   이번 워크샵에서는 `9.0.100` 이상의 버전이 필요하며 현재 최신 버전은 `9.0.101` 입니다.

1. 아래 명령어를 실행시켜 로컬머신 개발용 HTTPS 인증서를 설치합니다.

    ```bash
    dotnet dev-certs https --trust
    ```

    만약 오류가 발생했다면 다음 명령어를 입력하여 워크로드를 최신화합니다.

    ```bash
    # Windows
    dotnet workload update
    ```

    ```bash
    # Linux or macOS
    sudo dotnet workload update
    ```

1. 아래 명령어를 실행시켜 .NET Aspire 프로젝트 템플릿을 최신으로 업데이트합니다.

    ```bash
    dotnet new install Aspire.ProjectTemplates --force
    ```

## Powershell 설치 확인

1. 터미널에서 아래 명령어를 실행시켜 현재 Powershell을 설치했는지 확인합니다.

    ```bash
    pwsh --version
    ```

    해당 명령을 실행할 수 없다면 [Powershell 설치 페이지](https://learn.microsoft.com/powershell/scripting/install/installing-powershell)에서 최신 버전을 다운로드 받아 설치합니다.

    이번 워크샵에서는 `7.4.0` 이상 버전이 필요하며 현재 최신 버전은 `7.4.6` 입니다.

    > Q: 저는 맥 유저입니다. 꼭 파워쉘을 설치해야 할까요?

    > A: 파워쉘이 윈도우즈, 맥, 리눅스 모두를 지원하기에 본 워크샵에서는 파워쉘을 기준으로 설명합니다만 스크립트를 작성하지는 않기 때문에 굳이 설치하지 않아도 됩니다.

## GIT CLI 설치 확인

1. 터미널에서 아래 명령어를 실행시켜 현재 GIT CLI를 설치했는지 확인합니다.

    ```bash
    git --version
    ```

   해당 명령을 실행할 수 없다면 [git CLI 설치 페이지](https://git-scm.com/downloads)에서 최신 버전을 다운로드 받아 설치합니다.

## Azure Developer CLI 설치 확인

1. 터미널에서 아래 명령어를 실행시켜 현재 Azure Developer CLI를 설치했는지 확인합니다.

    ```bash
    azd version
    ```

   해당 명령을 실행할 수 없다면 [Azure Developer CLI 설치 페이지](https://learn.microsoft.com/ko-kr/azure/developer/azure-developer-cli/install-azd)에서 최신 버전을 다운로드 받아 설치합니다.

## Docker Desktop 설치 확인

1. 터미널에서 아래 명령어를 실행시켜 현재 Docker Desktop을 설치했는지 확인합니다.

    ```bash
    docker --version
    ```

   해당 명령을 실행할 수 없다면 [Docker Desktop 설치 페이지](https://docs.docker.com/get-started/introduction/get-docker-desktop/)에서 최신 버전을 다운로드 받아 설치합니다.

## Visual Studio Code 설치 확인

1. 터미널에서 아래 명령어를 실행시켜 현재 Visual Studio Code를 설치했는지 확인합니다.

    ```bash
    code --version
    ```

   해당 명령을 실행할 수 없다면 [Visual Studio Code 설치 페이지](https://code.visualstudio.com/)에서 최신 버전을 다운로드 받아 설치합니다.

   > 만약 터미널에서 `code` 명령어를 실행시킬 수 없다면, [이 문서](https://code.visualstudio.com/docs/setup/mac#_launching-from-the-command-line)를 참고하여 설정합니다.

## Visual Studio Code 확장 설치

1. [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)를 설치합니다.
1. [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client)

---

이제 본격적으로 시작해볼까요?! [Let's go!](./step-01.md)