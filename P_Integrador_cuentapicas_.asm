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
picas dword ? 
t_digits dword ? 
num_pc dword   4, 5, 9, 6, 8
num_user dword 4, 1, 8, 6, 7                
backup dword ?

.code
	mainP3 PROC
		;Lógica del Programa

		mov esi, offset num_pc	
		mov edi, offset num_user
	
		mov eax, dword ptr[esi]
		mov t_digits, eax; 
				
		add esi, 4 
		add edi, 4

		mov ecx, 0 
		
		ciclo1:
			mov backup, ecx  ; respalda
			mov eax, 4
			mul ecx
			mov ebx, dword ptr[esi + eax]
			
			mov ecx, 0

			ciclo2 :
				mov eax, 4
				mul ecx				
				mov edx, dword ptr[edi + eax]

				cmp ebx, edx

				jnz continuar  ; si es igual
					cmp ecx, backup ; si no es pica
					jz break
						inc picas
					break: ; entra aqui siempre
						mov ecx, t_digits ; para somper el ciclo2

				continuar :
					inc ecx
					cmp ecx, t_digits
					jl ciclo2

			mov ecx, backup
			inc ecx
			cmp ecx, t_digits
			jl ciclo1

		exit	

	mainP3 ENDP
	END mainP3