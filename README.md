# asp.net-testing

> testing repo for asp.net

## System requirements

- .NET 6.x
- tested on Fedora 37 but any OS with .NET 6.x should work fine

## Development

- Edit `Program.cs` in the `src/` folder
- Getting weird lockfile errors? run `./clean` or `bash /path/to/clean` and rebuild/run
- Permission denied? Use `sudo` or switch user to root with `sudo su -` - make sure to go back to the path you need to be in as this will put you in thr root users home directory at `/root`

## Building

### .NET

- Navigate to `src/`
- `dotnet build`

## Running

### .Net

- Navigate to `src/`
- `sudo dotnet run` if no args to start the server, as root is needed to start a TCP Listener on port 43, else `dotnet run`  
### Bash

- `sudo ./src/bin/Debug/net6.0/whois` if no args to start the server, as root is needed to start a TCP Listener on port 43, else



## Changelog

- generate the changelog with `./changelog` or `bash /path/to/changelog`
- See the [Changelog](/CHANGELOG.md)
- Last 'stable' commit: 6364a09

## Credits

*Some* of the source code in files may be adapted from [Brian Tompsett's](https://www.hull.ac.uk/staff-directory/brian-tompsett) Lecture/video material (will be commented in code where possible) - a lecturer at the [University of Hull](https://hull.ac.uk). You can view his related [network series on YouTube](https://www.youtube.com/watch?v=4722rb-VSag&list=PL3czsVugafjPqF4dO2vQY8EPRp3mfd_4u)