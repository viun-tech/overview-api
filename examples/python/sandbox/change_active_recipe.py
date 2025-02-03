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
    api_instance = overview_client.RecipeApi(api_client)
    recipe_id = overview_client.RecipeId(id=1) # RecipeId | 

    try:
        # Activate a recipe
        api_response = api_instance.activate_recipe_by_id(recipe_id)
        print("The response of RecipeApi->activate_recipe_by_id:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling RecipeApi->activate_recipe_by_id: %s\n" % e)
