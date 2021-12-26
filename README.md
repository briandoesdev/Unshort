<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/briandoesdev/Unshort">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Unshort</h3>

  <p align="center">
    Simple CLI tool to view long form of shortened links
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

![Unshort Screen Shot](/screenshots/screenshot.png?raw=true)

<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [.NET 6](https://dotnet.microsoft.com/en-us/)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

* .NET 6.0
  ```sh
  dotnet --version
  ```
  Output should be 6.0.0 or greater

### Installation

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
   ```

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->
## Usage

Example 1:
```sh
unshort <short url>
```

Example 2:
```sh
unshort skl.sh/hai35
output: https://www.skillshare.com/membership/checkout?utm_source=Youtube&utm_medium=paid-HalfasInteresting&utm_campaign=2020-6-HalfasInteresting-35&utm_content=cta-link&coupon=YTHALFASINTERESTING35&onboarding_tag=24,191,39,672,3&classes=1539782161,1539782161,1389209398
```

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [] Feature 1
- [] Feature 2
- [] Feature 3
    - [] Nested Feature

See the [open issues](https://github.com/briandoesdev/Unshort/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Your Name - [@briandoesdev](https://twitter.com/briandoesdev) 

Project Link: [https://github.com/briandoesdev/Unshort](https://github.com/briandoesdev/Unshort)

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/briandoesdev/Unshort.svg?style=for-the-badge
[contributors-url]: https://github.com/briandoesdev/Unshort/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/briandoesdev/Unshort.svg?style=for-the-badge
[forks-url]: https://github.com/briandoesdev/Unshort/network/members
[stars-shield]: https://img.shields.io/github/stars/briandoesdev/Unshort.svg?style=for-the-badge
[stars-url]: https://github.com/briandoesdev/Unshort/stargazers
[issues-shield]: https://img.shields.io/github/issues/briandoesdev/Unshort.svg?style=for-the-badge
[issues-url]: https://github.com/briandoesdev/Unshort/issues
[license-shield]: https://img.shields.io/github/license/briandoesdev/Unshort.svg?style=for-the-badge
[license-url]: https://github.com/briandoesdev/Unshort/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/briandoesdev
[product-screenshot]: images/screenshot.png