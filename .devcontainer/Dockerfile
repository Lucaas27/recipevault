# Note: You can use any Debian/Ubuntu based image you want.
FROM mcr.microsoft.com/devcontainers/base:bullseye

# [Optional] Uncomment this section to install additional OS packages.
# RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
#     && apt-get -y install --no-install-recommends <your-package-list-here>

# Install Python and pip
RUN sudo apt-get update && \
    sudo apt-get install -y python3 python3-pip && \
    sudo pip3 install pre-commit