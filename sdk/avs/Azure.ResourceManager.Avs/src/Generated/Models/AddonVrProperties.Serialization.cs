// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AddonVrProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vrsCount");
            writer.WriteNumberValue(VrsCount);
            writer.WritePropertyName("addonType");
            writer.WriteStringValue(AddonType.ToString());
            writer.WriteEndObject();
        }

        internal static AddonVrProperties DeserializeAddonVrProperties(JsonElement element)
        {
            int vrsCount = default;
            AddonType addonType = default;
            Optional<AddonProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vrsCount"))
                {
                    vrsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("addonType"))
                {
                    addonType = new AddonType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new AddonProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new AddonVrProperties(addonType, Optional.ToNullable(provisioningState), vrsCount);
        }
    }
}
