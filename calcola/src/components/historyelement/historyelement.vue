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

section span{
  display: flex;
  align-items: center;
  justify-content: center;
}

section span:first-child{
  justify-content: flex-start;
}

section span:last-child{
  justify-content: flex-end;
}

</style>