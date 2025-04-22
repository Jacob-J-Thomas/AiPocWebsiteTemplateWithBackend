ASP.NET React Template

A simple starter template for building React applications powered by the Intelligence Hub API.

Prerequisites

.NET 7 SDK

Node.js 16+

Intelligence Hub API URL (e.g., https://api.intelligencehub.io)

Setup

Clone this repository

git clone https://github.com/your-org/your-repo.git
cd your-repo

Configure the Intelligence Hub endpoint

Copy appsettings.Development.json.example to appsettings.Development.json in the Server folder.

Set IntelligenceHub:BaseUrl to your Intelligence Hub API URL.

Install dependencies

cd ClientApp
npm install
cd ../Server
dotnet restore

Running the App

Frontend (React)

cd ClientApp
npm start

The React dev server will launch on http://localhost:3000.

Backend (ASP.NET Core)

cd Server
dotnet run

The API will run on https://localhost:5001 by default.

Project Structure

ClientApp/: React front‑end

Server/: ASP.NET Core back‑end

README.md: this file

Customization

Rename project namespaces in Server/Program.cs and React app title in ClientApp/package.json.

Update any placeholder values in appsettings.*.json and .env files.

Deployment

Build the React app:

cd ClientApp
npm run build

Publish the ASP.NET Core app:

cd ../Server
dotnet publish -c Release -o ./publish

Deploy contents of publish to your hosting environment (Azure, AWS, etc.).

License

MIT

Powered by Intelligence Hub
