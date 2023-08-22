//Questão 4: 
//Em sala mostramos que ao fazer um return da action utilizamos um Status Http , por exemplo, Ok(), BadRequest(), NotFound() , entre outros.
//Especifique a diferença de cada um. 

//Ok() : indicar que uma solicitação foi bem sucedida e o servidor retornou os dados solicitados.
//Usado quando uma operação de busca ou leitura é concluída com sucesso. Status HTTP: 200 OK

//BadRequest() : Indica que a solicitação é inválida ou não pode ser processada pelo servidor.
//Isso pode ocorrer quando parâmetros estão ausentes, inválidos ou não atendem aos requisitos da API. Status HTTP: 400 Bad Request

//NotFound() :  indica que o recurso solicitado não foi encontrado no servidor.
//Usado quando o servidor não consegue encontrar o caminho ou a URL da solicitação. Status HTTP: 404 Not Found
