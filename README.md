# Domain Driven Design (DDD) Clean Architecture
## “Show me the code” – Full Stack

_**Nota**: Algumas informações últeis para um melhor entendimento do escopo tecnológico 
do projeto. Caso queira somente executar o projeto vá direto para a sessão **RUN PROJECT**._

## STACK OF DEPENDENCY (Clean Architecture)

VxTel.FaleMais
- VxTel.FaleMais.Domain
- VxTel.FaleMais.Application depends of (VxTel.FaleMais.Domain)
- VxTel.FaleMais.Infra.Data depends of (VxTel.FaleMais.Domain)
- VxTel.FaleMais.Infra.IoC depends of (VxTel.FaleMais.Domain, VxTel.FaleMais.Application, VxTel.FaleMais.Infra.Data)
- VxTel.FaleMais.UI depends of (VxTel.FaleMais.Infra.IoC)		
- VxTel.FaleMais.WebAPI depends of (VxTel.FaleMais.Infra.IoC)	
- VxTel.FaleMais.UnitTestDefault depends of (VxTel.FaleMais.Domain)

## DATABASE:

**Report de dados da aplicação**

```sql
SELECT 
ex.[Id],
ex.[Description],
ex.OriginId,
o.Code AS OriginCode, 
o.Description AS OriginDescription,
ex.DestinyId,
d.Code AS DestinyCode, 
d.Description AS DestinyDescription, 
ex.MinutePriceId,
r.[Price],
r.[Description] AS PriceDescription
FROM [dbo].[ExceedingMinutes] ex 
INNER JOIN [dbo].[AreaCodes] o ON ex.OriginId = o.Id
INNER JOIN [dbo].[AreaCodes] d ON ex.DestinyId = d.Id 
INNER JOIN [dbo].[Rates] r ON ex.MinutePriceId = r.Id;
```

## USER INTERFACE:

**Fale Mais UI**
https://localhost:5001/

**Fale Mais WebAPI**
http://localhost:55418/swagger

**Formato enviado pela WebAPI**
OriginId integer($int32) = 1
DestinyId integer($int32) = 2
TimeInMinutes integer($int32) = 20
PlanId integer($int32) = 1

**Formato retornado pela WebAPI**
```json
[
  {
    "id": 1,
    "description": "VXFLMEXCMIN011016",
    "originId": 1,
    "origin": {
      "id": 1,
      "code": "011",
      "description": "Código da Área 11"
    },
    "destinyId": 2,
    "destiny": {
      "id": 2,
      "code": "016",
      "description": "Código da Área 16"
    },
    "minutePriceId": 1,
    "minutePrice": {
      "id": 1,
      "description": "VXFLM190",
      "price": 1.9
    },
    "amountPayable": 38,
    "amountPayableWithPlan": 0,
    "timeInMinutes": 20,
    "planDescription": "FaleMais 30 (30 minutos)"
  }
]
```

## RUN PROJECT (VS2019 Community)

- passo 1: Conferir se a connection string está devidamente apontada pra o DB alvo.
```json
{"ConnectionStrings": {
	"DefaultConnection": "Server=localhost\\MSSQLSERVER01;Database=VxTelFaleMaisDB;Trusted_Connection=True;"
}}
```
- passo 2: Executar via cli no console do gerenciador de pacotes com o projeto 
padrão VxTel.FaleMais.Infra.Data.
```cli
PM> add-migration CriarDBEPopularTabelas
PM> update-database
```
- passo 3: Definir o VxTel.FaleMais.UI como projeto de inicilização.
- passo 4: Limpar e Compilar toda a Solução.
- passo 5: Executar o Projeto (https://localhost:5001)
- passo 6 (opicional): Executar WebAPI Clicar com o botão direito no projeto VxTel.FaleMais.WebAPI e selecionar Depurar -> Iniciar Nova Instância. (http://localhost:55418/swagger)

## RUN UNIT TEST (VS2019 Community)

Os testes podem ser executados de duas maneiras:	
- maneira 1: Clicar com o botão direito no projeto VxTel.FaleMais.UnitTestDefault e selecionar Executar Testes.
- maneira 2: Clicar em Teste na barra de ferrametas -> Executar Todos os Testes.

**By, Jonathan de Oliveira**
