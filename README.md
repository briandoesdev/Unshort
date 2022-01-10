
[![GPLv3 License](https://img.shields.io/github/license/briandoesdev/Unshort.svg)](https://github.com/briandoesdev/Unshort/blob/main/LICENSE)
[![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/)
[![Deploy NuGet](https://github.com/briandoesdev/Unshort/actions/workflows/main.yml/badge.svg)](https://github.com/briandoesdev/Unshort/actions/workflows/main.yml)

![Unshort Logo](https://raw.githubusercontent.com/briandoesdev/Unshort/main/screenshots/unshort_logo.png)

Simple CLI tool to view long form of shortened links

# https

## About The Project

![Unshort Screen Shot](https://raw.githubusercontent.com/briandoesdev/Unshort/main/screenshots/screenshot.png)

### Built With

* [.NET 6](https://dotnet.microsoft.com/en-us/)

## Getting Started

### Prerequisites

* .NET 6.0
  ```sh
  dotnet --version # should be >= 6.x.x
  ```

### Install via NuGet

1. Verify you have .NET 6
2. Install from NuGet
   ```sh
   dotnet tool install --global Unshort
   ```
3. Verify Unshort is working
   ```sh
   unshort <short_url>
   ```

### Install from source

1. Clone the repo
   ```sh
   git clone https://github.com/briandoesdev/Unshort.git
   ```
2. Change diectory
   ```
   cd .\Unshort\
   ```
3. Restore project
   ```sh
   dotnet restore
   ```
4. Package tool
   ```sh
   dotnet pack
   ```
5. Install tool globally on system
   ```sh
   dotnet tool install --global --add-source ./nupkg unshort

## Usage

Example 1:
```sh
unshort <short_url>
```

Example 2:
```sh
unshort skl.sh/hai35
output: https://www.skillshare.com/membership/checkout?utm_source=Youtube&utm_medium=paid-HalfasInteresting&utm_campaign=2020-6-HalfasInteresting-35&utm_content=cta-link&coupon=YTHALFASINTERESTING35&onboarding_tag=24,191,39,672,3&classes=1539782161,1539782161,1389209398
```

## Roadmap

- [] No roadmap now

See the [open issues](https://github.com/briandoesdev/Unshort/issues) for a full list of proposed features (and known issues).

## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## Help

If you need help loading the extension you can contact me at [@briandoesdev](https://twitter.com/briandoesdev) on Twitter or most social platforms.

## Authors

- [@briandoesdev](https://twitter.com/briandoesdev)

## Version History

- 2022.1.10.41900
    - Handles timeouts better
- 1.0
    - Initial Release

## License

This project is licensed under the GPLv3 License - see the LICENSE.md file for details

## Acknowledgments

## Contact

briandoesdev - [@briandoesdev](https://twitter.com/briandoesdev) 

Project Link: [https://github.com/briandoesdev/Unshort](https://github.com/briandoesdev/Unshort)
