import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Score } from '../models/score';

@Injectable({
  providedIn: 'root'
})
export class ScoreService {

  baseUrl: string = "https://localhost:7097";
  testing!: any;

  constructor(private httpClient: HttpClient) { }

  getRestaurantScores(rest_scoreid: number):Observable<any>{
    return this.httpClient.get<any>(`${this.baseUrl}/api/Scores/${rest_scoreid}`);
  }

  getRestaurantAvgScore(rest_scoreid:number):Observable<any>{
    return this.httpClient.get<any>(`${this.baseUrl}/api/Scores/Average/${rest_scoreid}`);
  }
}
