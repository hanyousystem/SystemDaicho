import { Injectable } from '@angular/core';
import { Naisei } from './system/Models/Naise';

@Injectable({
  providedIn: 'root'
})
export class UserdataService {
  private userid!: string;
  constructor() { }
  setUserdata(userlist: string) {
    this.userid = userlist;
  }
  getUserdata() {
    return this.userid;
  }
}
