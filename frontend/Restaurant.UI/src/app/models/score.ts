export class Score{
    score_id: number;
    rest_scoreid: number;
    score: number;
    score_date: Date;

    constructor (score_id: number, rest_scoreid: number, score: number, score_date: Date){
        this.score_id = score_id;
        this.rest_scoreid = rest_scoreid;
        this.score = score;
        this.score_date = score_date;
    }
}