import * as fs from 'fs';
try {
	const jsonString = fs.readFileSync('URLConfig.json', 'utf-8');
	const jsonData = JSON.parse(jsonString);
	console.log(jsonData);
  } catch (err) {
	console.error(err);
  }


// const url = "URLConfig.json";	// JSONファイル名
// let result;
// export class URLConfigReader  {
//    getURL(key:string): any {  
// 	// システムの一覧を取得するAPI呼び出し
// 	 return  fetch(url)
// 	         .then( response => response.json())
// 	         .then( data => data(key));
// 	}
// }