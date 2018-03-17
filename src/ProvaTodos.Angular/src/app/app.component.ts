import { Component } from '@angular/core';
import { UsuarioService } from './usuario.service';
import { Usuario } from './usuario';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  title = 'app';
  usuarios: Usuario[];

  constructor(private service: UsuarioService) {
  }
  
  ngOnInit() {
    this.carregarTodosUsuarios();
  }

  carregarTodosUsuarios(): void {
    this.service.carregarTodosUsuarios()
        .subscribe(data => this.usuarios = data);
  }
}
