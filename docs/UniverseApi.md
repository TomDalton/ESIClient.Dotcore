# IO.Swagger.Api.UniverseApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUniverseAncestries**](UniverseApi.md#getuniverseancestries) | **GET** /v1/universe/ancestries/ | Get ancestries
[**GetUniverseBloodlines**](UniverseApi.md#getuniversebloodlines) | **GET** /v1/universe/bloodlines/ | Get bloodlines
[**GetUniverseCategories**](UniverseApi.md#getuniversecategories) | **GET** /v1/universe/categories/ | Get item categories
[**GetUniverseCategoriesCategoryId**](UniverseApi.md#getuniversecategoriescategoryid) | **GET** /v1/universe/categories/{category_id}/ | Get item category information
[**GetUniverseConstellations**](UniverseApi.md#getuniverseconstellations) | **GET** /v1/universe/constellations/ | Get constellations
[**GetUniverseConstellationsConstellationId**](UniverseApi.md#getuniverseconstellationsconstellationid) | **GET** /v1/universe/constellations/{constellation_id}/ | Get constellation information
[**GetUniverseFactions**](UniverseApi.md#getuniversefactions) | **GET** /v2/universe/factions/ | Get factions
[**GetUniverseGraphics**](UniverseApi.md#getuniversegraphics) | **GET** /v1/universe/graphics/ | Get graphics
[**GetUniverseGraphicsGraphicId**](UniverseApi.md#getuniversegraphicsgraphicid) | **GET** /v1/universe/graphics/{graphic_id}/ | Get graphic information
[**GetUniverseGroups**](UniverseApi.md#getuniversegroups) | **GET** /v1/universe/groups/ | Get item groups
[**GetUniverseGroupsGroupId**](UniverseApi.md#getuniversegroupsgroupid) | **GET** /v1/universe/groups/{group_id}/ | Get item group information
[**GetUniverseMoonsMoonId**](UniverseApi.md#getuniversemoonsmoonid) | **GET** /v1/universe/moons/{moon_id}/ | Get moon information
[**GetUniversePlanetsPlanetId**](UniverseApi.md#getuniverseplanetsplanetid) | **GET** /v1/universe/planets/{planet_id}/ | Get planet information
[**GetUniverseRaces**](UniverseApi.md#getuniverseraces) | **GET** /v1/universe/races/ | Get character races
[**GetUniverseRegions**](UniverseApi.md#getuniverseregions) | **GET** /v1/universe/regions/ | Get regions
[**GetUniverseRegionsRegionId**](UniverseApi.md#getuniverseregionsregionid) | **GET** /v1/universe/regions/{region_id}/ | Get region information
[**GetUniverseStargatesStargateId**](UniverseApi.md#getuniversestargatesstargateid) | **GET** /v1/universe/stargates/{stargate_id}/ | Get stargate information
[**GetUniverseStarsStarId**](UniverseApi.md#getuniversestarsstarid) | **GET** /v1/universe/stars/{star_id}/ | Get star information
[**GetUniverseStationsStationId**](UniverseApi.md#getuniversestationsstationid) | **GET** /v2/universe/stations/{station_id}/ | Get station information
[**GetUniverseStructures**](UniverseApi.md#getuniversestructures) | **GET** /v1/universe/structures/ | List all public structures
[**GetUniverseStructuresStructureId**](UniverseApi.md#getuniversestructuresstructureid) | **GET** /v1/universe/structures/{structure_id}/ | Get structure information
[**GetUniverseSystemJumps**](UniverseApi.md#getuniversesystemjumps) | **GET** /v1/universe/system_jumps/ | Get system jumps
[**GetUniverseSystemKills**](UniverseApi.md#getuniversesystemkills) | **GET** /v2/universe/system_kills/ | Get system kills
[**GetUniverseSystems**](UniverseApi.md#getuniversesystems) | **GET** /v1/universe/systems/ | Get solar systems
[**GetUniverseSystemsSystemId**](UniverseApi.md#getuniversesystemssystemid) | **GET** /v3/universe/systems/{system_id}/ | Get solar system information
[**GetUniverseTypes**](UniverseApi.md#getuniversetypes) | **GET** /v1/universe/types/ | Get types
[**GetUniverseTypesTypeId**](UniverseApi.md#getuniversetypestypeid) | **GET** /v3/universe/types/{type_id}/ | Get type information
[**PostUniverseIds**](UniverseApi.md#postuniverseids) | **POST** /v1/universe/ids/ | Bulk names to IDs
[**PostUniverseNames**](UniverseApi.md#postuniversenames) | **POST** /v2/universe/names/ | Get names and categories for a set of ID&#39;s


<a name="getuniverseancestries"></a>
# **GetUniverseAncestries**
> List<GetUniverseAncestries200Ok> GetUniverseAncestries (string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get ancestries

Get all character ancestries  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseAncestriesExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get ancestries
                List&lt;GetUniverseAncestries200Ok&gt; result = apiInstance.GetUniverseAncestries(datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseAncestries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetUniverseAncestries200Ok>**](GetUniverseAncestries200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversebloodlines"></a>
# **GetUniverseBloodlines**
> List<GetUniverseBloodlines200Ok> GetUniverseBloodlines (string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get bloodlines

Get a list of bloodlines  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseBloodlinesExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get bloodlines
                List&lt;GetUniverseBloodlines200Ok&gt; result = apiInstance.GetUniverseBloodlines(datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseBloodlines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetUniverseBloodlines200Ok>**](GetUniverseBloodlines200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversecategories"></a>
# **GetUniverseCategories**
> List<int?> GetUniverseCategories (string datasource = null, string userAgent = null, string xUserAgent = null)

Get item categories

Get a list of item categories  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseCategoriesExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get item categories
                List&lt;int?&gt; result = apiInstance.GetUniverseCategories(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversecategoriescategoryid"></a>
# **GetUniverseCategoriesCategoryId**
> GetUniverseCategoriesCategoryIdOk GetUniverseCategoriesCategoryId (int? categoryId, string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get item category information

Get information of an item category  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseCategoriesCategoryIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var categoryId = 56;  // int? | An Eve item category ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get item category information
                GetUniverseCategoriesCategoryIdOk result = apiInstance.GetUniverseCategoriesCategoryId(categoryId, datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseCategoriesCategoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **int?**| An Eve item category ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseCategoriesCategoryIdOk**](GetUniverseCategoriesCategoryIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniverseconstellations"></a>
# **GetUniverseConstellations**
> List<int?> GetUniverseConstellations (string datasource = null, string userAgent = null, string xUserAgent = null)

Get constellations

Get a list of constellations  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseConstellationsExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get constellations
                List&lt;int?&gt; result = apiInstance.GetUniverseConstellations(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseConstellations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniverseconstellationsconstellationid"></a>
# **GetUniverseConstellationsConstellationId**
> GetUniverseConstellationsConstellationIdOk GetUniverseConstellationsConstellationId (int? constellationId, string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get constellation information

Get information on a constellation  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseConstellationsConstellationIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var constellationId = 56;  // int? | constellation_id integer
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get constellation information
                GetUniverseConstellationsConstellationIdOk result = apiInstance.GetUniverseConstellationsConstellationId(constellationId, datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseConstellationsConstellationId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **constellationId** | **int?**| constellation_id integer | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseConstellationsConstellationIdOk**](GetUniverseConstellationsConstellationIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversefactions"></a>
# **GetUniverseFactions**
> List<GetUniverseFactions200Ok> GetUniverseFactions (string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get factions

Get a list of factions  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseFactionsExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get factions
                List&lt;GetUniverseFactions200Ok&gt; result = apiInstance.GetUniverseFactions(datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseFactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetUniverseFactions200Ok>**](GetUniverseFactions200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversegraphics"></a>
# **GetUniverseGraphics**
> List<int?> GetUniverseGraphics (string datasource = null, string userAgent = null, string xUserAgent = null)

Get graphics

Get a list of graphics  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseGraphicsExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get graphics
                List&lt;int?&gt; result = apiInstance.GetUniverseGraphics(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseGraphics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversegraphicsgraphicid"></a>
# **GetUniverseGraphicsGraphicId**
> GetUniverseGraphicsGraphicIdOk GetUniverseGraphicsGraphicId (int? graphicId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get graphic information

Get information on a graphic  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseGraphicsGraphicIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var graphicId = 56;  // int? | graphic_id integer
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get graphic information
                GetUniverseGraphicsGraphicIdOk result = apiInstance.GetUniverseGraphicsGraphicId(graphicId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseGraphicsGraphicId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **graphicId** | **int?**| graphic_id integer | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseGraphicsGraphicIdOk**](GetUniverseGraphicsGraphicIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversegroups"></a>
# **GetUniverseGroups**
> List<int?> GetUniverseGroups (string datasource = null, int? page = null, string userAgent = null, string xUserAgent = null)

Get item groups

Get a list of item groups  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseGroupsExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get item groups
                List&lt;int?&gt; result = apiInstance.GetUniverseGroups(datasource, page, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversegroupsgroupid"></a>
# **GetUniverseGroupsGroupId**
> GetUniverseGroupsGroupIdOk GetUniverseGroupsGroupId (int? groupId, string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get item group information

Get information on an item group  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseGroupsGroupIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var groupId = 56;  // int? | An Eve item group ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get item group information
                GetUniverseGroupsGroupIdOk result = apiInstance.GetUniverseGroupsGroupId(groupId, datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseGroupsGroupId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **int?**| An Eve item group ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseGroupsGroupIdOk**](GetUniverseGroupsGroupIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversemoonsmoonid"></a>
# **GetUniverseMoonsMoonId**
> GetUniverseMoonsMoonIdOk GetUniverseMoonsMoonId (int? moonId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get moon information

Get information on a moon  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseMoonsMoonIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var moonId = 56;  // int? | moon_id integer
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get moon information
                GetUniverseMoonsMoonIdOk result = apiInstance.GetUniverseMoonsMoonId(moonId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseMoonsMoonId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **moonId** | **int?**| moon_id integer | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseMoonsMoonIdOk**](GetUniverseMoonsMoonIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniverseplanetsplanetid"></a>
# **GetUniversePlanetsPlanetId**
> GetUniversePlanetsPlanetIdOk GetUniversePlanetsPlanetId (int? planetId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get planet information

Get information on a planet  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniversePlanetsPlanetIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var planetId = 56;  // int? | planet_id integer
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get planet information
                GetUniversePlanetsPlanetIdOk result = apiInstance.GetUniversePlanetsPlanetId(planetId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniversePlanetsPlanetId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **planetId** | **int?**| planet_id integer | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniversePlanetsPlanetIdOk**](GetUniversePlanetsPlanetIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniverseraces"></a>
# **GetUniverseRaces**
> List<GetUniverseRaces200Ok> GetUniverseRaces (string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get character races

Get a list of character races  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseRacesExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get character races
                List&lt;GetUniverseRaces200Ok&gt; result = apiInstance.GetUniverseRaces(datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseRaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetUniverseRaces200Ok>**](GetUniverseRaces200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniverseregions"></a>
# **GetUniverseRegions**
> List<int?> GetUniverseRegions (string datasource = null, string userAgent = null, string xUserAgent = null)

Get regions

Get a list of regions  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseRegionsExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get regions
                List&lt;int?&gt; result = apiInstance.GetUniverseRegions(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseRegions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniverseregionsregionid"></a>
# **GetUniverseRegionsRegionId**
> GetUniverseRegionsRegionIdOk GetUniverseRegionsRegionId (int? regionId, string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get region information

Get information on a region  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseRegionsRegionIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var regionId = 56;  // int? | region_id integer
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get region information
                GetUniverseRegionsRegionIdOk result = apiInstance.GetUniverseRegionsRegionId(regionId, datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseRegionsRegionId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regionId** | **int?**| region_id integer | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseRegionsRegionIdOk**](GetUniverseRegionsRegionIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversestargatesstargateid"></a>
# **GetUniverseStargatesStargateId**
> GetUniverseStargatesStargateIdOk GetUniverseStargatesStargateId (int? stargateId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get stargate information

Get information on a stargate  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseStargatesStargateIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var stargateId = 56;  // int? | stargate_id integer
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get stargate information
                GetUniverseStargatesStargateIdOk result = apiInstance.GetUniverseStargatesStargateId(stargateId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseStargatesStargateId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stargateId** | **int?**| stargate_id integer | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseStargatesStargateIdOk**](GetUniverseStargatesStargateIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversestarsstarid"></a>
# **GetUniverseStarsStarId**
> GetUniverseStarsStarIdOk GetUniverseStarsStarId (int? starId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get star information

Get information on a star  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseStarsStarIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var starId = 56;  // int? | star_id integer
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get star information
                GetUniverseStarsStarIdOk result = apiInstance.GetUniverseStarsStarId(starId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseStarsStarId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starId** | **int?**| star_id integer | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseStarsStarIdOk**](GetUniverseStarsStarIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversestationsstationid"></a>
# **GetUniverseStationsStationId**
> GetUniverseStationsStationIdOk GetUniverseStationsStationId (int? stationId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get station information

Get information on a station  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseStationsStationIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var stationId = 56;  // int? | station_id integer
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get station information
                GetUniverseStationsStationIdOk result = apiInstance.GetUniverseStationsStationId(stationId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseStationsStationId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **int?**| station_id integer | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseStationsStationIdOk**](GetUniverseStationsStationIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversestructures"></a>
# **GetUniverseStructures**
> List<long?> GetUniverseStructures (string datasource = null, string userAgent = null, string xUserAgent = null)

List all public structures

List all public structures  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseStructuresExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List all public structures
                List&lt;long?&gt; result = apiInstance.GetUniverseStructures(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseStructures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<long?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversestructuresstructureid"></a>
# **GetUniverseStructuresStructureId**
> GetUniverseStructuresStructureIdOk GetUniverseStructuresStructureId (long? structureId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get structure information

Returns information on requested structure, if you are on the ACL. Otherwise, returns \"Forbidden\" for all inputs.  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseStructuresStructureIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UniverseApi();
            var structureId = 789;  // long? | An Eve structure ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get structure information
                GetUniverseStructuresStructureIdOk result = apiInstance.GetUniverseStructuresStructureId(structureId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseStructuresStructureId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **structureId** | **long?**| An Eve structure ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseStructuresStructureIdOk**](GetUniverseStructuresStructureIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversesystemjumps"></a>
# **GetUniverseSystemJumps**
> List<GetUniverseSystemJumps200Ok> GetUniverseSystemJumps (string datasource = null, string userAgent = null, string xUserAgent = null)

Get system jumps

Get the number of jumps in solar systems within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with jumps will be listed  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseSystemJumpsExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get system jumps
                List&lt;GetUniverseSystemJumps200Ok&gt; result = apiInstance.GetUniverseSystemJumps(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseSystemJumps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetUniverseSystemJumps200Ok>**](GetUniverseSystemJumps200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversesystemkills"></a>
# **GetUniverseSystemKills**
> List<GetUniverseSystemKills200Ok> GetUniverseSystemKills (string datasource = null, string userAgent = null, string xUserAgent = null)

Get system kills

Get the number of ship, pod and NPC kills per solar system within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with kills will be listed  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseSystemKillsExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get system kills
                List&lt;GetUniverseSystemKills200Ok&gt; result = apiInstance.GetUniverseSystemKills(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseSystemKills: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetUniverseSystemKills200Ok>**](GetUniverseSystemKills200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversesystems"></a>
# **GetUniverseSystems**
> List<int?> GetUniverseSystems (string datasource = null, string userAgent = null, string xUserAgent = null)

Get solar systems

Get a list of solar systems  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseSystemsExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get solar systems
                List&lt;int?&gt; result = apiInstance.GetUniverseSystems(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseSystems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversesystemssystemid"></a>
# **GetUniverseSystemsSystemId**
> GetUniverseSystemsSystemIdOk GetUniverseSystemsSystemId (int? systemId, string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get solar system information

Get information on a solar system  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseSystemsSystemIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var systemId = 56;  // int? | system_id integer
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get solar system information
                GetUniverseSystemsSystemIdOk result = apiInstance.GetUniverseSystemsSystemId(systemId, datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseSystemsSystemId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemId** | **int?**| system_id integer | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseSystemsSystemIdOk**](GetUniverseSystemsSystemIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversetypes"></a>
# **GetUniverseTypes**
> List<int?> GetUniverseTypes (string datasource = null, int? page = null, string userAgent = null, string xUserAgent = null)

Get types

Get a list of type ids  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseTypesExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get types
                List&lt;int?&gt; result = apiInstance.GetUniverseTypes(datasource, page, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversetypestypeid"></a>
# **GetUniverseTypesTypeId**
> GetUniverseTypesTypeIdOk GetUniverseTypesTypeId (int? typeId, string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Get type information

Get information on a type  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseTypesTypeIdExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var typeId = 56;  // int? | An Eve item type ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get type information
                GetUniverseTypesTypeIdOk result = apiInstance.GetUniverseTypesTypeId(typeId, datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseTypesTypeId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | **int?**| An Eve item type ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseTypesTypeIdOk**](GetUniverseTypesTypeIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuniverseids"></a>
# **PostUniverseIds**
> PostUniverseIdsOk PostUniverseIds (List<string> names, string datasource = null, string language = null, string userAgent = null, string xUserAgent = null)

Bulk names to IDs

Resolve a set of names to IDs in the following categories: agents, alliances, characters, constellations, corporations factions, inventory_types, regions, stations, and systems. Only exact matches will be returned. All names searched for are cached for 12 hours.  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUniverseIdsExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var names = ;  // List<string> | The names to resolve
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Bulk names to IDs
                PostUniverseIdsOk result = apiInstance.PostUniverseIds(names, datasource, language, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.PostUniverseIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **names** | **List&lt;string&gt;**| The names to resolve | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**PostUniverseIdsOk**](PostUniverseIdsOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuniversenames"></a>
# **PostUniverseNames**
> List<PostUniverseNames200Ok> PostUniverseNames (List<int?> ids, string datasource = null, string userAgent = null, string xUserAgent = null)

Get names and categories for a set of ID's

Resolve a set of IDs to names and categories. Supported ID's for resolving are: Characters, Corporations, Alliances, Stations, Solar Systems, Constellations, Regions, Types.  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUniverseNamesExample
    {
        public void main()
        {
            var apiInstance = new UniverseApi();
            var ids = ;  // List<int?> | The ids to resolve
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get names and categories for a set of ID's
                List&lt;PostUniverseNames200Ok&gt; result = apiInstance.PostUniverseNames(ids, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.PostUniverseNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | **List&lt;int?&gt;**| The ids to resolve | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<PostUniverseNames200Ok>**](PostUniverseNames200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
