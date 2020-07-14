#!/bin/sh

cd /home/benj/repos/BannedApiAnalyzer/source/BannedApiAnalyzer.CSharp/ || exit 1
rm -rf output && \
rm -rf bin/Release/netstandard2.0 && \
msbuild -p:Configuration="Release" && \
cp -r bin/Release/netstandard2.0 output
rm -rf /home/benj/idlegame/RoslynAnalyzers/BestBannedAnalyzers/analyzers
cp -r bin/Release/netstandard2.0 /home/benj/idlegame/RoslynAnalyzers/BestBannedAnalyzers/analyzers
