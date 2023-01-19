import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Menu } from '../models/menu';

@Injectable({
  providedIn: 'root'
})
export class MenuService {

  baseUrl: string = "https://localhost:7097";

  constructor(private httpClient: HttpClient) { }

  getCurrentMenu(restid: number):Observable<any>{
    return this.httpClient.get<any>(`${this.baseUrl}/api/Menus/${restid}`);
  }

  
}
