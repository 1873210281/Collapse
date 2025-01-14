﻿using CollapseLauncher.Interfaces;
using Hi3Helper.Shared.ClassStruct;
using System.Text.Json.Serialization;

namespace CollapseLauncher
{
    [JsonSourceGenerationOptions(IncludeFields = false, GenerationMode = JsonSourceGenerationMode.Metadata, IgnoreReadOnlyFields = true, WriteIndented = false)]
    [JsonSerializable(typeof(AppUpdateVersionProp))]
    internal partial class AppUpdateVersionPropContext : JsonSerializerContext { }

    [JsonSourceGenerationOptions(IncludeFields = false, GenerationMode = JsonSourceGenerationMode.Metadata, IgnoreReadOnlyFields = true, WriteIndented = false)]
    [JsonSerializable(typeof(NotificationPush))]
    internal partial class NotificationPushContext : JsonSerializerContext { }

    [JsonSourceGenerationOptions(IncludeFields = false, GenerationMode = JsonSourceGenerationMode.Metadata, IgnoreReadOnlyFields = true, WriteIndented = false)]
    [JsonSerializable(typeof(CacheAsset))]
    internal partial class CacheAssetContext : JsonSerializerContext { }
}
