TITLE Trabajo 1
;DESCRPICIÓN 
;Objetivo: Primera ejecúción de masm
;
; Autore(s):
;         García Ruiz Alejandro H.
; Semestre: 8vo Semestre ISC 
;FIN DESCRPICIÓN
INCLUDE Irvine32.inc  
.data
; Área de Declaración de Variables
res dword ? 
t_ciclo1 dword ? 
t_ciclo2 dword ? 
vector dword 4,1, 4, 6, 8
backup dword ? 

.code
	mainP PROC
		;Lógica del Programa

		mov esi, offset vector	
		
		mov eax, dword ptr[esi] 
		mov t_ciclo2, eax;
		dec eax
		mov t_ciclo1, eax

		cmp t_ciclo2, 0 
		
		jg valida_numero
			jmp no_valido

		valida_numero :		
		
			add esi, 4 

			mov ecx, 0 
					
		ciclo1:	
			mov backup, ecx ;respalda
			mov eax, 4
			mul ecx 
			mov ebx, dword ptr[esi + eax] 	 
			inc ecx 
			
			ciclo2 :
				mov eax, 4
				mul ecx
				mov eax, dword ptr[esi + eax]

				cmp ebx, eax

				jz no_valido

				inc ecx
				cmp ecx, t_ciclo2

				jl ciclo2
			

			mov ecx, backup 
			inc ecx
			cmp ecx, t_ciclo1
			jl ciclo1
					
		mov res, 100
		
		
		jmp salir

	no_valido:
		mov res, 0 
	
	salir:
		
	mov eax, res
	call writedec

		exit	

	mainP ENDP
	END mainP