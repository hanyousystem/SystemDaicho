import { Component } from '@angular/core';
import { Gaisei, GaiseiSystem } from '../Models/Gaisei';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Location } from '@angular/common';
import { NaiseiSystem } from '../Models/Naise';

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
  systemid!: string;
  ngOnInit() {
    this.SystemList = new GaiseiSystem
    this.systemid = this.userdataservice.getUserdata();
  }

  addSystem() {
    this.SystemList.id = this.systemid
    console.log(this.SystemList.id);
    this.apiservice.addSystem_Gaisei(this.SystemList).subscribe(
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
