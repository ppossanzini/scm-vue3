import { defineComponent } from "vue";
import { ref } from 'vue';
import HelloWorld from './components/HelloWorld.vue'
import TheWelcome from './components/TheWelcome.vue'

export default defineComponent({
  components: {
    HelloWorld, TheWelcome
  },
  setup() {
    let ciaovar = 'ciao';
    let ciaovar2 = ref<String>('ciao2');


    // setInterval(() => {
    //   ciaovar2.value = `${ciaovar2.value}a`;
    // }, 2000)


    function adda() {
      ciaovar2.value = `${ciaovar2.value}a`;
    }


    return {
      ciaovar2, adda
    }
  },
})