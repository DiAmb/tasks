import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TaskService } from 'src/app/services/task.service';

interface Task {
  id: number;
  name: string;
}

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css'],
})
export class TaskComponent implements OnInit {
  taskForm: FormGroup;
  tasks: Task[] = [];

  constructor(private fb: FormBuilder, private taskService: TaskService) {
    this.taskForm = this.fb.group({
      name: ['', [Validators.required, Validators.maxLength(100)]],
    });
  }

  ngOnInit(): void {
    this.loadTasks();
  }

  loadTasks() {
    this.taskService.getTasks().subscribe((data) => {
      this.tasks = data.reverse();
    });
  }

  addTask() {
    if (this.taskForm.invalid) {
      return;
    }

    const name = this.taskForm.value.name;
    this.taskService.addTask(name).subscribe((task) => {
      this.tasks.unshift(task);
      this.taskForm.reset();
    });
  }

  deleteTask(id: number) {
    this.taskService.deleteTask(id).subscribe(() => {
      this.tasks = this.tasks.filter((t) => t.id !== id);
    });
  }
}
