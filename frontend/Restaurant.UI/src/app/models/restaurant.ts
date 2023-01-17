import { Menu } from "./menu";
export class Restaurant{
    id: number;
    rest_id: number;
    name: string;
    address: string;
    city: string;
    state: string;
    cuisine_type: string;
    menu: Menu;

    constructor (id: number, rest_id: number, name: string, address: string, city: string, state: string, cuisine_type: string, menu: Menu){
        this.id = id;
        this.rest_id = rest_id;
        this.name = name;
        this.address = address;
        this.city = city;
        this.state = state;
        this.cuisine_type = cuisine_type;
        this.menu = menu;
    }
}