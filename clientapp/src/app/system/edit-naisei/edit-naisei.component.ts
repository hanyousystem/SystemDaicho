import { Component } from '@angular/core';
import { Naisei } from '../Models/Naise';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-edit-naisei',
  templateUrl: './edit-naisei.component.html',
  styleUrls: ['./edit-naisei.component.css']
})
export class EditNaiseiComponent {
  SystemList!: Naisei;
  systemid: any;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }
  ngOnInit() {
    const systemid: string = this.userdataservice.getUserdata();
    console.log(systemid);
    this.getuserdata(systemid);
  }

  getuserdata(id: string) {
    this.apiservice.getSystem(id).subscribe(
      data => this.SystemList = data
    );
  }
  updateSystem() {
    this.apiservice.updateSystem(this.SystemList).subscribe(res => {
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
