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