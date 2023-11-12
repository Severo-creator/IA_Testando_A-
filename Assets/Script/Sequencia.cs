using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencia : Tarefa
{
    private Tarefa[] subtarefas = new Tarefa[5];
    private int NumeroTarefas;

    Sequencia(Tarefa[] s , int n){
        this.subtarefas = s;
        this.NumeroTarefas = n;
    }

   public bool Condition(){
        return true;
    }

    public override bool Executa(){
        int aux = 0;
        for(int i=0; i < NumeroTarefas; i++){
            if(subtarefas[i].Executa()){
                if(subtarefas[i].GetType().Name.Equals("Condicao")){

                }
                aux++;
            }
        }
        if(aux == NumeroTarefas){
            return true;
        }

        return false;
    }
}
