# Bancos de dados relacionais

### Organização do SQL
- DQL - Linguagem de consulta de dados
    - SELECT
- DML - Linguagem de manipulação de dados
    - INSERT, UPDATE e DELETE
- DDL - Linguagem de definição de dados
    - CREATE, ALTER, DROP
- DCL - Linguagem de controle de dados
    - GRANT, REVOKE
- DTL - Linguagem de transação de dados
    - BEGIN, COMMIT, ROLLBACK

### Convenções
- Os nomes devem começar com uma letra ou com o caractere underline `_`
- Os nomes podem conter letras, números e caracteres de underline
- Sensibilidade a maiúsculas e minúsculas. 

### MER (Modelo entidade relacionamento) - DER (Diagramas entidade relacionamento)

- O MER é representando através de diagramas chamados DER. 

#### Relacionamentos:
São associações entre as entidades. 
- Cardinalidade dos relacionamento:
    - 0..N (Zero para muito) - Quando o relacionamento não é obrigatório entre as entidades
    - 1..1 (Um para um) 
    - 1..N ou 1..* (Um para muitos)
    - N..N ou *..* (Muitos para muitos)

#### Tabelas:
Usada para armazenar dados de forma organizada. Cada tabela em um banco de dados possui um nome único e é dividida em colunas e linhas.

#### Colunas:
Estrutura dentro da tabela que representa um atributo específico. Possui um nome único na tabela e um tipo de dado.

#### Registros:
Linhas ou tuplas, é a instância individual de um dado representado pela tabela. 


### SQL:

- Criação de tabela:
```sql
CREATE TABLE db.<nome_tabela>  (
    <nome_coluna> <tipo(LIMITE)> <outras_definições> COMMENT 'comentário',
    ...
);
```

- Inserir dados:
```sql
INSERT INTO db.<nome_tabela>  
    (coluna_tal,nome_outra_coluna)
    VALUES 
    (valor_coluna_tal,valor_outra_coluna);
```

- Buscar dados:
```sql
SELECT 
-- tudo sinalizado com o `*` ou colunas específicas
 *
 FROM <nome_tabela>
;
```

- Atualizar dados:
> Atenção ao executar o update
```sql
UPDATE <nome_tabela> 
SET <coluna_um> = <novo_valor_coluna_1>
...
WHERE <condição>;
```

- Apagar dados:
> Atenção ao executar o delete
```sql
DELETE FROM <nome_tabela>
WHERE <condição>;
```
> Tenha um backup do banco do estado anterior. Ou faça com que o commit seja manual, por assim dizer.

- Alterar estrutura de uma tabela:
```sql 
ALTER TABLE <nome_tabela> RENAME <novo_nome_tabela>;
ALTER TABLE <nome_tabela> MODIFY <nome_coluna> <definições>;

```
> Usado para adicionar, alterar ou excluir colunas, modificar restrições, índicies, nome da tabela..

- Operadores:
    - = (Igualdade)
    - <> ou ! (Desigualdade)
    - \> (Maior que)
    - < (Menor que)
    - \>= (Maior ou igual que)
    - <= (Menor ou igual que)
    - LIKE (Comparação de padrões)
    - IN (Pertence a uma lista de valores)
    - BETWEEN (Dentro de um intervalo)
    - AND (E lógico)
    - OR (Or lógico)


- Possíveis definições das colunas:
    - NOT NULL
    - UNIQUE
    - DEFAULT
    - PK, FK
    - AUTO INCREMENT
    - ON DELETE
    - ON UPDATE
    - CASCADE
    - SET NULL
    - SET DEFAULT
    - RESTRICT

### Tipos de dados:
- Integer 
- Decimal/Numeric
- Character/Varchar
- DateTime/Instant
- Boolean
- Text

#### Primary Key
- Única, não nula, facilita na identificação de um registro

#### Foreing Key
- Usada para estabelecer e manter relação entre tabelas. 
- Pode ser nula e possível ter mais de uma em uma tabela

### Formas normais:
- 1FN: Atomicdade dos dados
    Cada valor em uma tabela deve ser indivisível. Nenhum campo deve conter múltiplos valores ou listas.  
- 2FN: Todos os atributos não chave devem depender totalemnte da chave primária. 
- 3FN: Todas as colunas não chaves devem depender da coluna chave, e não de colunas não chaves.

### Junções:
#### Join:
Usados para combinar dados de duas ou mais tabelas em uma única consulta
- Tipos: 
    - INNER JOIN
    - LEFT JOIN OU LEFT OUTER JOIN
    - RIGHT JOIN OU RIGHT OUTER JOIN
    - FULL JOIN OU FULL OUTER JOIN

#### INNER JOIN:
- Retorna apenas as linhas que têm correspondência em ambas as tabelas envolvidas na junção. A junção é feita com base em uma condição de igualdade especificada com ON.
```sql
SELECT *
FROM <tabela_um>
INNER JOIN <tabela_dois> ON <tabela_um.<coluna>> = <tabela_dois.<coluna>>;
```

#### LEFT JOIN:
- Retorna todas linhas da tabela da esquerda que têm correspondência em ambas as tabelas envolvidas na junção e as linhas correspondentes da tabela da direita. Se não tiver correspondente, considerado como null.
```sql
SELECT *
FROM <tabela_um>
LEFT JOIN <tabela_dois> ON <tabela_um.<coluna>> = <tabela_dois.<coluna>>;
```

#### RIGHT JOIN:
- Retorna todas linhas da tabela da direita que têm correspondência em ambas as tabelas envolvidas na junção e as linhas correspondentes da tabela da esquerda. Se não tiver correspondente, considerado como null.
```sql
SELECT *
FROM <tabela_um>
RIGHT JOIN <tabela_dois> ON <tabela_um.<coluna>> = <tabela_dois.<coluna>>;
```

#### FULL JOIN:
- Retorna todas linhas de ambas tabelas, combinando as que têm correspondência em ambas as tabelas envolvidas na junção. Quais não tiverem correspondencia fica considerado como null.
```sql
SELECT *
FROM <tabela_um>
FULL JOIN <tabela_dois> ON <tabela_um.<coluna>> = <tabela_dois.<coluna>>;
```

### Funções agregadas
- `COUNT()` - Conta p múmero de resgistro.
- `SUM()` - Soma os valores de uma coluna númerica.
- `AVG()` - Calcula a média dos valores de uma coluna númerica.
- `MIN()` - Retorna o valor máximo de uma coluna. 
- `MAX()` - Retorna o valor máximo de uma coluna.

> Pode buscar os resultados de funções em colunas e nomear com `AS <nome_para_resultado>`.

- `GROUP BY` - Agrupamento de resultados
```sql
SELECT * FROM <tabela>
GROUP BY <coluna_um>;
```

- `ORDER BY` - Ordenação de resultados 
```sql
SELECT * FROM <tabela>
ORDER BY <coluna_um> ASC/DESC;
```

### Análise de execução de Query + Índicies:
Permite examinar as operações realizadas, tabelas acessadas, índicies utilizados outras informações que auxiliam a identificar possíveis otimizações de desempenho. O uso de índices facilita busca pelo atributo.

- Comando `EXPLAIN` antes da query;
- Informações que obtemos: 
    - Tipo de select: SIMPLE, SUBQUERY, JOIN.
    - Tabelas interagidas.
    - Tipo de tabela (ALL, INDEX,..) - diz respeito as colunas retornadas.
    - Possíveis chaves: Índices que poderiam ser usados nessa operação.
    - Chave: índice utilizado na operação
    - Comprimento da chave: Comprimento do índice utilizado. (Cuidado com full scan)
    - ref: Mostra quais colunas ou constantes estão sendo comparadas com o índice (ex.: const, table.col).
    - rows: Estimativa de quantas linhas serão lidas para executar a operação.

### "Peculiaridades" de alguns sistemas de gerenciamento:
- Postgresql possui a palavra user como palavra reservada, então não crie entidade com esse nome, ou altere manualmente o nome da tabela. 


## Plataformas para criar diagramas
- https://app.creately.com/
- https://app.quickdatabasediagrams.com/#/

## Banco de dados na nuvem (Limite de gratuidade de 7d)
- https://www.cloudclusters.io/cloud-database/