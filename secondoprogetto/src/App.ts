import { computed, defineComponent, reactive, ref } from 'vue'
import SearchBar from "@/components/SearchBar.vue";
import List from "@/components/List.vue";
import Detail from "@/components/details/Details.vue";
import { DataModel } from './dto/datamodel';

export default defineComponent({
  components: {
    SearchBar,
    List,
    Detail
  },
  setup() {

    const dataList = reactive<DataModel[]>([])
    const selectedRow = ref<DataModel | null>(null);
    const filter = ref<string>('')
    let itemidx =0;

    dataList.push({ id: 1, name: 'test1', description: 'test1' })
    dataList.push({ id: 2, name: 'test2', description: 'test2' })
    dataList.push({ id: 3, name: 'test3', description: 'test3' })
    itemidx = dataList.length;

    const filteredList = computed(() => {
      return dataList.filter(i => 
        filter.value == '' ||
        i.name.includes(filter.value) || 
        i.description.includes(filter.value)
      )
    })

    function addItem(){
      dataList.push({ id: ++itemidx, name: '', description: '' })
      selectedRow.value = dataList[dataList.length-1];
    }

    function deleteItem(item: DataModel){
      let idx = dataList.indexOf(item);
      if(idx>=0){
        dataList.splice(idx, 1);
      }
    }

    return {
      dataList, selectedRow, filter, filteredList, addItem, deleteItem
    }
  }
})