import { Component, OnInit } from '@angular/core';
import { CurrentRestaurantService } from '../../services/current-restaurant.service';
import { ScoreService } from '../../services/score.service';
import { GradeService } from '../../services/grade.service';
import { Router } from '@angular/router';
import { Restaurant } from '../../models/restaurant';
import { Grade } from '../../models/grade';
import { Score } from '../../models/score';

@Component({
  selector: 'app-restaurant-details',
  templateUrl: './restaurant-details.component.html',
  styleUrls: ['./restaurant-details.component.css']
})
export class RestaurantDetailsComponent implements OnInit {

  currentrest = new Restaurant(0, 0, "", "", "", "", [], [], [], []);
  restavgscore!: any;
  menu: boolean = false;
  menu_btn: string = 'Show Menu'
  recent_grade!: Grade;
  
  constructor(private currentrestservice:CurrentRestaurantService, private scoreService: ScoreService, private gradeService: GradeService, private router: Router){ }

  ngOnInit(): void {
    this.currentrest = this.currentrestservice.getRestaurant();
    this.scoreService.getRestaurantAvgScore(this.currentrest.id).subscribe(
      (resp) => {
        this.restavgscore = resp;
      }
    );
  }

  IO_Menu(){
    if(this.menu){
      this.menu = false;
      this.menu_btn = "Show Menu";
    }
    else{
      this.menu = true;
      this.menu_btn = "Hide Menu";
    }
  }

}
