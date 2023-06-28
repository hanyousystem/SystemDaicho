import { Component } from '@angular/core';
import { Gaisei, GaiseiSystem } from '../Models/Gaisei';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Location } from '@angular/common';
import { NaiseiSystem } from '../Models/Naise';
import { MaxID } from '../Models/MaxID';

@Component({
  selector: 'app-add-gaisei',
  templateUrl: './add-gaisei.component.html',
  styleUrls: ['./add-gaisei.component.css']
})
export class AddGaiseiComponent {
  SystemList!: GaiseiSystem;
  messege!: string;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }
  systemid!: MaxID;
  ngOnInit() {
    this.SystemList = new GaiseiSystem
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
    console.log(this.SystemList.id);
    (await this.apiservice.addSystem_Gaisei(this.SystemList)).subscribe(
      (response) => {
        alert("追加しました。");
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
