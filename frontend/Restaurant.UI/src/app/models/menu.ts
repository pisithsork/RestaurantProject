export class Menu{
    dish_id: number;
    rest_scoreid: number;
    dish: string;
    price: number;


    constructor (dish_id: number, rest_scoreid: number, dish: string, price: number){
        this.dish_id = dish_id;
        this.rest_scoreid = rest_scoreid;
        this.dish = dish;
        this.price = price;
    }
}