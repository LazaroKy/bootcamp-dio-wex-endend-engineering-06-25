## Estrutura de um projeto C#

- Arquivo .csproj 
Contém informações referente a um projeto (Build, Debug, Versão) (1 projeto)  

- Arquivo .sln
Contém informações que carregam um agrupamento de projetos, informando como se relacionam entre si (+1 projeto) (Não obrigatório, usado para automatizar build)  


---
Arquivo .sln pode ajudar a diminuir a duplicação de código  
Cenário: Temos dois projeto que precisam de uma mesma classe, então podemos criar um projeto onde possue a classe que os dois outros projetos podem usar.   

.sln Possui projeto A, Projeto B e Projeto Commom. O projeto Commom usamos como auxiliar, onde não é possível usa-lo sozinho, dependendo de outros projetos. Então os outros projetos possuem uma referência do Projeto Commom (Projeto A-> Projeto Commom), "tendo e usando" o Projeto Commom.   


- Criar um .sln 
```
dotnet new sln -n NomeDaSolucao
```

- Adicionar um projeto à .sln
```
dotnet sln add CaminhoDoProjeto
```

- Adicionar referencia de um projeto em outro (Add reference)
```
dotnet add CaminhoProjetoRecebeReferencia reference CaminhoProjetoReferenciado  (.csproj)
```

- Criar um projeto com versão específica 
```
dotnet new console -n DotNetV5 **--framework** net5.0
```
Versão que você tiver, se não definir a versão ele vai usar a versão mais recente que tiver.  

