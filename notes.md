# W01 Assignment - ContosoPizza & Sales Summary Notes

## 1. Custom Seed Data

- Added **"Meat Lovers Supreme"** (`Id: 3`, `IsGlutenFree: false`) in `PizzaService.cs`.

## 2. HTTP Verbs & Status Codes Testing

- **GET /pizza**: Returns the full list of pizzas. -> **Status: 200 OK**
- **GET /pizza/1**: Returns a single specific pizza. -> **Status: 200 OK**
- **GET /pizza/99**: Tests non-existent ID handling. -> **Status: 404 Not Found**
- **POST /pizza**: Adds a new pizza to the inventory. -> **Status: 201 Created**
- **PUT /pizza/1**: Updates existing pizza details. -> **Status: 204 No Content**
- **DELETE /pizza/2**: Removes a pizza from inventory. -> **Status: 204 No Content**

## 3. Sales Summary Function (`StringBuilder` & Currency Formatting)

```csharp
using System.Text;

public static string GenerateSalesSummary(decimal[] dailySales)
{
    StringBuilder sb = new StringBuilder();
    decimal totalSales = 0;

    sb.AppendLine("=== Contoso Pizza Sales Summary ===");
    for (int i = 0; i < dailySales.Length; i++)
    {
        sb.AppendLine($"Day {i + 1}: {dailySales[i].ToString("C")}");
        totalSales += dailySales[i];
    }
    sb.AppendLine("-----------------------------------");
    sb.AppendLine($"Total Revenue: {totalSales.ToString("C")}");

    return sb.ToString();
}
```
