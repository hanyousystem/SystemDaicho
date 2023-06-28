import { Component } from '@angular/core';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Naisei, NaiseiSystem } from '../Models/Naise';
import { Location } from '@angular/common';
import { MaxID } from '../Models/MaxID';
@Component({
  selector: 'app-add-naisei',
  templateUrl: './add-naisei.component.html',
  styleUrls: ['./add-naisei.component.css']
})
export class AddNaiseiComponent {

  SystemList = new NaiseiSystem();
  systemid!: string;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }
  ngOnInit() {
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
    console.log(this.SystemList.id);

    (await this.apiservice.addSystem(this.SystemList)).subscribe(
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
