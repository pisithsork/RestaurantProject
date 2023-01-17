export class Restaurant{
    grade_id: number;
    rest_gradeid: number;
    grade: string;
    grade_date: Date;

    constructor (grade_id: number,rest_gradeid: number, grade: string, grade_date: Date){
        this.grade_id = grade_id;
        this.rest_gradeid = rest_gradeid;
        this.grade = grade;
        this.grade_date = grade_date;
    }
}