ASP.NET React Template
======================

A simple starter template for building React applications powered by the Intelligence Hub API.

Prerequisites
-------------

*   [.NET 7 SDK](https://dotnet.microsoft.com/download)
    
*   [Node.js 16+](https://nodejs.org/)
    
*   Intelligence Hub API URL (e.g., https://api.intelligencehub.io)
    

Setup
-----

1.  git clone https://github.com/your-org/your-repo.gitcd your-repo
    
2.  **Configure the Intelligence Hub endpoint**
    
    *   Copy appsettings.Development.json.example to appsettings.Development.json in the Server folder.
        
    *   Set IntelligenceHub:BaseUrl to your Intelligence Hub API URL.
        
3.  cd ClientAppnpm installcd ../Serverdotnet restore
    

Running the App
---------------

*   cd ClientAppnpm startThe React dev server will launch on http://localhost:3000.
    
*   cd Serverdotnet runThe API will run on https://localhost:5001 by default.
    

Project Structure
-----------------

*   ClientApp/: React front‑end
    
*   Server/: ASP.NET Core back‑end
    
*   README.md: this file
    

Customization
-------------

*   Rename project namespaces in Server/Program.cs and React app title in ClientApp/package.json.
    
*   Update any placeholder values in appsettings.\*.json and .env files.
    

Deployment
----------

1.  cd ClientAppnpm run build
    
2.  cd ../Serverdotnet publish -c Release -o ./publish
    
3.  Deploy contents of publish to your hosting environment (Azure, AWS, etc.).
    

License
-------

MIT

Powered by [Intelligence Hub](https://github.com/AppliedAI-Org/intelligencehub)
