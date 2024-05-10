import { Component } from '@angular/core';
import {VideogameComponent} from '../videogame/videogame.component'

@Component({
  selector: 'app-usuario',
  standalone: true,
  imports: [VideogameComponent,VideogameComponent],
  templateUrl: './usuario.component.html',
  styleUrl: './usuario.component.css'
})
export class UsuarioComponent {
  isLoggedIn = false;
  userName = 'EleDani505';
  favGame = '';

  getFavGame(gameName:string){
    this.favGame = gameName;
  }

  greet(){
    alert('Holanda');
  }
}
