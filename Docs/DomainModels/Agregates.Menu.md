# Domain Models

## Menu

```csharp
class Menu
{
    Menu Create();
    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateSection(MenuSection section);
}
```

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "name": "Hello world Menu",
  "description": "This is a Hello World food.",
  "averageRating": 4.5,
  "sections": [
    {
      "id": "00000000-0000-0000-0000-000000000000",
      "name": "Appetizers",
      "description": "An appetizers",
      "items": [
        {
          "id": "00000000-0000-0000-0000-000000000000",
          "name": "Chicken wings",
          "description": "Yummy chiken wings",
          "price": 1.99
        }
      ]
    }
  ],
  "createdDateTime": "2021-03-15T14:36:28Z",
  "updatedDateTime": "2021-03-15T14:37:01Z",
  "hostId": "00000000-0000-0000-0000-000000000000",
  "dinnerIds": ["00000000-0000-0000-0000-000000000000"],
  "MenuReviewIds": ["00000000-0000-0000-0000-000000000000"]
}
```
