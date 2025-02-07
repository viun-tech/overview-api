# Overview API
API Specification and Clients to work with Overview Inc. Smart AI Camera.

To use this API specification your device needs to run on firware `2024.23.1` or higher.

## Development
You can run a local server to test in realtime the modifications you are making in the API specifications.

1. Add the IP of your device to easily test your changes from the Swagger UI:
```yaml
servers:
  - url: <URL_of_your_device>
    description: Local development device
```

2. Run the following docker from the root of this repo
```bash
docker run -p 8080:8080 -e SWAGGER_JSON=/overview.yaml -v $(pwd)/overview.yaml:/overview.yaml swaggerapi/swagger-ui
```

3. Open your webbrowser to the URL [http://localhost:8080](http://localhost:8080)

If you need specific files to help with the development but that shouldn't be push to the public repository, you can put then in a directory called `source/` at the root of the repo.

## Generate Python Client
From the root of the repo run the following command:
```bash
docker run --rm -v ${PWD}:/local openapitools/openapi-generator-cli generate \
    -i /local/overview.yaml \
    -g python \
    -o /local/clients/python/overview-client \
    --additional-properties=packageName=overview_client,packageVersion=0.0.1 
```

## Publish Python Client to PyPi
```bash
# (optional): if you don't have poetry and build installed
python3.10 -m pip install --upgrade build poetry

cd clients/python/overview-client

# clean up
rm -rf dist/

# build
poetry build
twine upload dist/*
# You will be prompt to enter your API token
```

## Generate C# Client
From the root of the repo run the following command:
```bash
docker run --rm -v ${PWD}:/local openapitools/openapi-generator-cli generate \
    -i /local/overview.yaml \
    -g csharp \
    -o /local/clients/csharp/overview-client \
    --additional-properties=packageName=overview_client,packageVersion=0.0.1 
```

## Publish C# Client to Nuget

```bash
cd clients/csharp/overview-client

docker run --rm -v "$(pwd)":/workspace -w /workspace mcr.microsoft.com/dotnet/sdk:9.0 bash -c "\
  dotnet clean && \
  dotnet build -c Release && \
  dotnet pack -c Release && \
  dotnet nuget push bin/Release/OverviewClient.0.0.1.nupkg --api-key YOUR_NUGET_API_KEY --source https://api.nuget.org/v3/index.json"

```