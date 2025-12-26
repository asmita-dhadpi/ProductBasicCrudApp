<h1> Product Management CRUD – ASP.NET Core MVC</h1>

<p>
A simple <strong>Product Management CRUD application</strong> built using
<strong>ASP.NET Core MVC</strong> and <strong>Entity Framework Core</strong>.
This project demonstrates clean MVC architecture, validations, search and
pagination.
</p>

<hr />

<h2>Features</h2>
<ul>
    <li>Create, Read, Update, Delete (CRUD) products</li>
    <li>Server-side validations</li>
    <li>Optional price with decimal validation</li>
    <li>Duplicate Product + Category prevention</li>
    <li>Default active status handling</li>
    <li>Search by product name or category</li>
    <li>Pagination for better data handling</li>
    <li>Clean MVC folder structure</li>
</ul>

<hr />

<h2>Tech Stack</h2>
<ul>
    <li>ASP.NET Core MVC (.NET 8)</li>
    <li>Entity Framework Core</li>
    <li>SQL Server</li>
    <li>Razor Views</li>
    <li>Bootstrap (basic UI)</li>
</ul>

<hr />

<h2>Validations Implemented</h2>
<ul>
    <li><strong>Product Name</strong> – Required</li>
    <li><strong>Category</strong> – Required</li>
    <li>
        <strong>Price</strong>
        <ul>
            <li>Optional</li>
            <li>Must be greater than 0 if entered</li>
        </ul>
    </li>
    <li><strong>Duplicate Check</strong> – Same Product + Category not allowed</li>
    <li><strong>IsActive</strong> – Checked by default on create</li>
</ul>

<hr />

<h2>Search & Pagination</h2>
<ul>
    <li>Search implemented using HTTP GET </li>
    <li>Search by product name or category</li>
    <li>Pagination implemented using Skip() and Take()</li>
    <li>Reset option to clear search filters</li>
</ul>

<hr />

<h2>Getting Started</h2>

<h3>Prerequisites</h3>
<ul>
    <li>.NET 8 SDK</li>
    <li>SQL Server</li>
    <li>Visual Studio 2022 / VS Code</li>
</ul>

<h3>Setup Steps</h3>

<h4>1️. Clone the Repository</h4> 
<pre> git clone https://github.com/asmita-dhadpi/ProductBasicCrudApp.git </pre>
<p>Open the project folder in <strong>Visual Studio</strong> or <strong>VS Code</strong>.</p>
<h4>2️. Configure Database</h4>
<p> Ensure <strong>SQL Server</strong> is running on your system. Update the connection string in 
<code>appsettings.json</code>. </p>
<h4>3️. Install Required EF Core Packages (If Not Already Installed)</h4>
<p>
<strong>Using Package Manager Console (Visual Studio):</strong>
</p> 
<pre> Install-Package Microsoft.EntityFrameworkCore.SqlServer Install-Package Microsoft.EntityFrameworkCore.Tools </pre> 
<p><strong>Using .NET CLI:</strong></p> 
<pre> dotnet add package Microsoft.EntityFrameworkCore.SqlServer dotnet add package Microsoft.EntityFrameworkCore.Tools </pre> 
<p> These packages are already referenced in the project. This step is only required if packages fail to restore automatically. </p>
<h4>4. Apply Database Migrations</h4> 
<p> Migrations are already included in the repository. You only need to apply them to create the database. </p> 
<p><strong>Using Package Manager Console:</strong></p> 
<pre> Update-Database </pre> 
<p><strong>Using .NET CLI:</strong></p> 
<pre> dotnet ef database update </pre>
<h4>5. Run the Application</h4> 
<p><strong>Using .NET CLI:</strong></p> 
<pre> dotnet run </pre>
<p> The application will start and be available at: </p>
<pre> https://localhost:5001 or http://localhost:5000 </pre>
<hr />

<h2> Why This Project</h2>
<p>
This project is intentionally kept <strong>simple and clean</strong> to
demonstrate ASP.NET Core MVC fundamental and real-world validation logic.

</p>

<hr />

<h2>Author</h2>
<p>
<strong>Asmita Dhadpi</strong><br />
ASP.NET Core Developer
</p>