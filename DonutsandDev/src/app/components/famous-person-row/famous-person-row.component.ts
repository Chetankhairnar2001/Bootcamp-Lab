import { Component, Input } from '@angular/core';
import { Complete } from '../../models/dev-model';

@Component({
  selector: 'tr[famous-row]', // imp line we have imported a selector here
  standalone: true,
  imports: [],
  templateUrl: './famous-person-row.component.html',
  styleUrl: './famous-person-row.component.css'
})
export class FamousPersonRowComponent {

  @Input() DisplayDev: Complete = {} as Complete;


}
