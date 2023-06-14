<template>
  <div class="d-flex flex-column fill-height justify-center align-center">
    <CharacterCard v-for="char in list" :key="char.characterId" :main="char"></CharacterCard>
  </div>
</template>
<script lang="ts" setup>
import type { PDCharacter } from '@/scripts/PDCharacter'
import Axios from 'axios'
import { reactive } from 'vue'
import CharacterCard from '@/components/CharacterCard.vue'

const list = reactive(new Array<PDCharacter>())
populateList()

function populateList() {
  Axios.get('Character/GetCharacters')
    .then((response) => {
      list.length = 0
      response.data.list.forEach((item: PDCharacter) => {
        list.push(item)
      })
    })
    .catch((error) => {
      console.log(error)
    })
}
</script>
