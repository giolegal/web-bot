# Smoke test
* dotnet run
* http://localhost:5000/api/values

# build and run from docker
* docker build -t abc .
docker run -p 5000:5000 abc:latest
http://localhost:5000/api/values

