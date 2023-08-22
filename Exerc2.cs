//Questão 2: 
//Nos conceitos estudados em aula, falamos sobre controller e models. Responda: 
//a)	Defina o papel de cada um e responda por que ao criarmos nosso controller fizemos uma herança de controllerbase? 

//Controller: atua como gerenciador da interface do usuário e a lógica de negócios. Lidando com a lógica de controle e direciona as ações apropriadas com base nas
//solicitações do usuário.
//Models: representa a camada de dados e lógica de negócios da aplicação, geralmente refletem as estruturas de dados subjacentes que a aplicação precisa gerenciar.

//Ao criarmos nosso controller, utilizamos a herança de controllerbase para aproveitar as funcionalidades comuns fornecidas.
//Reduzindo a duplicação e mantendo um padrão no código. A herança fornece métodos e propriedades que são úteis em vários controladores,
//como gerenciamento de autenticação, autorização e manipulação de solicitações HTTP.

//b)	Em sala, mostramos que ao abrir um navegador conseguimos chamar uma rota GET e POST não , explique por que só conseguimos executar a Rota GET no browser. 

//Conseguimos executar somente a Rota GET no browser porque apenas estamos solicitando informações e visualizando os resultados,
//sendo de resposta mais fácil e direta ao usuário, além de não alterar o servidor. No entanto, o método POST é usado para criar ou atualizar recursos que modificam
//o estado do servidor, o que não é tão direto quanto simplesmente inserir a URL na barra de endereços do navegador.


//c)	Qual o papel do Swagger, por que utilizamos ele? 

//Swagger é uma ferramenta de documentar e testar APIs de forma interativa. Melhorando a coordenação entre grupos
//criar documentação clara e interativa para APIs. Isso agiliza o desenvolvimento e a compreensão das APIs.

