namespace YourDomain.DTOs;

public class OutputDto
{
	public string Data { get; set; }

	public OutputDto(string data)
	{
		Data = data;
	}
}
