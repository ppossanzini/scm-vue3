<script lang="ts" src="./App.ts"></script>

<template>
  <header :key="currentOperation">
    <span v-if="currentOperation">{{ partial }} ({{ currentOperation }})</span>
    {{ tot }}

    <!-- <section :style="{ width: `${tot}px` }" :class="{ rotate: currentOperation == 'x' }" /> -->
  </header>

  <main>
    <button @click="clear()" @dblclick="clear(true)" class="clear">C/CE</button>
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
    <button @click="calculate()" class="enter" >=</button>
    <button @click="operation('+')" class="plus" :class="{selected: currentOperation == '+'}">+</button>
    <button @click="operation('-')" class="minus" :class="{selected: currentOperation == '-'}">-</button>
    <button @click="operation('x')" class="mul" :class="{selected: currentOperation == 'x'}">x</button>
    <button @click="operation('/')" class="div" :class="{selected: currentOperation == '/'}">/</button>
  </main>
  <aside>
    <history-element v-for="(h, idx) in history" :key="idx" :class="{last: h.operation == '=' || h.operation =='ce'}">
      <span>{{ h.operation }}</span>
      <template v-slot:partial>{{ h.partial }} </template>
      <template v-slot:total>{{ h.total }}</template>
    </history-element>
  </aside>
</template>

<style>
@import url(./App.css);
</style>
