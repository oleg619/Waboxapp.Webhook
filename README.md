#### Local run 

```
> ngrok http 8443 
your will get {URL} (smth like http://3347cc103a16.ngrok.io)
> register WEBHOOK URL {URL}/api/waboxapp/update 
example : http://3347cc103a16.ngrok.io/api/waboxapp/update
> run application
```

#### Production 

```
> register WEBHOOK URL {URL}/api/waboxapp/update
{URL} your real address

> publish application
```
