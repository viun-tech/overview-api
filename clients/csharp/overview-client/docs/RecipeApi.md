# overview_client.Api.RecipeApi

All URIs are relative to *http://192.168.0.100*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateRecipeById**](RecipeApi.md#activaterecipebyid) | **POST** /edge/recipe/activate | Activate a recipe |

<a id="activaterecipebyid"></a>
# **ActivateRecipeById**
> void ActivateRecipeById (RecipeId recipeId)

Activate a recipe

Activate a specific recipe for execution. Only one recipe switch can happen at a time, and only one recipe can be activated at a time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using overview_client.Api;
using overview_client.Client;
using overview_client.Model;

namespace Example
{
    public class ActivateRecipeByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://192.168.0.100";
            var apiInstance = new RecipeApi(config);
            var recipeId = new RecipeId(); // RecipeId | 

            try
            {
                // Activate a recipe
                apiInstance.ActivateRecipeById(recipeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipeApi.ActivateRecipeById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateRecipeByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate a recipe
    apiInstance.ActivateRecipeByIdWithHttpInfo(recipeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecipeApi.ActivateRecipeByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipeId** | [**RecipeId**](RecipeId.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Recipe successfully activated |  -  |
| **400** | Invalid request body |  -  |
| **408** | Recipe switch request timed out |  -  |
| **429** | A recipe switch is currently in progress |  -  |
| **500** | Recipe switch failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

