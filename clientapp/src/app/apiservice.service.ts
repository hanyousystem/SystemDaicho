import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Naisei } from './system/Models/Naise';
import { Gaisei } from './system/Models/Gaisei';
import settings from './URLconfig.json';
import { MaxID } from './system/Models/MaxID';
import { UserID } from './system/Models/UserID';
import { UserAD } from './system/Models/UserAD';
import { Log } from './system/Models/Logs';

@Injectable({
  providedIn: 'root'
})


export class ApiserviceService {

  constructor(private http: HttpClient) {} 

  // Department
  getSystemList(): Observable<any[]> {  // システムの一覧を取得するAPI呼び出し
    return this.http.get<any[]>(settings.apiUrl);
  }
  getMaxID_Naisei(): Observable<MaxID> {  // システムの一覧を取得するAPI呼び出し
    return this.http.get<MaxID>(settings.apiUrl + "/nextID");
  }
  getMaxID_Gaisei(): Observable<MaxID> {  // システムの一覧を取得するAPI呼び出し
    return this.http.get<MaxID>(settings.apiUrl_Gaisei + "/nextID");
  }

  getSystemList_Gaisei(): Observable<any[]> {  // システムの一覧を取得するAPI呼び出し
    return this.http.get<any[]>(settings.apiUrl_Gaisei);
  }
  getSystem(SystemID: string): Observable<Naisei> {
    return this.http.get<Naisei>(settings.apiUrl + "/" + SystemID);
  }
  getSystem_Gaisei(SystemID: string): Observable<Gaisei> {
    return this.http.get<Gaisei>(settings.apiUrl_Gaisei + "/" + SystemID);
  }
  async addSystem(dept: Naisei): Promise<Observable<any>> {  // システムを追加するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<Naisei>(settings.apiUrl, dept, httpOptions);
  }
  async addSystem_Gaisei(dept: Gaisei): Promise<Observable<any>> {  // システムを追加するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<Naisei>(settings.apiUrl_Gaisei, dept, httpOptions);
  }

  updateSystem(dept: Naisei): Observable<any> {  // システムを更新するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put<Naisei>(settings.apiUrl + `/` + dept.id, dept, httpOptions);
  }
  updateSystem_Gaisei(dept: Gaisei): Observable<any> {  // システムを更新するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put<Naisei>(settings.apiUrl_Gaisei + `/` + dept.id, dept, httpOptions);
  }
  getUserData(): Observable<UserID> {
    const httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
    return this.http.get<UserID>(settings.getUserdataURL, httpOptions);
  }
  getADData(userid: string): Observable<UserAD> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.get<UserAD>(settings.getADURL + '/' + userid, httpOptions)
  }

  deleteSystem(Id: string): Observable<number> {  // システムを削除するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete<number>(settings.apiUrl + "/" + Id, httpOptions);
  }
  PostChangeLog(data: Log): Observable<Log> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<Log>(settings.PostLogs, data, httpOptions);
  }
  postlog(data: Log) {
    let response;
    this.PostChangeLog(data).subscribe(
      data => response = data
    );
  }
}
