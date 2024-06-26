import { defineComponent, computed } from "vue";

export default defineComponent({
  props: { msg: String},
  setup(props, ctx) {



    const message = computed({
      get: () => props.msg,
      set: m => { ctx.emit('msg', m) }
    })

    return {message}

  }
})