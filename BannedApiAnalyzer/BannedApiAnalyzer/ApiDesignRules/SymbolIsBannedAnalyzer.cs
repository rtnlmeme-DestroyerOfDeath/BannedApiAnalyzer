﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT license. See LICENSE in the project root for license information.

namespace BannedApiAnalyzer.ApiDesignRules
{
    using Microsoft.CodeAnalysis;

    internal static class SymbolIsBannedAnalyzer
    {
        public const string BannedSymbolsFileName = "BannedSymbols.txt";

        // warn
        private const string BESTBAN01Identifier = "BESTBAN01";

        // error
        private const string BESTBAN02Identifier = "BESTBAN02";

        // info (suggestion in rider)
        private const string BESTBAN03Identifier = "BESTBAN03";

        private const string BESTBAN31Identifier = "BESTBAN31";

        public static DiagnosticDescriptor SymbolIsBannedRule { get; } = new DiagnosticDescriptor(
            id: BESTBAN01Identifier,
            title: ApiDesignResources.SymbolIsBannedTitle,
            messageFormat: ApiDesignResources.SymbolIsBannedMessage,
            category: AnalyzerCategory.ApiDesign,
            defaultSeverity: DiagnosticSeverity.Warning,
            isEnabledByDefault: AnalyzerConstants.EnabledByDefault,
            description: ApiDesignResources.SymbolIsBannedDescription,
            helpLinkUri: "https://github.com/DotNetAnalyzers/BannedApiAnalyzer/blob/master/docs/RS0030.md",
            customTags: WellKnownDiagnosticTags.Telemetry);


        public static DiagnosticDescriptor ErrorSymbolIsBannedRule { get; } = new DiagnosticDescriptor(
            id: BESTBAN02Identifier,
            title: ApiDesignResources.SymbolIsBannedTitle,
            messageFormat: ApiDesignResources.SymbolIsBannedMessage,
            category: AnalyzerCategory.ApiDesign,
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: AnalyzerConstants.EnabledByDefault,
            description: ApiDesignResources.SymbolIsBannedDescription,
            helpLinkUri: "https://github.com/DotNetAnalyzers/BannedApiAnalyzer/blob/master/docs/RS0030.md",
            customTags: WellKnownDiagnosticTags.Telemetry);

        public static DiagnosticDescriptor InfoSymbolIsBannedRule { get; } = new DiagnosticDescriptor(
            id: BESTBAN03Identifier,
            title: ApiDesignResources.SymbolIsBannedTitle,
            messageFormat: ApiDesignResources.SymbolIsBannedMessage,
            category: AnalyzerCategory.ApiDesign,
            defaultSeverity: DiagnosticSeverity.Info,
            isEnabledByDefault: AnalyzerConstants.EnabledByDefault,
            description: ApiDesignResources.SymbolIsBannedDescription,
            helpLinkUri: "https://github.com/DotNetAnalyzers/BannedApiAnalyzer/blob/master/docs/RS0030.md",
            customTags: WellKnownDiagnosticTags.Telemetry);

        public static DiagnosticDescriptor DuplicateBannedSymbolRule { get; } = new DiagnosticDescriptor(
            id: BESTBAN31Identifier,
            title: ApiDesignResources.DuplicateBannedSymbolTitle,
            messageFormat: ApiDesignResources.DuplicateBannedSymbolMessage,
            category: AnalyzerCategory.ApiDesign,
            defaultSeverity: DiagnosticSeverity.Info,
            isEnabledByDefault: AnalyzerConstants.EnabledByDefault,
            description: ApiDesignResources.DuplicateBannedSymbolDescription,
            helpLinkUri: "https://github.com/DotNetAnalyzers/BannedApiAnalyzer/blob/master/docs/RS0031.md",
            customTags: WellKnownDiagnosticTags.Telemetry);
    }
}
