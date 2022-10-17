# For Models use scaffolding tool

## Using the scaffold tool

### from the command-line


```
dotnet linq2db scaffold -o .\models -p SqlServer -c "Server=(local)\SQLEXPRESS;Database=WideWorldImporters;Integrated Security=True;Persist Security Info=True;Trust Server Certificate=True;" -n WcfDataService.models --overwrite true
```
