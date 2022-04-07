# Anotações das reuniões

## 2021-03-24  

### Continuar com o TCC  

Novamente questionei se queria manter o mesmo orientador, e se queria manter o mesmo tema do projeto.  
Comentei que poderia optar por mudar o orientador e/ou o tema sem problema algum.  

### Estatos atual  

Pedi para mostrar que tinha desenvolvido desde dezembro do ano anterior.  
Produziu algo, mas pouco pelo tempo que deveria ter se dedicado ao TCC.  
Fez:  

- aparece um cubo no espaço 3D  
- um canvas com a matriz 4x4 mostrando a matriz identidade  
- botões para mudar cor do objeto, remover/inserir objeto, e multiplicar matriz  
- Tem um outro canvas com 4x4 * 4x4 = 4x4 para somar, subtrair e multiplicar matrizes)  

O uso da matriz de transformação parece ter erros.  
E também a multilicação das matrizes. Mencionei que só usamos a multiplicação.  

### fazer  

1. SRU (fixo)  
2. Arrumar as transformações e cálculca  
3. tutorial (animação) mostrar multiplicação (ex. videos, Geogebra)  

---------

## 2021-08-12

Foi informado pelo professor de TCC2 que o orientando reapresentou o projeto sob indicação do professor de TCC2.  
Mas o professor de TCC2 encontrou alterações no conteúdo do projeto, e me consultou se eu tinha revisado o projeto.  
Respondi que o orientando não tinha entrado em contato comigo.  
O professor de TCC2 respondeu [2021-08-12_EMailTCC2_enviouProjetoSemOrientadorRevisar](2021-08-12_EMailTCC2_enviouProjetoSemOrientadorRevisar.pdf "2021-08-12_EMailTCC2_enviouProjetoSemOrientadorRevisar").  

## 2021-08-24

Voltou...  
Subir o código no Git.  
[x] Tutorial: hints para mostrar o que foi usado para fazer o caculo da matriz.
[ ] Tutorial: usar video.  
[ ] Vai usar este tutorial para fazer o Spline: <https://catlikecoding.com/unity/tutorials/curves-and-splines/>  
[ ] Perguntou o que fazer a mais ...  
[ ] Disse daqui uns dias olharmos o projeto e o que foi gravado em: [2020-09-09_Reuniao.m4a](2020-09-09_Reuniao.m4a "2020-09-09_Reuniao.m4a").  

## 2021-08-31

[x] Arrumou setas usando RGB.  
[x] Tutorial: hints para mostrar o que foi usado para fazer o caculo da matriz.
  [ ] Está fazendo os Hints da tabela de calculo. Vai mlehorar mostrando cores para saber qual linha com qual coluna.  

## ATENÇÃO

[@BrunoPG] pedir para remover pasta https://github.com/BrunoPG/BrunoPereiraGibicoski/tree/master/Library
do Git dele.. conferir as outras.

## 2021-09-14

[ ] Tutorial: usar video.  Funciona, teve que autalizar o Unity e o render para Vulkan.  
[x] Otimizou o código para os Hitens ... otimizou.  

## 2021-09-21

Disse que não produziu muito e não precisava de reunião.  

## 2021-09-28

Arrumou um pouco mais a parte do play do video para o tutorial.  
Vai usar um programa para editar os videos dos tutorias para colocar umas legendas, etc.  

Spline fez. Vai fazer o tutorial para spline.  
Tutorial na spline.  

## 2021-10-05

- desmarquei.  

## 2021-10-12

- feriado.  

## 2021-10-19

Vai terminar as rotinas e me avisar que tem uma versão no GitHub para eu testar.  

## 2021-10-26

Oi Bruno Pereira Gibicoski, hoje as 22:00 tenho bancas de TCC1 e não vou conseguir conversar contigo hoje.  
Faz assim, continua trabalhando nas rotinas que ainda faltam para terminar ... mas tenta voltar a pegar o texto. Procura produzir um pouco do conteúdo do artigo ... principalmente da seção 3.  
Se julgares que precisamos remarcar a reunião de hoje em um outro dia/horário me avise.  

## 2021-11-09

Porque tem um ".gitignore" com extensão "txt"?  
Do audio já passado que descrevo o que seri aum TCC o que realmente fez?  
[Audio](<https://github.com/dalton-reis/tcc_BrunoPereiraGibicoski/blob/master/_dalton/2020-09-09_Reuniao.m4a> "Audio")  

- [+/-] Como não integrou ao código já existente do TCC anterior deveria ter mais funções.  
- Matriz 4x4  
  - o que seria o texto "Demo"?  
    .. remover e melhorar o texto que exibe a posição do objeto no espaço.  
  - "descrever" que pode selecionar os objetos com o click esq mouse.  
  - "descrever" que pode mover a câmera com o click dir mouse.  
  - colocar um borda para realçar o objeto selecionado.  
  - texto dos botões em português e inglês!  
  - tratar conflito entre selecionar botão (no canvas) também seleciona um bojeto atrás.  
  - [e] falta a transparência da cor.  
  - não entendi como usa o botão "Transposta" para explicar algo na área de CG.  
  - no botão "calculo" ... que está escrito errado "cálculo".  
    - REMOVER -> para que seria o botão "Somar" e Subtrair" para explicar algo na área de CG.  
    - deixar sempre a segunda da multiplicação como matriz identidade.  
      - segunda matriz do "Cálculo".  
  - botão resetar câmera.  
  - Spline  
    - qual foi o critério da escolha da posição (x,y,z) dos pontos de controle?  
      usar a posição dos veétices das figuras geométricas (triângulo, quadrado, ) .. levar p/ o artigo.  
      - me parece que está com erro quando se tem mais pontos de controle.  
    - não tem como mudar os valores dos pontos de controle? Vai arrumar.  
  - botão resetar câmera.  
  - Tutorial  .. ajustar.  
    - eram o vídeos, mas como eu uso?  

- Deploy:  
  - [ ] Android (erro).  
  - [ ] iOS
  - [x] Windows  
  - [ ] MacOS
  - [ ] WebGL (erro).

  O que poderia ser melhorado:
Extensão:
  - ter um controle de câmera melhor ... poder ter câmera do tipo Study, Zoom Extend, etc.  

# 2021-11-16

Não fizemos reunião porque ainda tinha "tarefas" para fazer da última reunião. Remarcarmos para sexta.  
Me passou o que está fazendo: _________________  
só pra te atualizar, o que falta é:  
segunda matriz do "Cálculo". - > ja consi...  
segunda matriz do "Cálculo". - > ja consigo criar o ponto e interagir com ele, mas ainda falta a parte do cálculo  
me parece que está com erro quando se tem...  
me parece que está com erro quando se tem mais pontos de controle. -> tem um erro no calculo das splines para splines com 7 ou mais pontos de apoio  
tratar conflito entre selecionar botão (n...  
tratar conflito entre selecionar botão (no canvas) também seleciona um bojeto atrás. -> falta corrigir isso  
e só, todos os outros itens ja estão pronto...  
e só, todos os outros itens ja estão prontos e funcionais  
até a transparência  
fiz um "help" no paint pra demonstrar os co... , com um anexo.  
fiz um "help" no paint pra demonstrar os comandos e criei um botão dedicado  
  help.png  
ah, uma duvida que queria ver contigo, o na multiplicação do ponto, quando tiver selecionando um ponto e apertar em multiplicar, é para abrir uma tela de multiplicação entre uma matriz 4x4 e uma matriz 1x4 referente ao ponto  
o resultado disso, é pra ser uma matriz que vai substituir o ponto, certo?  
digo, um objeto gráfico com a matriz 4x4  
só pra confirmar se entendi corretamente  

## 2022-03-16

Não mexeu nada do semestre anterior.  
Arrumou o GitHub.  
@dalton-reis: vai olhar o que ele fez na implementação.  Baixar o novo fonte od GitHub.  

Vai trabalhar no artigo.  
<https://github.com/BrunoPG/BrunoPereiraGibicoski/blob/master/Artigo/TccArtigo.docx>  

## 2022-03-23

Conversamos um pouco ... sobre sua situação.  
Ofereci o atendimento presencial.  
Disse que estava tendo auxilio de um pscicologo, mas só tinha ido dois encontros (nas segundas).  

Pedi para produzir o texto, e não fez cada nada.  
Trabalhando no Texto: prazo 2 semanas para terminar o Requisitos.  

## 2022-03-30

Não fez nada e não tinha dúvidas e pediu para usar as duas semanas que era para fazer a especificação. Então na próxima semana vai entregar algo.  

## 2022-04-06

Não fez nada do texto.  Disse que mexeu um pouco arrumando o código e comentado. Mas do texto não mexeu.  
Comentou novamente que falou com a Psicologa que deu sujestões para melhorar.  
Vai tentar seguir as dicas da Psicologa e produzir alguma coisa para próxima semana.  
Questionei se queria vir presencial.  
