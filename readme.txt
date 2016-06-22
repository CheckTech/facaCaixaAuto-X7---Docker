          ### Introdução ###

GFV630 Gerador de corte e vinco para coreldraw x6 gera embalagem fundo automático e fundo semi-automático 




          ### Requisitos ###

Coreldraw X6 ou X6.1 



          ### Demostração ###

https://www.youtube.com/watch?v=ToxG5D2dZM8



          ### Notas de desenvolvimento ###

* Executar testes criandos embalagens com comprimento maior que a largura, comprimento menor que a largura e comprimento igual a largura, este é base da caixa, para verificar o fechamento correto da caixa.
* Foi seguido as instruções contidas neste site, para a criação das embalagens.
http://puclabdesign.blogspot.com
* O código base para o desenvolvimento ainda não está completamente pronto e em fase de teste, estou desenvolvendo um código para facilitar a criação de novos tipos de embalagens de maneira rápida.




	  ### Notas da versão ###

Versão 1.0 beta somente testes
*----------------------------------------------------------------------------------------*
*Gera corte e vinco para embalagem com fundo automático.
*Gera corte e vinco para embalagem com fundo semi-automático ou americano

*----------------------------------------------------------------------------------------*



          ### Instalação ###

Método 1:
Se seu corel for português.
Copiar o "FacaLoaderBR" e "facaCaixaAuto" para a pasta "User\Documents\Corel\VSTA\CorelDRAW\Addins". 
Se for em inglês.
Copiar o "FacaLoaderEN" e "facaCaixaAuto" para a pasta "User\Documents\Corel\VSTA\CorelDRAW\Addins". 
Enjoy!


Método 2:
Se o método 1 não funcionou a dll FacaLoader não é compatível com o seu corel, então utilize este método.
Extraia a dll facaCaixaAuto para uma pasta de sua escolha, abra o corel e vá Ferramentas->Personalização->Barras de comando, clique em novo e de um nome de sua preferencia, clique em ok, agora abra o editor de macros, ferramentas->editor de macros, crie um novo projeto ou escolha GlobalMacros->CorelDraw x6 Objetos->ThisMacroStorage.
Adicione o seguinte código observe as maiúsculas:

Sub teste()
    Call FrameWork.CommandBars("Nome da Barra que você criou anteriormente").Controls.AddCustomControl("Bonus630.vsta.FacaCaixaAuto.FacaCaixaAuto", "Pasta que você extraiu a dll\facaCaixaAuto.dll")
 
End Sub

Clique no botão play ou tecle f5, as vezes acontece um erro mais mesmo assim a barra aparece, e fim!

Em seu computador precisa estar instalado o visual basic for application do corel que pode ser marcado no momento da instalação do mesmo e também o corel Photo-Paint senão a barra pode ficar vazia.


          ### Observações ###

Espero contar com ajuda de profissional que trabalhem com criação de embalagens, para corrigir bugs e fazer melhorias e novas funcionalidades




          ### Contato ###

http://bonus630.tk
Bonus630@gmail.com
