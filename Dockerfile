FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

# Create the destination directory for copied files
# The -p flag ensures parent directories are created if they don't exist
RUN mkdir -p /mnt/destination

COPY . .
ENTRYPOINT ["dotnet", "CustomFileCopyHandler.dll"]