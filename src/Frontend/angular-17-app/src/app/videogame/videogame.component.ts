import { Component, Input , Output, EventEmitter,} from '@angular/core';

@Component({
  selector: 'app-videogame',
  standalone: true,
  imports: [],
  template: `
  <h3>Los juegos favoritos de {{username}}</h3>
   <ul>
    @for (game of games; track game.id) {
      <li (click)="fav(game.name)">{{game.name}}</li>
    }
   </ul>
  `,
  styles: ``
})
export class VideogameComponent {
  @Input() username ='';
  @Output() favEmitterEvent = new EventEmitter<string>();

  fav(gameName:string){
    this.favEmitterEvent.emit(gameName);
  }

  games = [
    {
      id:1,
      name: 'uncharted 4',
    },
    {
      id:2,
      name: 'fall out 4'
    },
    {
      id:3,
      name: 'Legue of legend'
    },
  ]

  
}
