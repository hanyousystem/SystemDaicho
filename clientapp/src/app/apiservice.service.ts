import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Naisei } from './system/Models/Naise';

@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {
  readonly apiUrl = 'https://localhost:7043/inHouseSystem';  // APIのURL
  readonly apiUrl_Gaisei = 'https://localhost:7043/inHouseSystemController_Gaisei';  // APIのURL
  readonly apiUrl2 = 'https://localhost:7043/Process';  // 別のAPIのURL
  readonly apiUrl3 = 'https://localhost:7043/SystemCategories';  // 別のAPIのURL

  constructor(private http: HttpClient) { }


  // Department
  getSystemList(): Observable<any[]> {  // システムの一覧を取得するAPI呼び出し
    return this.http.get<any[]>(this.apiUrl);
  }
  getSystemList_Gaisei(): Observable<any[]> {  // システムの一覧を取得するAPI呼び出し
    return this.http.get<any[]>(this.apiUrl_Gaisei);
  }
  addSystem(dept: Naisei): Observable<any> {  // システムを追加するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<Naisei>(this.apiUrl, dept, httpOptions);
  }

  updateSystem(dept: Naisei): Observable<any> {  // システムを更新するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put<Naisei>(this.apiUrl + `/` + dept.id, dept, httpOptions);
  }

  deleteSystem(Id: number): Observable<number> {  // システムを削除するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete<number>(this.apiUrl + Id, httpOptions);
  }
  getCategories(): Observable<any[]> {  // システムカテゴリーの一覧を取得するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.get<any[]>(this.apiUrl3, httpOptions);

  }
  getProcessControls(): Observable<any[]> {  // プロセス制御の一覧を取得するAPI呼び出し
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.get<any[]>(this.apiUrl2, httpOptions);

  }
}
