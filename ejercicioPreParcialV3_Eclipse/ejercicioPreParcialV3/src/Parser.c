#include <stdio.h>
#include <stdlib.h>
#include "LinkedList.h"
#include "Empleado.h"

int parser_parseEmpleados(FILE* pFile, LinkedList* listaEmpleados)
{
	int ret= 0;
	char bufferId[4096];
	char bufferNombre[4096];
	char bufferHorasTrabajadas[4096];

	Empleado *pEmpleado;

	if(pFile!=NULL && listaEmpleados != NULL)
	{
		fscanf(pFile,"[^\n]\n");
		while(!feof(pFile))
		{
			fscanf(pFile,"%[^,],%[^,],%[^\n]\n",  bufferId,
					bufferNombre,
					bufferHorasTrabajadas);

			pEmpleado = employee_newParametros(bufferId,bufferNombre,bufferHorasTrabajadas);

			if(pEmpleado != NULL)
			{
				if(!ll_add(listaEmpleados,pEmpleado))
				{
						ret++;
				}
			}
		}
	}
	return ret;
}

