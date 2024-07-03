<script lang="ts" src="./App.ts"></script>

<template>
  <header>
    <span v-if="currentOperation">{{partial}} ({{currentOperation}})</span>
    {{ tot }}

    <span v-html="thtml"></span>

    <section :style="{width: `${tot}px`}" 
             :class="{rotate: currentOperation == 'x'}"
             
              />
  </header>

  <main>
    <button @click="addnumber(1)" class="b1">1</button>
    <button @click="addnumber(2)" class="b2">2</button>
    <button @click="addnumber(3)" class="b3">3</button>
    <button @click="addnumber(4)" class="b4">4</button>
    <button @click="addnumber(5)" class="b5">5</button>
    <button @click="addnumber(6)" class="b6">6</button>
    <button @click="addnumber(7)" class="b7">7</button>
    <button @click="addnumber(8)" class="b8">8</button>
    <button @click="addnumber(9)" class="b9">9</button>
    <button @click="addnumber(0)" class="b0">0</button>
    <button @click="isDecimal = true" class="dot">.</button>
    <button @click="calculate()" class="enter">=</button>
    <button @click="operation('+')" class="plus">+</button>
    <button @click="operation('-')" class="minus">-</button>
    <button @click="operation('x')" class="mul">x</button>
    <button @click="operation('/')" class="div">/</button>
  </main>
  <aside>
    <history-element :name="test">
      <button>Clear</button>
      <template v-slot:partial slot-scope="{name}">{{partial}} {{name}}</template>
      <template v-slot:total>{{tot}}</template>
    </history-element>

  </aside>
</template>

<style>
@import url(./App.css);
</style>
