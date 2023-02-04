# Usage

Simply `https://github.com/kamalkish0r/Task-Manager.git` and `dotnet run --project TaskManager`.

# API Definition

## Create Task

### Create Task Request

```js
POST / tasks;
```

```json
{
  "name": "Upsolve",
  "description": "Upsolve last 3 codeforces rounds!",
  "DateCreated": "2022-04-08T08:00:00",
  "Tags": ["CodeForces"]
}
```

### Create Task Response

```js
201 Created
```

```yml
Location: {{host}}/tasks/{{id}}
```

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "name": "Upsolve",
  "description": "Upsolve last 3 codeforces rounds!",
  "DateCreated": "2022-04-08T08:00:00",
  "Tags": ["CodeForces"]
}
```

## Get Task

### Get Task Request

```js
GET /tasks/{{id}}
```

### Get Task Response

```js
200 Ok
```

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "name": "Upsolve",
  "description": "Upsolve last 3 codeforces rounds!",
  "DateCreated": "2022-04-08T08:00:00",
  "Tags": ["CodeForces"]
}
```

## Update Task

### Update Task Request

```js
PUT /tasks/{{id}}
```

```json
{
  "name": "Upsolve",
  "description": "Upsolve last 3 codeforces rounds!",
  "DateCreated": "2022-04-08T08:00:00",
  "Tags": ["CodeForces"]
}
```

### Update Task Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Tasks/{{id}}
```

## Delete Task

### Delete Task Request

```js
DELETE /tasks/{{id}}
```

### Delete Task Response

```js
204 No Content
```
