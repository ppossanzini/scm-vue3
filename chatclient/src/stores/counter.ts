import { ref, computed } from 'vue'
import { defineStore } from 'pinia'

export const useChatStore = defineStore('chat', () => {
  const chats = ref<server.ChatInfo[]>([]);

  function setChats(...v: server.ChatInfo[]) {
    chats.value.splice(0, chats.value.length, ...v);
  }

  function addChat(...v: server.ChatInfo[]) {
    chats.value.push(...v);
  }

  return { chats, setChats, addChat }
})
