import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Grade } from '../models/grade';

@Injectable({
  providedIn: 'root'
})
export class GradeService {

  baseUrl: string = "https://localhost:7097";

  constructor(private httpClient: HttpClient) { }

  //https://localhost:7097/api/Grades/20
  getRestaurantGrades(rest_scoreid: number):Observable<any>{
    return this.httpClient.get<any>(`${this.baseUrl}/api/Grades/${rest_scoreid}`);
  }

  getRecentGrade(grade: Grade[]): Grade{
    console.log(grade);
    grade.sort((a, b) => {
        return new Date(b.grade_date).getTime() - new Date(a.grade_date).getTime();
    });
    return grade[0];
}
}
