# Elmah.Io.HResults

A little helper resolving extended information from HResults.

## Usage

```csharp
try
{
    // ...
}
catch (Exception ex)
{
    HResult hresult = HResult.Parse(ex.HResult);
    Console.WriteLine(hresult.Hex);
    Console.WriteLine(hresult.IsFailure);
    Console.WriteLine(hresult.Facility);
    Console.WriteLine(hresult.ErrorCode);
}
```