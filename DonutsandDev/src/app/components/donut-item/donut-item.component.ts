import { Component, Input } from '@angular/core';
import { Result } from '../../models/donut-model';

@Component({
  selector: 'app-donut-item',
  standalone: true,
  imports: [],
  templateUrl: './donut-item.component.html',
  styleUrl: './donut-item.component.css'
})
export class DonutItemComponent {
  @Input() DisplayDonut:Result = {} as Result;
}
