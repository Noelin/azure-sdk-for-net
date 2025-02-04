// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class RestorableMongodbDatabase
    {
        internal static RestorableMongodbDatabase DeserializeRestorableMongodbDatabase(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<RestorableMongodbDatabasePropertiesResource> resource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("resource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resource = RestorableMongodbDatabasePropertiesResource.DeserializeRestorableMongodbDatabasePropertiesResource(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RestorableMongodbDatabase(id, name, type, systemData.Value, resource.Value);
        }
    }
}
