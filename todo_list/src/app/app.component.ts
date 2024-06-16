import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Todo } from './models/todo';
import { CurrencyPipe, DecimalPipe } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, DecimalPipe, FormsModule], //decimal pipe for | number import
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'todo_list';
  
  todo: Todo[] = [
    {
      task: 'Code the assignmnet',
      completed: true,
      duration: 4,
      priority:"HIGH",
    },
    { task: 'put clothes in dresser', completed: false, duration: 0.5, priority:"LOW"},
    { task: 'call family', completed: true, duration: 2 , priority:"NORMAL"},
    { task: 'play call of duty', completed: false, duration: 1, priority:'HIGH'},
    { task: 'apply for job', completed: false, duration: 3.5, priority:"NORMAL"},
    { task: 'Sleep 8hrs', completed: true, duration: 8, priority:"LOW"},
  ];

  formTask:Todo = {} as Todo;//create an object

  AddTodo():void{
    let currenttask:Todo = {...this.formTask};
    currenttask.completed=false;
    this.todo.push(currenttask);
  }

  deletetask(targettodo:Todo):void{
    let index = this.todo.findIndex(p=>p==targettodo)
    this.todo.splice(index,1);//delete item from that index
  }

  completetask(targettodo:Todo):void{
    targettodo.completed = true;
  }

  IsListCompleted():boolean {
    //No items
    if(this.todo.length == 0){
      return true;
    }
    //any incomplete
    let allComplete:boolean = true;
    this.todo.forEach((t:Todo) =>{
      if(t.completed == false){
        allComplete = false;
      }
    });
    //all complete
    return allComplete;
  }

  filter:string = '';
  GetFiltered():Todo[] {
    if(this.filter==""){
      return this.todo;
    }
    else{
      return this.todo.filter((t:Todo)=>t.task.toLocaleLowerCase().includes(this.filter));
    }
  }

}
