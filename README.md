# Projeto de Aprendizado em C#, .NET 8 e .NET MAUI: Controle Remoto de Carrinho via Azure e WebRTC

## 🚀 Visão Geral do Projeto

Este repositório documenta minha jornada de aprendizado em tecnologias Microsoft modernas, culminando em um projeto integrado que combina:
- **C# e .NET 8** para desenvolvimento backend
- **.NET MAUI** para aplicativos multiplataforma
- **Azure** para hospedagem e serviços em nuvem
- **WebRTC** para comunicação em tempo real entre dispositivos
- **ESP32** para controle físico de um carrinho robótico

O sistema permite que dois usuários controlem coletivamente um carrinho físico, utilizando seus smartphones como câmeras e controles, com processamento centralizado no Azure.

## 📚 Jornada de Aprendizado

### Fase 1: Fundamentos de C# e .NET 8
- Domínio dos conceitos básicos da linguagem C#
- Aprofundamento em recursos avançados como:
  - Programação assíncrona (async/await)
  - LINQ e expressões lambda
  - Entity Framework Core
  - Injeção de dependência
- Exploração das novidades do .NET 8

### Fase 2: Desenvolvimento Multiplataforma com .NET MAUI
- Criação de aplicativos para:
  - **Mobile** (Android/iOS)
  - **Windows** (Desktop)
  - **Web** (via Blazor)
- Componentes compartilhados e específicos por plataforma
- Integração com sensores do dispositivo (câmera, acelerômetro)

### Fase 3: Comunicação em Tempo Real com WebRTC
- Implementação de protocolos WebRTC em C#
- Gerenciamento de conexões P2P
- Transmissão de vídeo e dados entre dispositivos
- NAT traversal usando servidores TURN/STUN

### Fase 4: Integração com Azure
- Configuração de servidores na nuvem Azure
- Serviços utilizados:
  - Azure App Service (backend)
  - Azure SignalR Service (comunicação em tempo real)
  - Azure IoT Hub (gerenciamento de dispositivos ESP)
  - Azure Media Services (processamento de vídeo)

### Fase 5: Controle de Dispositivos Físicos
- Programação do ESP32 em C++/Arduino
- Comunicação via Wi-Fi/Bluetooth
- Protocolos para comandos em tempo real (pode-se adaptar a MQTT)
- Segurança e autenticação de dispositivos

## 🛠️ Arquitetura do Sistema
```plaintext
[Smartphone 1]   ← WebRTC → [Azure Server] ← WebRTC → [Smartphone 2]
        ↑                           ↑
        |                           |
(Câmera/Controles)         [Processamento Central]
                                    ↓
                                 [ESP32]
                                    ↓
                            [Carrinho Robótico]
```

## 🔧 Componentes Principais

1. **Aplicativo .NET MAUI**
   - Captura de vídeo via câmera dos smartphones
   - Interface de controle intuitiva
   - Comunicação WebRTC com o servidor

2. **Backend .NET 8 no Azure**
   - Orquestração das conexões WebRTC
   - Processamento de comandos dos usuários
   - Mediação entre dispositivos móveis e ESP32
   - Lógica de negócios e segurança

3. **Firmware ESP32**
   - Recebimento de comandos via Wi-Fi
   - Controle de motores/servos
   - Feedback de sensores (se aplicável)

## 🎯 Funcionalidades Implementadas

- **Controle colaborativo**: Dois usuários podem controlar o carrinho simultaneamente
- **Streaming de vídeo**: Visualização em tempo real de múltiplas câmeras
- **Controles intuitivos**: Acelerômetro, toque na tela ou comandos de voz
- **Sincronização de estado**: Todos os clientes recebem atualizações em tempo real
- **Segurança**: Autenticação e criptografia em todas as camadas

## 📦 Estrutura do Repositório

├── /MauiApp              # Aplicativo .NET MAUI multiplataforma  
├── /Backend              # Servidor .NET 8 no Azure  
├── /ESP32_Firmware       # Código para o microcontrolador  
├── /Docs                 # Documentação e diagramas  
├── /Prototypes           # Projetos de aprendizado individuais  
└── README.md             # Este arquivo  


## 🏁 Como Executar o Projeto

### Pré-requisitos
- .NET 8 SDK
- Visual Studio 2022 (com workloads MAUI e Azure)
- Azure CLI (para deploy)
- Plataforma PlatformIO (para ESP32)

### Passos para Configuração
1. Clone o repositório
2. Configure as credenciais do Azure no `Backend/appsettings.json`
3. Defina as configurações de Wi-Fi no firmware do ESP32
4. Execute o servidor backend no Azure
5. Inicie os aplicativos MAUI nos dispositivos
6. Conecte o ESP32 à rede e alimente o carrinho

## 📌 Lições Aprendidas

- **Desafios de sincronização em tempo real**: Coordenar múltiplos dispositivos requer algoritmos robustos
- **Otimização de recursos**: Balanceamento entre qualidade de vídeo e latência
- **Cross-platform**: Lidar com peculiaridades de cada plataforma mantendo código compartilhado
- **Segurança**: Implementação de autenticação em todas as camadas do sistema

## 🔮 Próximos Passos

- Implementar visão computacional no Azure para navegação autônoma assistida
- Adicionar suporte a mais dispositivos simultâneos
- Desenvolver sistema de "salas" para múltiplos carrinhos
- Implementar gravação e replay de sessões

## 🤝 Como Contribuir

Contribuições são bem-vindas! Siga os passos:
1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📜 Licença

Distribuído sob a licença MIT. Veja `LICENSE` para mais informações.

## ✉️ Contato

Marcellus Mendonça - marcellusmbarbosa@ufu.br

Link do Projeto: [https://github.com/Marcellusmbarbosa/SEII-MarcellusMendoncaBarbosaDaSilva](https://github.com/Marcellusmbarbosa/SEII-MarcellusMendoncaBarbosaDaSilva)
