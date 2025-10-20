using System.Diagnostics;

namespace ArchitecturalGenerator.Model.Services;

public static class DotnetStatusService
{
	public static async Task<bool> IsAvailableAsync()
	{
		try
		{
			ProcessStartInfo startInfo = new()
			{
				FileName = "dotnet",
				Arguments = "--version",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};

			using Process process = new();
			process.StartInfo = startInfo;
			process.Start();

			string output = await process.StandardOutput.ReadToEndAsync();
			await process.WaitForExitAsync();

			return process.ExitCode == 0 && !string.IsNullOrWhiteSpace(output);
		}
		catch
		{
			return false;
		}
	}
}
