import './assets/main.css'

import { createApp } from 'vue'
import { createPinia } from 'pinia'

import App from './App.vue'
import router from './router'

const app = createApp(App)

app.use(createPinia())
app.use(router)

app.mount('#app')

var x: { a: string, b: number } | string | null = { a: 'a', b: 1 };
x = 'aa';

let y: { a: string, b: null } & {c : Date}= 
{
  a: 'a',
  b: null,
  c: new Date()
};

y["z"] = "34";
let z = y as unknown as {z:string}

let ynullo = !!y;

if(x===y){

}

if(y){

}

let _y = {
  a: 'a',
  b: null,
  c: new Date()
};




var a : string = 'test';
var b : number | string = 'test';