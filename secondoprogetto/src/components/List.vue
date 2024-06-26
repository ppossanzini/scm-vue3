<template>
  <section>
    <table>
      <thead>
        <tr>
          <th>Id</th>
          <td>Name</td>
          <td>Description</td>
          <td></td>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(item) in lista" :key="item.id"
          @click="selectRow(item)">
          <th>{{item.id}}</th>
          <td>{{item.name}}</td>
          <td>{{item.description}}</td>
          <td><button @dblclick="deleteRow(item)">x</button></td>
        </tr>
      </tbody>
    </table>
  </section>
</template>

<script lang="ts" src="./List.ts"></script>
