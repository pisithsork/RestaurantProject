export class Cuisine{
    cuisine_id: number;
    cuisine_type: string;

    constructor (cuisine_id: number, cuisine_type: string){
        this.cuisine_id = cuisine_id;
        this.cuisine_type = cuisine_type;
    }
}