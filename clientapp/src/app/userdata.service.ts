import { Injectable } from '@angular/core';
import { ApiserviceService } from './apiservice.service';
import { UserAD } from './system/Models/UserAD';

@Injectable({
  providedIn: 'root'
})
export class UserdataService {
  private userid!: string;
  private systemid!: string;
  private userAD!: UserAD;
  constructor(private apiservice: ApiserviceService,) { }
  setUserdata(userlist: string) {
    this.systemid = userlist;
  }
  getUserdata() {
    return this.systemid;
  }

  private async getUserID(): Promise<void> {
    return new Promise<void>((resolve, rejeect) => {
      this.apiservice.getUserData().subscribe(
        data => {
          this.userid = data.userID;
          resolve();
        },
        error => {
          rejeect(error);
        }
      )
    })
  }

  async getUserAD(): Promise<UserAD> {
    await this.getUserID();

    return new Promise<UserAD>((resolve, reject) => {
      this.apiservice.getADData(this.userid).subscribe(
        data => resolve(data),
        error => reject(error)
      );
    });
  }
}
