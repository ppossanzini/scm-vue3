<template>
  <section>
    <span><slot name="partial"/></span>
    <span><slot/></span>
    <span><slot name="total"/></span>
  </section>
</template>
<script src="./historyelement.ts" lang="ts"></script>
<style scoped>
@import url(./historyelement.css);

section {
  display: grid;
  grid-template-columns: 1fr 50px 1fr;
}

</style>