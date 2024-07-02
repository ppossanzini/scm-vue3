import { defineComponent } from 'vue'
import { RouterLink, RouterView } from 'vue-router'
import { HubConnectionBuilder } from "@microsoft/signalr";
import { Configuration } from './Configurations';
import { useChatStore } from './stores/counter';


export default defineComponent({
  components: { RouterLink, RouterView },
  setup() {

    const conn = new HubConnectionBuilder()
      .withUrl(`${Configuration.signalRUri}/chat`)

      .build();


    conn.start().then(() => {
      conn.send("MessageFromClient", "hello");  

      conn.on("MessageFromServer", (message:server.ChatInfo)=>{
         useChatStore().addChat(message);
      });
    })

    




  }
});
