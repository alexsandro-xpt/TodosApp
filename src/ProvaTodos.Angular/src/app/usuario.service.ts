import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { Usuario } from './usuario';

@Injectable()
export class UsuarioService {

  constructor(private http: HttpClient) { }

  carregarTodosUsuarios(): Observable<Usuario[]> {
    return this.http.get<Usuario[]>('http://localhost:5444/api/account').pipe(
      catchError(this.handleError('carregarTodosUsuarios', []))
    );
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
  
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

}
