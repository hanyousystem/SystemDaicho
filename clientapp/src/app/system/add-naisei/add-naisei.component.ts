import { Component } from '@angular/core';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Naisei, NaiseiSystem } from '../Models/Naise';
import { Location } from '@angular/common';
@Component({
  selector: 'app-add-naisei',
  templateUrl: './add-naisei.component.html',
  styleUrls: ['./add-naisei.component.css']
})
export class AddNaiseiComponent {

  SystemList = new NaiseiSystem();
  messege!: string;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }
  systemid!: string;
  ngOnInit() {
    this.systemid = this.userdataservice.getUserdata();
  }

  addSystem() {
    this.SystemList.id = this.systemid
    console.log(this.SystemList.id);
    this.apiservice.addSystem(this.SystemList).subscribe(
      (Response) => {
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
