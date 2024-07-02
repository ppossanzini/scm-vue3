import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    }, 
    {
      path: '/chats',
      name: 'chats',
      component: ()=> import('../components/ChatList/ChatList.vue')
    },
    {
      path: '/app/:chatname',
      name: 'chat',
      component: HomeView,
     props: true

    }
  ]
})

export default router
