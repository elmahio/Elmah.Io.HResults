# Elmah.Io.HResults

A little helper resolving extended information from HResults.

## Usage

```csharp
try
{
    throw new ApplicationException();
}
catch (Exception ex)
{
    HResult hresult = HResult.Parse(ex.HResult);
    Console.WriteLine(hresult.Hex); // 0x80131600
    Console.WriteLine(hresult.IsFailure); // true
    Console.WriteLine(hresult.Facility.Name); // FACILITY_URT
    Console.WriteLine(hresult.Code.Name); // COR_E_APPLICATION
}
```