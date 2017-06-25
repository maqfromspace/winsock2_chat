#pragma comment (lib,"Ws2_32.lib")
#include<WinSock2.h>
#include<iostream>
#include<WS2tcpip.h>

using namespace std;
SOCKET Connect;
SOCKET* Connections;
SOCKET Listen;
int ClientCount = 0;

void SendMessageToClient(int ID)
{
	char* buffer = new char[1024];
	char* test = new char[2];
	while(recv(Connections[ID], buffer, 1024, NULL)!=SOCKET_ERROR)
	{
			cout << buffer << endl;
			//рассылаем его всем клиентам
			for (int i = 0; i < ClientCount; i++)
			{				
				send(Connections[i], buffer, strlen(buffer), NULL);
			}
			memset(buffer, 0, sizeof(buffer));//очищаем буфер
	}
	closesocket(Connections[ID]);
	delete buffer;
}

void main()
{
	setlocale(LC_ALL, "RUSSIAN");
	//инициализируем сокеты
	WSAData data;
	WORD version = MAKEWORD(2, 2);
	int res = WSAStartup(version, &data);
	if (res != 0) return;

	struct addrinfo  hints;
	struct addrinfo *result;
	//сокет со всеми пользовател€ми
	Connections = (SOCKET*)calloc(64, sizeof(SOCKET));//выдел€ем 64 €чейки размером sizeof(socket)

													  //настройка сокета
	ZeroMemory(&hints, sizeof(hints));
	hints.ai_family = AF_INET;
	hints.ai_flags = AI_PASSIVE;
	hints.ai_socktype = SOCK_STREAM;
	hints.ai_protocol = IPPROTO_TCP;
	getaddrinfo(NULL, "2222", &hints, &result);

	Listen = socket(result->ai_family, result->ai_socktype, result->ai_protocol);
	bind(Listen, result->ai_addr, result->ai_addrlen);//объ€вл€ем Listen
	listen(Listen, SOMAXCONN);//переводим сокет в состо€ние LISTEN, когда он может принимать запрос

	freeaddrinfo(result);//

	cout << "Connection with server!" << endl;
	char m_connect[] = "Connect!;;;5";

	for (;;)
	{
		if (Connect = accept(Listen, NULL, NULL))
		{

			cout << "Connect !!!" << endl;
			Connections[ClientCount] = Connect;//создание нового пользовател€
			send(Connections[ClientCount], m_connect, strlen(m_connect), NULL);//уведомл€ем пользовател€ о подключении
			ClientCount++;
			CreateThread(NULL, NULL, (LPTHREAD_START_ROUTINE)SendMessageToClient, (LPVOID)(ClientCount - 1), NULL, NULL);//поток, который запускает функцию, котора€ хранит в себе передаваемое сообщение(каждое новое сообщение записываетс€ в буфер по новой)
		}
	}
}