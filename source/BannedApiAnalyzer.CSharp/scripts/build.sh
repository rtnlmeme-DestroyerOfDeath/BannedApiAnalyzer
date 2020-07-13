#!/bin/sh

cd /home/benj/repos/BannedApiAnalyzer/source/BannedApiAnalyzer.CSharp/ || exit 1
rm -rf output && \
rm -rf bin/Release/netstandard2.0 && \
msbuild -p:Configuration="Release" && \
cp -r bin/Release/netstandard2.0 output
