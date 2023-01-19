import { Component, OnInit } from '@angular/core';
import { Restaurant } from '../../models/restaurant';
import { Menu } from '../../models/menu';
import { RestaurantService } from '../../services/restaurant.service';
import { MenuService } from '../../services/menu.service';
import { CurrentRestaurantService } from '../../services/current-restaurant.service';
import { ScoreService } from '../../services/score.service';
import { GradeService } from '../../services/grade.service';
import { Router } from '@angular/router';
import { delay } from 'rxjs';
import { Grade } from '../../models/grade';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  AllRestaurant: Restaurant[] = [];
  currentrest!: Restaurant;
  testgrade!: Grade;

  constructor(private restService: RestaurantService, private menuService: MenuService, private currentrestservice: CurrentRestaurantService, private scoreService: ScoreService, private gradeService: GradeService, private router: Router){}

  ngOnInit(){
    this.restService.getAllRestaurant().subscribe(
        (resp) => {
          this.AllRestaurant = resp
          console.log(this.AllRestaurant)},
        (error) => console.log(error)
    );
  }


  async getCurrentDetails(id:number){
    this.currentrestservice.setRestaurant(this.AllRestaurant[id - 1]);
    this.currentrest = this.currentrestservice.getRestaurant();

this.gradeService.getRestaurantGrades(id).subscribe(
      (resp) => {
        this.currentrestservice.setGrades(resp);
        
      },
      (error) => console.log(error)
    );
    this.menuService.getCurrentMenu(id).subscribe(
      (resp) => {
        this.currentrestservice.setMenu(resp);
      },
      (error) => console.log(error)
    );
    
    this.scoreService.getRestaurantScores(id).subscribe(
      (resp) => {
        this.currentrestservice.setScores(resp);
        
      },
      (error) => console.log(error)
    );
    this.router.navigate(['details']);
  }

}
