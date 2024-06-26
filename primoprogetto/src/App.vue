<script  lang="ts" src="./App.ts">
// import { ref } from 'vue';
// import HelloWorld from './components/HelloWorld.vue'
// import TheWelcome from './components/TheWelcome.vue'

// let ciaovar = 'ciao';
// let ciaovar2 = ref<String>('ciao2');


// setInterval(() => {
//   ciaovar2.value = `${ciaovar2.value}a`;
// },2000)
</script>

<template>
  <header>
    <img alt="Vue logo" class="logo" src="./assets/logo.svg" width="125" height="125" />

    <div class="wrapper">
      <!-- <HelloWorld msg="aaaCIao" /> -->
      <hello-world :msg="ciaovar2" @msg="(m:string)=>ciaovar2=m"/>
      <!-- <input type="text" v-model="ciaovar2" />
      <input type="text" v-model="ciaovar2" /> -->
      <button @click="adda()">aggiungi</button>
    </div>
  </header>

  <main>
    <TheWelcome />
  </main>
</template>

<style scoped>
header {
  line-height: 1.5;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
