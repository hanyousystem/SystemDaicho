import { Component } from '@angular/core';
import { GaiseiSystem } from '../Models/Gaisei';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Location } from '@angular/common';
import { MaxID } from '../Models/MaxID';
import { UserAD } from '../Models/UserAD';
import { Log } from '../Models/Logs';
import dayjs from "dayjs";

@Component({
  selector: 'app-add-gaisei',
  templateUrl: './add-gaisei.component.html',
  styleUrls: ['./add-gaisei.component.css']
})
export class AddGaiseiComponent {
  SystemList!: GaiseiSystem;
  messege!: string;
  userAD!: UserAD;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }
  systemid!: MaxID;
  async ngOnInit() {
    this.SystemList = new GaiseiSystem
    await this.userdataservice.getUserAD().then(
      data => {
        this.userAD = data;
      }
    )
    this.SystemList.shukanKashitsu = this.userAD.sectionName.slice(2);
  }

  async getID(): Promise<MaxID> {
    return new Promise<MaxID>((resolve, reject) => {
      this.apiservice.getMaxID_Gaisei().subscribe(
        data => {
          resolve(data); // 解決した ID を返す
        },
        error => {
          reject(error); // エラー発生時に reject() を呼び出す
        }
      );
    });
  }

  async addSystem() {
    this.SystemList.id = (await this.getID()).id; // ID を取得して反映する
    const log: Log = {
      userID: this.userAD.userID,
      section: this.userAD.sectionName,
      dateTime: dayjs().format('YYYY-MM-DD HH:mm:ss'),
      operation:'挿入',
      daichotype:'2',
      dataID:this.SystemList.id,
    };

    (await this.apiservice.addSystem_Gaisei(this.SystemList)).subscribe(
      (response) => {
        alert("追加しました。");
        this.apiservice.postlog(log);
        this.goBack();
      },
      (error) => {
        alert("追加に失敗しましたもう一度確認してください。");
      }
    );
  }
  goBack(): void {
    this.location.back();
  }

}
