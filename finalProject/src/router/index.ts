import { createRouter, createWebHistory } from 'vue-router'
import CharacterView from '../views/CharacterView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: CharacterView
    }
  ]
})

export default router
