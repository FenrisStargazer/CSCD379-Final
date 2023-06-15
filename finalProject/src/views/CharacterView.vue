<template>
  <div class="d-flex flex-column fill-height justify-center align-center">
    <CharacterCard v-for="char in list" :key="char.characterId" :main="char"></CharacterCard>
  </div>
</template>
<script lang="ts" setup>
import { PDCharacter } from '@/scripts/PDCharacter'
import Axios from 'axios'
import { reactive } from 'vue'
import CharacterCard from '@/components/CharacterCard.vue'

const list = reactive(new Array<PDCharacter>())
populateList()

function populateList() {
  /* Axios.get('Character/GetCharacters')
    .then((response) => {
      list.length = 0
      response.data.list.forEach((item: PDCharacter) => {
        list.push(item)
      })
    })
    .catch((error) => {
      console.log(error)
    }) */

    const char1 = new PDCharacter()
    char1.characterId = 555
    char1.playerUN = "Vulpyx"
    char1.characterData.name = "Alexius Solarius"
    char1.characterData.culture = "Gaul"
    char1.characterData.religion = "Pagan"
    char1.characterData.fatherName = "Hadrius Solarius"
    char1.characterData.fatherClass = "Knight"
    char1.characterData.childNumber = 4
    char1.characterData.currentClass = "Squire"
    char1.characterData.age = 14
    char1.characterData.yearBorn = 523
    char1.gloryInfo.totalGlory = 75
    char1.gloryInfo.gameGlory = 15
    char1.gloryInfo.joustLoss = 0
    char1.gloryInfo.joustWin = 0
    char1.traits.chaste.value = 12
    char1.traits.lustful.value = 18
    char1.traits.lustful.check = true
    char1.traits.energetic.value = 12
    char1.traits.lazy.value = 18
    char1.traits.lazy.check = true
    char1.traits.forgiving.value = 18
    char1.traits.vengeful.value = 12
    char1.traits.generous.value = 13
    char1.traits.selfish.value = 17
    char1.traits.honest.value = 15
    char1.traits.deceitful.value = 15
    char1.traits.deceitful.check = true
    char1.traits.just.value = 17
    char1.traits.arbitrary.value = 13
    char1.traits.merciful.value = 17
    char1.traits.cruel.value = 13
    char1.traits.modest.value = 12
    char1.traits.proud.value = 18
    char1.traits.pious.value = 15
    char1.traits.wordly.value = 15
    char1.traits.prudent.value = 13
    char1.traits.reckless.value = 17
    char1.traits.reckless.check = true
    char1.traits.temperate.value = 13
    char1.traits.indulgent.value = 17
    char1.traits.indulgent.check = true
    char1.traits.trusting.value = 16
    char1.traits.suspicious.value = 14
    char1.traits.valorous.value = 16
    char1.traits.cowardly.value = 14
    char1.passions.loveDeity.value = 25
    char1.passions.loyaltyLord.value = 5
    char1.passions.loveFamily.value = 35
    char1.passions.honor.value = 18
    char1.passions.hospitality.value = 14

    list.push(char1)
}
</script>
