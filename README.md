# 자전거 대여 서비스에 사용할 백엔드 API 서버와 .NET Aspire!

<!--
이 README 파일에 아래 내용을 포함시켜주세요.

- 워크샵 소개
- 워크샵 목표
- 워크샵 사전 준비사항
- 워크샵 진행 방법
- 추가 참고 자료
-->

가상의 자전거 대여 시스템의 백엔드 시스템을 .NET9을 이용해 만들어봅니다. 여기에 필요한 기본 사양과 스펙을 기획하고 이를 코드로 옮겨봅니다. 그리고 .NET Aspire와 만들어 둔 백엔드를 연결하고 이를 Azure Container Apps로 배포까지 진행해봅니다.


## 워크샵 목표

* 가상의 자전거 대여 시스템 중 백엔드 부분을 ASP.NET Core로 구성해보기
* 백엔드 API를 OpenAPI 문서로 만들어보기
* .NET Aspire를 프로젝트에 결합해보기
* Azure 클라우드에 .NET Aspire 프로젝트 배포해보기


## 워크샵 사전 준비사항

- [.NET SDK 9](https://dotnet.microsoft.com/download/dotnet/9.0) 설치
- [Powershell 7](https://learn.microsoft.com/powershell/scripting/install/installing-powershell) 설치
- [GIT CLI](https://git-scm.com/downloads) 설치
- [Azure Developer CLI](https://learn.microsoft.com/ko-kr/azure/developer/azure-developer-cli/install-azd) 설치(Azure CLI 아님 주의!)
- [Docker Desktop](https://docs.docker.com/get-started/introduction/get-docker-desktop/) 설치
- [Visual Studio Code](https://code.visualstudio.com/) 설치


## 워크샵 진행 방법

- 아래 단계별로 워크샵을 진행합니다. 각 단계별로 자기주도형 학습을 하며, 단계별 시작 전 진행자가 간단한 안내 후 시작합니다.

  | 순서                         | 제목                                           |
  |------------------------------|------------------------------------------------|
  | [STEP 00](./docs/step-00.md) | 개발 환경 설정하기                             |
  | [STEP 01](./docs/step-01.md) | Dockerfile 및 Docker Compose 파일 생성하기     |
  | [STEP 02](./docs/step-02.md) | Testcontainers로 API 테스트하기                |
  | [STEP 03](./docs/step-03.md) | Testcontainers로 통합 테스트하기               |
  | [STEP 04](./docs/step-04.md) | .NET Aspire로 컨테이너 오케스트레이션하기      |
  | [STEP 05](./docs/step-05.md) | .NET Aspire로 통합 테스트하기                  |

- 각 단계별 중간 결과물은 [세이브 포인트](./save-points)에서 확인할 수 있습니다.


## 추가 참고 자료

*추가로 참고할만한 자료가 있다면 작성해주세요.*

---

*아래는 다 작성하신 후 삭제하시면 됩니다*

## 리포지토리 구조

- [`.devcontainer`](./.devcontainer): 워크샵을 위한 개발 환경을 설정합니다.
  - [GitHub Codespaces](https://github.com/features/codespaces) 또는 [Visual Studio Code Dev Containers](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)를 사용할 때 필요합니다.
  - 더 자세한 내용은 [DevContainers](https://containers.dev)를 참조하세요.
- [`docs`](./docs): 워크샵 진행에 필요한 문서를 저장합니다.
- [`save-points`](./save-points): 워크샵 진행 중 중간 결과물을 저장합니다.
