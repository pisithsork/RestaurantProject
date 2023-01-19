import { Menu } from "./menu";
import { Score } from "./score";
import { Grade } from "./grade";
import { Cuisine } from "./cuisine";
export class Restaurant{
    id: number;
    rest_id: number;
    name: string;
    address: string;
    city: string;
    state: string;
    cuisine: Cuisine[];
    menu: Menu[];
    score: Score[];
    grade: Grade[];

    constructor (id: number, rest_id: number, name: string, address: string, city: string, state: string, cuisine: Cuisine[], menu: Menu[], score: Score[], grade: Grade[]){
        this.id = id;
        this.rest_id = rest_id;
        this.name = name;
        this.address = address;
        this.city = city;
        this.state = state;
        this.cuisine = cuisine;
        this.menu = menu;
        this.score = score;
        this.grade = grade;
    }
}