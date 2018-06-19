FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
# COPY *.csproj ./post-api/
# WORKDIR /app/post-api
# RUN dotnet restore

# copy and build everything else
WORKDIR /app/
COPY . ./post-api/
WORKDIR /app/post-api
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/post-api/out ./
ENTRYPOINT ["dotnet", "post-api.dll"]