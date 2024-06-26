<template>
  <aside v-if="item">
    <div>
      <label for="id">Id</label>
      <input type="text" id="id" v-model="item.id">
    </div>
    <div>
      <label for="name">Name</label>
      <input type="text" id="name" v-model="item.name">
    </div>
        <div>
      <label for="description">Description</label>
      <input type="text" id="description" v-model="item.description">
    </div>
  </aside>
</template>
<script lang="ts" src="./Details.ts"></script>
