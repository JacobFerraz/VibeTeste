## Vibe <br/>
![Vibe](https://i.ibb.co/Mh2Nfjm/vibe.png)

Nesse projeto usei as seguintes tecnologias:

- [.NET Core 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
- [.NET Core 3.0](https://dotnet.microsoft.com/download/dotnet/3.0)
- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [Swagger](https://swagger.io/docs/)
- [Mubblazor](https://mudblazor.com/)
- [Dados Abertos Câmara](https://dadosabertos.camara.leg.br/swagger/api.html)

Boas práticas de desenvolvimento:
- [`SOLID`]
- [`DDD`]
- [`DI`]
- [`Generics`]
- [`Clean Code`]
- [`Layered Architecture`]
- [`Aggregate Pattern`]
- [`MVVM`]

Ferramentas necessárias para executar:
- [`Node LTS`]()
- [`Visual Studio 2019`](https://visualstudio.microsoft.com/pt-br/)

<b>Observação sobre o item 3.1.3 - Totalização das despesas</b>
<h4>Devido a ambiguidade do Item 3.1.3 do processo de seleção foi implementado que a funcionalidade buscar despesas do parlamentar e o cálculo dos últimos DOIS meses, foi gerado a partir dos últimos meses vigentes que o parlamentar possui despesas cadastradas no sistema da câmara, em vez do cálculo em cima das despesas do mês ATUAL e do mês RETRASADO, visto que a maioria dos parlamentares não possuía despesas cadastradas em Abril, Março de 2021.</h4>

## Instalar e Executar

Como executar o projeto:
```bash
# Instalar ASP.NET e Desenvolvimento Web no Visual Studio 2019
# Instalar Desenvolvimento em NodeJS

# Repositórios para clone
- https://dev.azure.com/JacobFerraz/_git/VibeTeste
- https://github.com/JacobFerraz/VibeTeste

# Executar 
1. [Abrir o projeto no Visual Studio 2019]
2. [Recompilar a solução
3. [Na solução VibeTest -> propriedades ]
4. [Marcar Vários projetos de inicialização]
5. [Selecionar VibeTest.API e VibeTest.Web como 'Iniciar' e aplicar]


```
<img src="https://s3.gifyu.com/images/compilarSolucao.gif" alt="drawing" width="1000"/>
