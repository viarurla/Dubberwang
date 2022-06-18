# Dubberwang

Dubberwang is a cutting edge (depending on who you ask) web application that provides YOU with the numbers you deserve.
<br/> The more accurate description is that this work is part of an interview process with Dubber,
<br/> and the primary goal of the exercise is to present 6 (7 including bonus balls) with unique numerical values. 

Also in case you weren't aware of the inspiration for the name, please see [Numberwang](https://www.youtube.com/watch?v=0obMRztklqU).

## Requirements

The requirements to run this application are as follows:
- DotNet 6.0
- NodeJs >= v18.4.0

Alternatively, if you have Docker installed, these can be handled by the included compose file. (Recommended)

## Usage

The application comes in two parts, you can run it via command line, or using the web interface hooked up to an API.
<br/>The console application represents the minimum viable product, and it is recommended to use the web service instead.

By default, the API server should be listening on http://localhost:7040/, with the client on https://localhost:3000/.
#### Windows / OSX
```bash
docker-compose up -d
```
#### GNU/Linux
```bash
docker compose up -d
```

## Developer Notes

## License
[MIT](https://choosealicense.com/licenses/mit/)