# ARProject

## Visão Geral

Este projeto utiliza o Vuforia para renderizar produtos em realidade aumentada e fornecer informações detalhadas sobre seus componentes. O objetivo é criar uma experiência interativa para os usuários, permitindo-lhes visualizar e aprender mais sobre os produtos de forma inovadora.

## Funcionalidades

- Renderização de produtos em realidade aumentada.
- Exibição de informações detalhadas sobre os componentes dos produtos.
- Interface de usuário intuitiva e interativa.
- Compatibilidade com múltiplos dispositivos.

## Requisitos

- Unity 2020.3 ou superior.
- Vuforia Engine 9.8.5 ou superior.
- Dispositivo móvel com câmera (para testes em dispositivos físicos).
- [Vuforia Developer Account](https://developer.vuforia.com/) para obter a licença e as credenciais de uso.

## Instalação

1. Clone este repositório:

    ```bash
    git clone https://github.com/seu-usuario/vuforia-product-renderer.git
    ```

2. Abra o Unity Hub e clique em "Add" para adicionar o projeto clonado.
3. Abra o projeto no Unity.
4. Instale o Vuforia Engine no Unity:
   - Vá até `Window > Package Manager`.
   - Clique em `+` e selecione `Add package from git URL...`.
   - Insira `https://github.com/Vuforia/VuforiaEngine.git` e clique em `Add`.
5. Configure o Vuforia:
   - Vá até `Vuforia Configuration` no `Inspector`.
   - Insira sua `License Key` obtida no [site da Vuforia](https://developer.vuforia.com/).

## Uso

1. Importe os modelos 3D dos produtos que deseja renderizar.
2. Configure os alvos de imagem do Vuforia:
   - Vá até `GameObject > Vuforia Engine > Image Target`.
   - Selecione a imagem que será usada como alvo e ajuste as propriedades conforme necessário.
3. Adicione os componentes de UI para exibir as informações dos produtos.
4. Implemente os scripts para conectar os alvos de imagem aos modelos 3D e às informações dos componentes.

## Contribuição

Siga os passos abaixo para contribuir com o projeto:

1. Faça um fork deste repositório.
2. Crie um branch para sua feature ou correção de bug:

    ```bash
    git checkout -b minha-feature
    ```

3. Faça commit das suas alterações:

    ```bash
    git commit -m 'Adicionei minha nova feature'
    ```

4. Faça push para o branch:

    ```bash
    git push origin minha-feature
    ```

5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

