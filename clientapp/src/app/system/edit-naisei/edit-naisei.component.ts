import { Component,ElementRef } from '@angular/core';
import { Naisei } from '../Models/Naisei';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Location } from '@angular/common';
import { UserAD } from '../Models/UserAD';
import { Log } from '../Models/Logs';
import dayjs from "dayjs";

@Component({
  selector: 'app-edit-naisei',
  templateUrl: './edit-naisei.component.html',
  styleUrls: ['./edit-naisei.component.css']
})
export class EditNaiseiComponent {
  SystemList!: Naisei;
  systemid: any;
  userAD!: UserAD;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }
  ngOnInit() {
    const systemid: string = this.userdataservice.getUserdata();
    this.getuserdata(systemid);
    this.userdataservice.getUserAD().then(
      data => {
        this.userAD = data;
      }
    )
  }
  getuserdata(id: string) {
    this.apiservice.getSystem(id).subscribe(
      data => this.SystemList = data
    );
  }
  updateSystem() {
    if (this.SystemList.shukanKashitsu != this.userAD.sectionName.slice(2)) {
      alert("所属課室の課室名を入力してください");
      return;
    }
    this.apiservice.updateSystem(this.SystemList).subscribe(res => {
      const log: Log = {
        userID: this.userAD.userID,
        section: this.userAD.sectionName,
        dateTime: dayjs().format('YYYY-MM-DD HH:mm:ss'),
        operation: '更新',
      };
      this.apiservice.postlog(log);
      console.log("updateSystem")
      if (res === null) {
        alert("更新しました。");
        this.goBack();
        console.log("updateSystem callback1")
        console.log("updateSystem callback2")
      } else {
        console.log("updateSystem" + res.toString())
      }
    });

  }
  goBack(): void {
    this.location.back();
  }
}
