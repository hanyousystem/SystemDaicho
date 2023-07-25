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
  systemid!: string;
  userAD!: UserAD;
  initdata!: Naisei;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }

  ngOnInit() {
    this.systemid = this.userdataservice.getUserdata();
    this.getuserdata( this.systemid);
     //編集データを取得し、同時にログ用に編集前データとして保持
     this.getuserdata(this.systemid).then(data => this.initdata= {...data});
    this.userdataservice.getUserAD().then(
      data => {
        this.userAD = data;
      }
    )
  }
  getuserdata(id: string): Promise<Naisei> {
    return new Promise<Naisei>((resolve, reject) => {
      this.apiservice.getSystem(id).subscribe(
        data => resolve(this.SystemList = data),
        error => reject(error)
      );
    });
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
        operation:'更新',
        daichotype:'1',
        dataID:this.SystemList.id,
      };
      //更新前後の全項目値を確認する
      for (let i = 0; i < Object.values(this.SystemList).length; i++) {
        if (Object.values(this.initdata)[i] != Object.values(this.SystemList)[i]) 
        {  
          log.UpdateItemName =Object.keys(this.SystemList)[i];
          log.UpdateBefore =Object.values(this.initdata)[i];
          log.UpdateAfter =Object.values(this.SystemList)[i];
          this.apiservice.postlog(log);
        }
      }

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
