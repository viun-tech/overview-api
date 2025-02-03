import overview_client
from overview_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to http://192.168.1.101
# See configuration.py for a list of all supported configuration parameters.
configuration = overview_client.Configuration(
    host = "http://192.168.0.100"
)

# Enter a context with an instance of the API client
with overview_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = overview_client.CaptureApi(api_client)
    limit = 1 # int | Maximum number of captures to return (optional) (default to 1)
    order = "captured_at.desc" # str | Order of returned captures (optional) (default to captured_at.desc)
    select = 'id,captured_at,source_recipe_id,path,height,width,size,classification_result(created_at,confidence,block_classification_classes(label_name,block_roi_inspection_type_params(name)),roi_result(block_roi_region_params(name,bbox,angle)))' # str | Fields to include in the response (optional) (default to 'id,captured_at,source_recipe_id,path,height,width,size,classification_result(created_at,confidence,block_classification_classes(label_name,block_roi_inspection_type_params(name)),roi_result(block_roi_region_params(name,bbox,angle)))')

    try:
        # Get 1 or more captures according to specific parameters
        api_response = api_instance.get_captures(limit=limit, order=order, select=select)
        print("The response of CaptureApi->get_captures:\n")
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling CaptureApi->get_captures: %s\n" % e)
