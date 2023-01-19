import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Restaurant } from '../models/restaurant';

@Injectable({
  providedIn: 'root'
})
export class RestaurantService {

  baseUrl: string = "https://localhost:7097";
  constructor(private httpClient: HttpClient) { }

  getAllRestaurant(): Observable<any>{
    return this.httpClient.get<any>(`${this.baseUrl}/api/Restaurants`) 
  }
  
}
