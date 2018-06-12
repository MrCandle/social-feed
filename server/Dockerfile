FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./social-feed-api/
WORKDIR /app/social-feed-api
RUN dotnet restore

# copy and build everything else
WORKDIR /app/
COPY . ./social-feed-api/
WORKDIR /app/social-feed-api
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/social-feed-api/out ./
ENTRYPOINT ["dotnet", "social-feed-api.dll"]