import { Injectable } from '@angular/core';
import { User } from '../models/user';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  
  getUser(id: number): User{
    // return this.http.get<User>("./assets/products.json");
    return {id: 1, name: "John Doe"};
  }
}
