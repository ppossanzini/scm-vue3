<script setup lang="ts">
import { ref } from "vue";
import { ChatServiceInstance } from "@/services/chatservice";

const chatName = ref("");

function createChat() {
  ChatServiceInstance.createChat(chatName.value);
}
</script>
<template>
  <div class="newChat"><input v-model="chatName" /> 
  <button @click="createChat">Create</button></div>
</template>
