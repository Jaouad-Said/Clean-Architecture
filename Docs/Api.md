# Clean Project API

- [Clean Project API](#clean-project-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

### Register Request

```json
{
  "firstName": "Fname",
  "lastName": "LNAME",
  "email": "fname.lname@gmail.com",
  "password": "Fname2023"
}
```

### Register Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a-ehdbna-je1znz415ejkei145dn-eajd9an4xo",
  "firstName": "Fname",
  "lastName": "LNAME",
  "email": "fname.lname@gmail.com",
  "password": "ryJhb..z8hedna6Y"
}
```

### Login

```js
POST {{host}}/auth/login
```

### Login Request

```json
{
  "email": "fname.lname@gmail.com",
  "password": "Fname2023"
}
```

### Login Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a-ehdbna-je1znz415ejkei145dn-eajd9an4xo",
  "firstName": "Fname",
  "lastName": "LNAME",
  "email": "fname.lname@gmail.com",
  "password": "ryJhb..z8hedna6Y"
}
```
