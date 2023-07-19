import { Component } from '@angular/core';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Naisei, NaiseiSystem } from '../Models/Naisei';
import { Location } from '@angular/common';
import { MaxID } from '../Models/MaxID';
import { UserAD } from '../Models/UserAD';
import { Log } from '../Models/Logs';
@Component({
  selector: 'app-add-naisei',
  templateUrl: './add-naisei.component.html',
  styleUrls: ['./add-naisei.component.css']
})
export class AddNaiseiComponent {

  SystemList = new NaiseiSystem();
  systemid!: string;
  userAD!: UserAD;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }
  async ngOnInit() {
    await this.userdataservice.getUserAD().then(
      data => {
        this.userAD = data;
      }
    )
    this.SystemList.shukanKashitsu = this.userAD.sectionName.slice(2);
  }

  async getID(): Promise<MaxID> {
    return new Promise<MaxID>((resolve, reject) => {
      this.apiservice.getMaxID_Naisei().subscribe(
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
      dateTime: new Date(),
      operation:'挿入'
    };
    await this.apiservice.postlog(log);
    (await this.apiservice.addSystem(this.SystemList)).subscribe(
      (response) => {
        alert("追加しました。");
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
