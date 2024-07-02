
import  { defineComponent } from "vue";

export default defineComponent({
  props: {
    chatname: {type:String, default:""},
    chat: {type:String, default:""}
  },
  setup(props) {
    
    return {
      props
    }
  }
})