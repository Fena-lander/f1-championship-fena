# F1-Championship
### Regras de negócio
Calcular os pontos de corrida do campeonato e exibir a tabela de classificação.  
Cada campeonato tem N corridas.  
Cada posição tem uma quantidade de pontos.  
A cada corrida, de acordo com a posição do piloto no grid, os pontos são somados.  
Os dados devem ser persistidos no local de sua prefência (excel, txt, json, sqlite ou whatever).

### Entidades
- Campeonato (Nome do Campeonato)
- Piloto (Nome do Piloto, Número do Carro)
- Corrida (Piloto, Posição no Grid)

### Ações necessárias
- Iniciar campeonato
- Finalizar campeonato
- Adicionar piloto
- Alterar piloto
- Remover piloto
- Adicionar corrida
- Adicionar posição de corrida
	* Exemplo: 	1º: 66¹
- Exibir tabela do campeonato

--------------------------
¹ número do carro do piloto

### Pontos por posição no grid
#### - POS	| PON
- 01	| 25
- 02	| 18
- 03	| 15
- 04	| 12
- 05	| 10
- 06	| 8
- 07	| 6
- 08	| 4
- 09	| 2
- 10	| 1
