import { computed, defineComponent } from "vue";

export default defineComponent({
  props: {
    modelValue: String
  }, 
  setup(props, {emit}) {
    const Value = computed({
      get: () => props.modelValue,
      set: (value) => emit('update:modelValue', value)
    })

    function add(){
      emit("add");
    }
    return {Value, add};
  }
})