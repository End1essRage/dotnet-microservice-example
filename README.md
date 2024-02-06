Цель: реализовать простое микросервисное приложение

Стек:
	платформа:
	.net 7.0
	
	Брокер сообщений:
	RabbitMq

	База данных:
	MsSql

	Api gateway:
	Nginx

	Deployment:
	docker, k8s

	Other:
	gRpc


Описание архитектуры:

1)Platform service
Сервис предоставляющий возможность манипулировать реестром платформ/систем в компании

2)Command service
Хранилище аргументов командой строки для разных платформ



Развертывание:

1)Создание секрета:
	kubectl create secret generic mssql --from-literal=SA_PASSWORD="Pa55w0rd"

2)Запуск ingress nginx controller:
	kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.8.2/deploy/static/provider/cloud/deploy.yaml

3)Запуск всех деплойментов
		


Задачи:

1)Реализовать прокидывание секрета в контейнер для подключения к бд


