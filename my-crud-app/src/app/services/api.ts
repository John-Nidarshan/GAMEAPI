import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface game {
  id: number;
  name: string;
  game:string;
  role:string;
  // Add other properties of your model
}

@Injectable({
  providedIn: 'root',
})
export class Api {
  
    private apiUrl = 'https://localhost:7222/api/Character'; // Adjust to your API route

  constructor(private http: HttpClient) { }


  getAll():Observable<game[]>{
   return this.http.get<game[]>(this.apiUrl);
  }

}
