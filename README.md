# desafio-pratico-gerenciador-tarefas
Rocketseat - TRILHA C#

## Introdução

Faaaaala, Dev! Chegou a hora de por a mão na massa e aplicar de forma prática os conceitos aprendidos nesse módulo! 🚀

Lembre-se que o intuito de um desafio é te impulsionar e ir além, por isso, dependendo do desafio, pode ser que você precise ir além do que foi discutido em sala de aula. 
Mas isso não é algo ruim: ter autonomia para buscar informações extras é uma habilidade muito valiosa e vai ser ótimo pra você treinar ela aqui com a gente!

E lembre-se: **tenha calma**! Isso faz **parte do processo**!
Enfrentar desafios faz parte do seu caminho de aprendizado! 

Se precisar de alguma orientação ou suporte, estamos aqui com você!
Bons estudos e boa prática! 💜

---

### Descrição

Seu principal objetivo é desenvolver uma API para um sistema Gerenciador de tarefas.
O sistema deve permitir que o usuário crie, visualize, edite e exclua uma tarefa.

Bora para os requisitos desse desafio? 🚀

---

### Requisitos

Como visto em aula, é uma boa prática dividirmos a nossa aplicação em camadas. 
Por isso, o seu projeto deve conter: 

**Camada de comunicação**

**Camada de regras de negócios**

---

Uma tarefa deverá ter os seguintes campos:

- Um id único pra identificar cada tarefa;
- Um nome;
- Uma descrição sobre o que é a tarefa em si;
- Uma prioridade;
*Você pode definir se tem prioridade* `alta`, `média` *ou* `baixa`*, por exemplo;*
- Uma data limite para tarefa ser realizada;
- Um status.
*Você pode definir três status:* `concluída`*,* `em andamento` *e* `aguardando`*, por exemplo.*

---

- Deve ser possível criar uma tarefa;
- Deve ser possível visualizar todas as tarefas criadas;
- Deve ser possível visualizar uma tarefa buscando pelo seu id;
- Deve ser possível editar informações de uma tarefa;
- Deve ser possível excluir uma tarefa.
