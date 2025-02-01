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
    -o /local/clients/python-client
```
