# Kocdigital
Kocdigital

# Docker Host

Docker üzerinde ütm uygulamaları host etmek için root üzerinde yer alan appsettings.json dosyasında configurasyon yapmak gereklidir.

Çalıştırmak için : 
```sh
docker-compose down && docker-compose build --no-cache && docker-compose up
```

Rabbitmq config
```sh
username : guest
password : guest
```

Elastic config
```sh
username : elastic
password : guest
```

Eğer docker üzerinde host edilecekse aşağıdaki appsettings ortaktır ve her uygulama için uygulama container larına kopyalanmaktadır.

Console uygulamaları docker üzerinde değil localde yapılacaksa her uygulamanın kendine ait appsettings dosyaları tek tek ayarlanmalıdır

![image](https://user-images.githubusercontent.com/950103/116870924-18332980-ac1c-11eb-86dd-f06905d86780.png)
![image](https://user-images.githubusercontent.com/950103/116871788-7dd3e580-ac1d-11eb-88c7-81049e1fde9f.png)
![image](https://user-images.githubusercontent.com/950103/116871982-cf7c7000-ac1d-11eb-86b4-4f0b46160391.png)
![image](https://user-images.githubusercontent.com/950103/116872077-f20e8900-ac1d-11eb-9b58-883997785369.png)


