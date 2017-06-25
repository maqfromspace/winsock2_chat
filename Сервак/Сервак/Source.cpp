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
			//��������� ��� ���� ��������
			for (int i = 0; i < ClientCount; i++)
			{				
				send(Connections[i], buffer, strlen(buffer), NULL);
			}
			memset(buffer, 0, sizeof(buffer));//������� �����
	}
	closesocket(Connections[ID]);
	delete buffer;
}

void main()
{
	setlocale(LC_ALL, "RUSSIAN");
	//�������������� ������
	WSAData data;
	WORD version = MAKEWORD(2, 2);
	int res = WSAStartup(version, &data);
	if (res != 0) return;

	struct addrinfo  hints;
	struct addrinfo *result;
	//����� �� ����� ��������������
	Connections = (SOCKET*)calloc(64, sizeof(SOCKET));//�������� 64 ������ �������� sizeof(socket)

													  //��������� ������
	ZeroMemory(&hints, sizeof(hints));
	hints.ai_family = AF_INET;
	hints.ai_flags = AI_PASSIVE;
	hints.ai_socktype = SOCK_STREAM;
	hints.ai_protocol = IPPROTO_TCP;
	getaddrinfo(NULL, "2222", &hints, &result);

	Listen = socket(result->ai_family, result->ai_socktype, result->ai_protocol);
	bind(Listen, result->ai_addr, result->ai_addrlen);//��������� Listen
	listen(Listen, SOMAXCONN);//��������� ����� � ��������� LISTEN, ����� �� ����� ��������� ������

	freeaddrinfo(result);//

	cout << "Connection with server!" << endl;
	char m_connect[] = "Connect!;;;5";

	for (;;)
	{
		if (Connect = accept(Listen, NULL, NULL))
		{

			cout << "Connect !!!" << endl;
			Connections[ClientCount] = Connect;//�������� ������ ������������
			send(Connections[ClientCount], m_connect, strlen(m_connect), NULL);//���������� ������������ � �����������
			ClientCount++;
			CreateThread(NULL, NULL, (LPTHREAD_START_ROUTINE)SendMessageToClient, (LPVOID)(ClientCount - 1), NULL, NULL);//�����, ������� ��������� �������, ������� ������ � ���� ������������ ���������(������ ����� ��������� ������������ � ����� �� �����)
		}
	}
}