import { Component } from '@angular/core';
import { Gaisei } from '../Models/Gaisei';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-edit-gaisei',
  templateUrl: './edit-gaisei.component.html',
  styleUrls: ['./edit-gaisei.component.css']
})
export class EditGaiseiComponent {
  SystemList!: Gaisei;
  systemid!: string;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }
  ngOnInit() {
    this.systemid = this.userdataservice.getUserdata();
    console.log(this.systemid);
    this.getuserdata(this.systemid);
  }

  getuserdata(id: string) {
    this.apiservice.getSystem_Gaisei(id).subscribe(
      data => this.SystemList = data
    );
  }
  updateSystem() {
    this.apiservice.updateSystem_Gaisei(this.SystemList).subscribe(res => {
      console.log("updateSystem")
      if (res === null) {
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
