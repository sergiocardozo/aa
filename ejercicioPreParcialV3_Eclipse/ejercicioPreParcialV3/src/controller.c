/*
 * controller.c
 *
 *  Created on: 14 nov. 2019
 *      Author: alumno
 */
#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include <string.h>
#include "LinkedList.h"
#include "Empleado.h"
#include "Parser.h"

/** \brief Carga los datos de los empleados desde el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_loadFromText(char* path , LinkedList* pArrayListEmployee)
{
	FILE* pFile;
	int retorno = -1;
	if(pArrayListEmployee != NULL)
	{
		pFile = fopen(path,"r");
		if(pFile != NULL)
		{
			retorno = parser_parseEmpleados(pFile,pArrayListEmployee);
			fclose(pFile);
		}
	}
	return retorno;
}
