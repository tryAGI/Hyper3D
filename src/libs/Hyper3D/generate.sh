#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from https://developer.hyper3d.ai/llms.txt

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Hyper3D \
  --clientClassName Hyper3DClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
