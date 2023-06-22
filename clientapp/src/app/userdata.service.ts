import { Injectable } from '@angular/core';
import { Naisei } from './system/Models/Naise';

@Injectable({
  providedIn: 'root'
})
export class UserdataService {
  private userlist!: Naisei;
  constructor() { }
  setUserdata(userlist: Naisei) {
    this.userlist = userlist;
  }
  getUserdata() {
    return this.userlist;
  }
}
