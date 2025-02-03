# RecipeId


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **int** | ID of the recipe available (Not the PLC ID, [more info](https://docs.overview.ai/docs/recipe-change-using-http)) | [optional] 

## Example

```python
from overview_client.models.recipe_id import RecipeId

# TODO update the JSON string below
json = "{}"
# create an instance of RecipeId from a JSON string
recipe_id_instance = RecipeId.from_json(json)
# print the JSON string representation of the object
print(RecipeId.to_json())

# convert the object into a dict
recipe_id_dict = recipe_id_instance.to_dict()
# create an instance of RecipeId from a dict
recipe_id_from_dict = RecipeId.from_dict(recipe_id_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


