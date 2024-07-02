import { Configuration } from "@/Configurations";
import { useChatStore } from "@/stores/counter";
import { reactive, ref, toRef, type Ref } from "vue";


export class ChatService {


  async getChats(): Promise<Ref<server.ChatInfo[]>> {

    let store = useChatStore();
    //async getChats(): Promise<server.ChatInfo[]> {
    try {
      let result = await fetch(Configuration.serverUri + '/chat',
        {
          method: 'GET',
          headers: { 'Content-Type': 'application/json' }
        }
      );

      if (result.ok) {

        let data = await result.json() as unknown as server.ChatInfo[];
        store.setChats(...data);

        return ref<server.ChatInfo[]>(data);
        //return reactive<server.ChatInfo[]>(await result.json() as unknown as server.ChatInfo[]);
      }

      return ref<server.ChatInfo[]>([]);
      //return reactive<server.ChatInfo[]>([]);
    }
    catch (error) {
      console.error(error);
      throw error;

    }

  }

  async createChat(name: string): Promise<server.ChatInfo | null> {
    let store = useChatStore();
    let result = await fetch(`${Configuration.serverUri}/chat/${name}`,
      {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' }
      })

    if (result.ok) {
      let data = await result.json() as unknown as server.ChatInfo;
      //store.addChat(data);
      return data;
    }
    return Promise.reject(null);
  }

}















export const ChatServiceInstance = new ChatService()