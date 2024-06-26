import type { DataModel } from "@/dto/datamodel";
import { defineComponent, type PropType } from "vue";

export default defineComponent({
  props: {
    lista: {type: Object as PropType<DataModel[]>, required: true}
  },
  setup(props,{emit}) {

    function selectRow(item:DataModel){
      emit('selectRow', item);
    }

    function deleteRow(item:DataModel){
      emit('delete', item)
    }

    return {selectRow, deleteRow}
  }
})