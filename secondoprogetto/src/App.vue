<template>
  <div class="app">
    <search-bar v-model="filter" @add="addItem()"></search-bar>
    <list :lista="filteredList" @selectRow="selectedRow=$event" 
    @delete="deleteItem($event)"> </list>
    <detail :item="selectedRow"></detail>
  </div>
</template>
<script lang="ts" src="./App.ts">
</script>
<style>
@import url(./App.css);
</style>