# overview_client.Api.CaptureApi

All URIs are relative to *http://192.168.0.100*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCaptures**](CaptureApi.md#getcaptures) | **GET** /postgrest/captures | Get 1 or more captures according to specific parameters |

<a id="getcaptures"></a>
# **GetCaptures**
> List&lt;Capture&gt; GetCaptures (int? limit = null, string? order = null, string? select = null)

Get 1 or more captures according to specific parameters

Get captures according to specific parameters. Keep the default parameters to get the last capture. Only support classification recipe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using overview_client.Api;
using overview_client.Client;
using overview_client.Model;

namespace Example
{
    public class GetCapturesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://192.168.0.100";
            var apiInstance = new CaptureApi(config);
            var limit = 1;  // int? | Maximum number of captures to return (optional)  (default to 1)
            var order = "captured_at.asc";  // string? | Order of returned captures (optional)  (default to captured_at.desc)
            var select = "\"id,captured_at,source_recipe_id,path,height,width,size,classification_result(created_at,confidence,block_classification_classes(label_name,block_roi_inspection_type_params(name)),roi_result(block_roi_region_params(name,bbox,angle)))\"";  // string? | Fields to include in the response (optional)  (default to "id,captured_at,source_recipe_id,path,height,width,size,classification_result(created_at,confidence,block_classification_classes(label_name,block_roi_inspection_type_params(name)),roi_result(block_roi_region_params(name,bbox,angle)))")

            try
            {
                // Get 1 or more captures according to specific parameters
                List<Capture> result = apiInstance.GetCaptures(limit, order, select);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptureApi.GetCaptures: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCapturesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get 1 or more captures according to specific parameters
    ApiResponse<List<Capture>> response = apiInstance.GetCapturesWithHttpInfo(limit, order, select);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CaptureApi.GetCapturesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Maximum number of captures to return | [optional] [default to 1] |
| **order** | **string?** | Order of returned captures | [optional] [default to captured_at.desc] |
| **select** | **string?** | Fields to include in the response | [optional] [default to &quot;id,captured_at,source_recipe_id,path,height,width,size,classification_result(created_at,confidence,block_classification_classes(label_name,block_roi_inspection_type_params(name)),roi_result(block_roi_region_params(name,bbox,angle)))&quot;] |

### Return type

[**List&lt;Capture&gt;**](Capture.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved captures. Only support classification recipe. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

