
import { defineComponent, ref } from "vue";
import historyElement from "./components/historyelement/historyelement.vue";

export default defineComponent({
  components: { historyElement },
  setup() {


    const partial = ref(0);
    const tot = ref(0);
    const currentOperation = ref<"x" | "/" | "+" | "-" | null>(null);
    let isDecimal = ref(false);
    let divider = 10;

    function addnumber(n: number) {
      tot.value = (isDecimal.value ? tot.value : tot.value * 10) + (isDecimal.value ? n / divider : n)
      divider = isDecimal.value ? divider * 10 : 10
    }


    function operation(s: "x" | "/" | "+" | "-") {
      partial.value = tot.value;
      currentOperation.value = s;
      tot.value = 0;
      isDecimal.value = false;
      divider = 10;
    }

    function calculate() {
      switch (currentOperation.value) {
        case "x":
          tot.value = partial.value * tot.value
          break
        case "/":
          tot.value = partial.value / tot.value
          break
        case "+":
          tot.value = partial.value + tot.value
          break
        case "-":
          tot.value = partial.value - tot.value
          break;
      }
      partial.value = 0;
      currentOperation.value = null
    }

    return {
      tot, addnumber, isDecimal, operation, calculate,
      currentOperation, partial
    }
  }

})