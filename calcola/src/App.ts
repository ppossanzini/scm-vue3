
import { defineComponent, ref, unref, watch } from "vue";
import historyElement from "./components/historyelement/historyelement.vue";

export default defineComponent({
  components: { historyElement },
  setup() {


    const partial = ref(0);
    const tot = ref(0);
    const currentOperation = ref<"x" | "/" | "+" | "-" | null>(null);
    let isDecimal = ref(false);
    let divider = 10;

    const history = ref<{ partial: number, total?: number, operation: "=" | "x" | "/" | "+" | "-" |"ce" }[]>([]);
    // if(localStorage["history"]){
      let v = localStorage.getItem("history")
      if(v) history.value = JSON.parse(v)
    // }
    

    function addnumber(n: number) {
      tot.value = (isDecimal.value ? tot.value : tot.value * 10) + (isDecimal.value ? n / divider : n)
      divider = isDecimal.value ? divider * 10 : 10
    }


    function operation(s: "x" | "/" | "+" | "-") {
      calculate(false)
      partial.value = tot.value;
      currentOperation.value = s;
      tot.value = 0;
      isDecimal.value = false;
      divider = 10;

      history.value.push({ partial: partial.value, operation: currentOperation.value })
    }

    function calculate(print: boolean = true) {
      let val = tot.value;
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

      if (currentOperation.value && print) {
        partial.value = 0;
        history.value.push({ partial: val, total: tot.value, operation: "=" })
      }
      currentOperation.value = null
    }

    function clear(all: boolean = false) {
      tot.value = 0
      if (all) {
        partial.value = 0
        currentOperation.value = null
        history.value.push({ operation: "ce" })
      }

    }

    watch(history, ()=>{
      localStorage.setItem("history", JSON.stringify(unref(history)))
    }, {deep:true})

    return {
      tot, addnumber, isDecimal, operation, calculate,
      currentOperation, partial, history, clear
    }
  }

})