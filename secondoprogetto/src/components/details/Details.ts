import type { DataModel } from "@/dto/datamodel";
import { defineComponent, type PropType } from "vue";

export default defineComponent({
  props: {
    item: {type: Object as PropType<DataModel>}
  }
});