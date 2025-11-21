# Devcontainer image for .NET 8 development
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Create a non-root user (vscode) to match devcontainers convention
ARG USERNAME=vscode
ARG USER_UID=1000
ARG USER_GID=1000

RUN groupadd --gid $USER_GID $USERNAME \
    && useradd -s /bin/bash --uid $USER_UID --gid $USER_GID -m $USERNAME

# Basic tooling
RUN apt-get update && \
    apt-get install -y --no-install-recommends \
        curl \
        git \
        zsh \
    && rm -rf /var/lib/apt/lists/*

USER $USERNAME
WORKDIR /workspaces

# Default shell
SHELL ["/bin/bash", "-c"]
