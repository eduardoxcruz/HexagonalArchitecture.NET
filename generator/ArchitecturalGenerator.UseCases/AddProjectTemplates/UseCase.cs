using System.Diagnostics;

using ArchitecturalGenerator.Model.Services;

using SeedWork;

namespace ArchitecturalGenerator.UseCases.AddProjectTemplates;

public class UseCase : IDomainPort<EmptyDto, ProjectTemplatesPathDto>
{
    public async ValueTask<EmptyDto> Handle(ProjectTemplatesPathDto input)
    {
        if (string.IsNullOrWhiteSpace(input.Path)) throw new ArgumentException("The template path cannot be null or empty.", nameof(input));

        if (!Directory.Exists(input.Path)) throw new DirectoryNotFoundException($"The specified path does not exist: {input.Path}");

        if (!await DotnetStatusService.IsAvailableAsync()) throw new Exception("Dotnet is not available in the system.");

        bool success = await InstallTemplatesAsync(input.Path);
        
        return success ? default : throw new Exception($"Failed to install templates from path: {input.Path}");
    }

    private static async Task<bool> InstallTemplatesAsync(string path)
    {
        try
        {
            ProcessStartInfo startInfo = new()
            {
                FileName = "dotnet",
                Arguments = $"new install \"{path}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process process = new();
            process.StartInfo = startInfo;
            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();

            await process.WaitForExitAsync();

            if (process.ExitCode != 0)
                await Console.Error.WriteLineAsync($"dotnet new install failed: {error}");

            return process.ExitCode == 0;
        }
        catch (Exception ex)
        {
            await Console.Error.WriteLineAsync($"Error running dotnet new install: {ex.Message}");
            return false;
        }
    }
}

public record struct ProjectTemplatesPathDto()
{
	public string Path { get; set; }
}
