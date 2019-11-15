#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "LinkedList.h"
#include "controller.h"
#include "Empleado.h"
#include "utn.h"


static int idGen = 0;

int employee_generaId(void)
{
    return idGen++;
}

 void employee_setIdInicial(int value)
{
    idGen = value;
}

Empleado* employee_new()
{
	return (Empleado*)malloc(sizeof(Empleado));

}

Empleado* employee_newParametros(char* idStr,char* nombreStr,char* horasTrabajadasStr)
{
	Empleado* emp = employee_new();
	if(emp != NULL)
	{
		employee_setIdStr(emp, idStr);
		employee_setNombre(emp, nombreStr);
		employee_setHorasTrabajadasStr( emp, horasTrabajadasStr);

	}
	return emp;
}

int employee_delete(Empleado* this)
{
	int retorno = -1;
	if(this != NULL)
	{
		free(this);
		retorno = 0;
	}
	return retorno;
}

int employee_setIdStr(Empleado* this,char* id)
{
    int retorno = -1;
    int idAux;
    if(this != NULL)
    {
        if(isValidNumber(id))
        {
            idAux = atoi(id);
            this->id = idAux;
            retorno = 0;
        }
    }
    return retorno;
}

int employee_setId(Empleado* this,int id)
{
    int ret=-1;
    if(this!=NULL && id>=0)
    {
        this->id=id;
        ret=0;
    }
    return ret;
}

int employee_getId(Empleado* this,int* id)
{
	int ret = -1;

	if(this != NULL && id > 0)
	{
		*id = this->id;
		ret = 0;
	}
	return ret;
}

int employee_setNombre(Empleado* this,char* nombre)
{
    int retorno = -1;
    if(this != NULL)
    {
        if(isValidName(nombre))
        {
            strncpy(this->nombre,nombre,sizeof(this->nombre));
            retorno = 0;
        }

    }
    return retorno;
}


int employee_getNombre(Empleado* this,char* nombre)
{
    int retorno = -1;
    if(this != NULL)
    {
        strncpy(nombre,this->nombre,sizeof(this->nombre));
        retorno = 0;
    }
    return retorno;
}

int employee_setHorasTrabajadasStr(Empleado* this,char* horasTrabajadas)
{
    int retorno = -1;
    int horasAux;
    if(this != NULL)
    {
        if(isValidNumber(horasTrabajadas))
        {
            horasAux = atoi(horasTrabajadas);
            this->horasTrabajadas = horasAux;
            retorno = 0;
        }
    }
    return retorno;
}

int employee_getHorasTrabajadas(Empleado* this,int* horasTrabajadas)
{
	int ret = 0;

	if(this != NULL && horasTrabajadas > 0)
	{
		*horasTrabajadas = this->horasTrabajadas;
		ret = 1;
	}
	return ret;
}

int employee_findEmployeeById(LinkedList* pArrayListEmployee, int id)
{
    int ret = -1;
    int i;
    Empleado* pEmployee;
    int auxId;
    int len;

    if (pArrayListEmployee != NULL && id >= 0)
    {
        len = ll_len(pArrayListEmployee);

        for (i = 0;i < len;i++)
        {
            pEmployee = ll_get(pArrayListEmployee,i);
            employee_getId(pEmployee,&auxId);

            if (id==auxId)
            {
                ret = i;
                break;
            }
        }
    }
    else
    {
        printf("\nLa lista esta vacia");
    }
    return ret;
}

int employee_comparaPorNombre(void *pPersonaA,void *pPersonaB)
{
    int retorno = 0;

    if(strcmp(((Empleado*)pPersonaA)->nombre,((Empleado*)pPersonaB)->nombre) > 0)
    {
    	retorno = 1;
    }
    if(strcmp(((Empleado*)pPersonaA)->nombre,((Empleado*)pPersonaB)->nombre) < 0)
    {
    	retorno = -1;
    }

    return retorno;
}
/*void em_calcularSueldo(void* p)
{
	// recibo elemento empleado como void.
	// hacer calculo de sueldo y escribirlo en campo sueldo del empleado

}*/

/*int funcionCriterioFiltro(void* p)
{
	Empleado* pe = ()
 }
*/
