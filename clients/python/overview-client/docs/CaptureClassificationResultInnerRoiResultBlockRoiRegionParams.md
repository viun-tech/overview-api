# CaptureClassificationResultInnerRoiResultBlockRoiRegionParams


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **str** | Name of the ROI region | [optional] 
**bbox** | **List[float]** | Bounding box coordinates [x, y, width, height] | [optional] 
**angle** | **float** |  | [optional] 

## Example

```python
from overview_client.models.capture_classification_result_inner_roi_result_block_roi_region_params import CaptureClassificationResultInnerRoiResultBlockRoiRegionParams

# TODO update the JSON string below
json = "{}"
# create an instance of CaptureClassificationResultInnerRoiResultBlockRoiRegionParams from a JSON string
capture_classification_result_inner_roi_result_block_roi_region_params_instance = CaptureClassificationResultInnerRoiResultBlockRoiRegionParams.from_json(json)
# print the JSON string representation of the object
print(CaptureClassificationResultInnerRoiResultBlockRoiRegionParams.to_json())

# convert the object into a dict
capture_classification_result_inner_roi_result_block_roi_region_params_dict = capture_classification_result_inner_roi_result_block_roi_region_params_instance.to_dict()
# create an instance of CaptureClassificationResultInnerRoiResultBlockRoiRegionParams from a dict
capture_classification_result_inner_roi_result_block_roi_region_params_from_dict = CaptureClassificationResultInnerRoiResultBlockRoiRegionParams.from_dict(capture_classification_result_inner_roi_result_block_roi_region_params_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


