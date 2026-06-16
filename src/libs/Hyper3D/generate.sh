#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained from https://developer.hyper3d.ai/llms.txt
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Hyper3D \
  --clientClassName Hyper3DClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
