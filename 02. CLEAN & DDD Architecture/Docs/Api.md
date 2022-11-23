# CLEAN & DDD Architecture

- [CLEAN & DDD Architecture API](#clean--ddd-architecture)
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

#### Register Request

```json
{
    "firstName": "Carlo",
    "lastName": "van der Vliet",
    "email": "carlovandervliet@gmail.com",
    "password": "TheOneAndOnly007!"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "53aa37b0-6af1-4bf6-8b0f-c09c7da55113",
    "firstName": "Carlo",
    "lastName": "van der Vliet",
    "email": "carlovandervliet@gmail.com",
    "token": "yfRe7..z49357dhSeHG"
}
```

### Login

```js
POST {{host}}/auth/login
```