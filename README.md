# OnionArchitecture

Projeto feito como uma prática para entender e aplicar a arquitetura cebola utilizando ASP.NET core 7 e Sqlite.

Foi feito um simples CRUD de usuário utilizando API mínima, banco de dados Sqlite e EntityFrameworkCore.

---

<p align="center">
  <img src="https://github.com/lucas-lima-developer/OnionArchitecture/assets/58302967/e28f6a0d-20d7-4811-892c-6ee0eff3cc2d" alt="Imagem 1">
</p>


## Sobre Arquitetura Cebola

A Arquitetura em Cebola, também conhecida como Onion Architecture, é um padrão de design de software que tem como objetivo principal promover a 
organização e a clareza na estrutura de um aplicativo. Ela é chamada assim porque segue o princípio de que as camadas mais externas devem 
depender apenas das camadas mais internas, criando uma estrutura em camadas similar às camadas concêntricas de uma cebola.

### As principais camadas da Arquitetura em Cebola incluem:

- **Domínio (Domain)**: Esta é a camada onde reside a lógica de negócio do aplicativo. Aqui você encontrará as definições de entidades, 
regras de negócio, interfaces de repositório e serviços que possuem regra de negócio. Esta camada é puramente conceitual e independente 
de qualquer tecnologia.

- **Aplicação (Application)**: Esta camada atua como a "orquestradora" do aplicativo. Ela conhece as operações que precisam ser realizadas, 
mas delega a execução dessas operações para a camada de Domínio. A camada de Aplicação coordena as operações e faz uso da camada de Domínio 
para implementar a lógica de negócio.

- **Infraestrutura (Infrastructure)**: Como o próprio nome sugere, esta camada é onde ficam os detalhes de implementação técnica e configurações 
de infraestrutura. Aqui você encontrará configurações do ORM, implementações concretas das interfaces de repositório, configuração de broker, 
entre outros.

- **Apresentação (Presentation)**: Nesta camada, você encontrará os controllers, middlewares, configurações de injeção de dependência e o arquivo 
de inicialização do projeto. É onde a interação com o usuário acontece.

---

<p align="center">
  <img src="https://github.com/lucas-lima-developer/OnionArchitecture/assets/58302967/6f1e1626-37c8-4029-95be-9adeb3de0a87" alt="Imagem 2">
</p>
