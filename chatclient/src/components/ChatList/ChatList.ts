import { ChatServiceInstance } from "@/services/chatservice";
import { useChatStore } from "@/stores/counter";
import { defineComponent, onMounted, ref } from "vue"
import newChat from "@/components/newChat/newChat.vue"

export default defineComponent({
  components: { newChat },
  name: "ChatList",
  setup() {

    const store = useChatStore();
   

    onMounted(async () => {
    await ChatServiceInstance.getChats();
    })


    function dateFormat(date: Date | string) {
      return new Date(date).toLocaleDateString();
    }
 
    return { chats: store.chats, dateFormat }
  }
})