<template>
  <nav>
    <div class="chat" v-for="chat in chats" :key="chat.id">
      <span>(#{{ chat.id}}) {{ chat.name }}</span>
      <time>{{ dateFormat(chat.creationDate) }}</time>
    </div>
  </nav>
  <new-chat></new-chat>
</template>
<script lang="ts" src="./ChatList.ts"></script>
<style scoped>
@import url(./ChatList.css);
</style>
