# overview_client.RecipeApi

All URIs are relative to *http://192.168.0.100*

Method | HTTP request | Description
------------- | ------------- | -------------
[**activate_recipe_by_id**](RecipeApi.md#activate_recipe_by_id) | **POST** /edge/recipe/activate | Activate a recipe


# **activate_recipe_by_id**
> activate_recipe_by_id(recipe_id)

Activate a recipe

Activate a specific recipe for execution. Only one recipe switch can happen at a time, and only one recipe can be activated at a time.

### Example


```python
import overview_client
from overview_client.models.recipe_id import RecipeId
from overview_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to http://192.168.0.100
# See configuration.py for a list of all supported configuration parameters.
configuration = overview_client.Configuration(
    host = "http://192.168.0.100"
)


# Enter a context with an instance of the API client
with overview_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = overview_client.RecipeApi(api_client)
    recipe_id = overview_client.RecipeId() # RecipeId | 

    try:
        # Activate a recipe
        api_instance.activate_recipe_by_id(recipe_id)
    except Exception as e:
        print("Exception when calling RecipeApi->activate_recipe_by_id: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipe_id** | [**RecipeId**](RecipeId.md)|  | 

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
**200** | Recipe successfully activated |  -  |
**400** | Invalid request body |  -  |
**408** | Recipe switch request timed out |  -  |
**429** | A recipe switch is currently in progress |  -  |
**500** | Recipe switch failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

