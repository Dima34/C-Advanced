// int simpleInt = null; 
int? maybeNullableInt =  null;

int parsedInt = maybeNullableInt.GetValueOrDefault();

parsedInt = maybeNullableInt ?? 0;

DateTime? date = null;
DateTime parsedDate;

parsedDate = date ?? DateTime.Now;

if (date == null)
{
    parsedDate = DateTime.Now;
}
else
{
    parsedDate = date.Value;
}

parsedDate = (date == null) ? DateTime.Now : date.GetValueOrDefault();
    