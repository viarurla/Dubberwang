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

### Completion time (rough estimates)
- MVP with Unit Tests: 2-3 Hours.
- WebAPI: 30 minutes.
- Client: 2-3 Hours
- Docker: 1 Hours

Additional time was spent on comments / polishing existing code as well as performing installation of dependencies.

Software used:
- Docker desktop
- WebStorm
- Rider
- VS Code

### Self inflicted Q&A:
  - **Q: Why did you dockerise it?**
    - A: Ease of testing and makes me less worried it'll spontaneously fall over when providing to Dubber.
  - **Q: Why use Next.js**
    - A: It's very batteries included, with minimal setup required to get a solid, stable frontend up and running.
  - **Q: Why use DotNet?**
    - A: It would likely have taken me a fraction of the time if I'd used Python, but it felt more appropriate to do it in the language most relevant to the applied role.
  - **Q: Why did you include Numberwang?**
    - A: It seemed like a good idea at the time.

## License
[MIT](https://choosealicense.com/licenses/mit/)