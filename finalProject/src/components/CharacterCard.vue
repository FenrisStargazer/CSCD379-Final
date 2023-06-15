<template>
  <v-card class="pa-6">
    <v-col>
      <v-card class="pa-6 ma-2" variant="outlined">
        <h2>Character Info:</h2>
        <p><b>Name: </b> {{ main?.characterData.name }}</p>
        <p><b>Culture: </b> {{ main?.characterData.culture }}</p>
        <p><b>Religion: </b> {{ main?.characterData.religion }}</p>
        <p><b>Father's Name: </b> {{ main?.characterData.fatherName }}</p>
        <p><b>Father's Class: </b> {{ main?.characterData.fatherClass }}</p>
        <p><b>Child Number: </b> {{ main?.characterData.childNumber }}</p>
        <p><b>Current Class: </b> {{ main?.characterData.currentClass }}</p>
        <p><b>Year Born: </b> {{ main?.characterData.yearBorn }}</p>
        <p><b>Age: </b> {{ main?.characterData.age }}</p>
      </v-card>
      <v-card class="pa-6 ma-2" variant="outlined">
        <v-row><h2>Personality Traits:</h2></v-row>
        <v-row>
            <v-icon v-if="chaste" size="small">mdi-check-circle-outline</v-icon>
            <v-icon v-if="!chaste" size="small">mdi-circle-outline</v-icon>
            <p><b>Chaste</b> . . . . . {{ main?.traits.chaste.value }} / {{ main?.traits.lustful.value }} . . . . . <b>Lustful</b></p>
            <v-icon v-if="lustful" size="small">mdi-check-circle-outline</v-icon>
            <v-icon v-if="!lustful" size="small">mdi-circle-outline</v-icon>
        </v-row>
        <v-row>
            <v-icon v-if="energetic" size="small">mdi-check-circle-outline</v-icon>
            <v-icon v-if="!energetic" size="small">mdi-circle-outline</v-icon>
            <p><b>Energetic</b> . . . . . {{ main?.traits.energetic.value }} / {{ main?.traits.lazy.value }} . . . . . <b>Lazy</b></p>
            <v-icon v-if="lazy" size="small">mdi-check-circle-outline</v-icon>
            <v-icon v-if="!lazy" size="small">mdi-circle-outline</v-icon>
        </v-row>
        <v-row>
            <v-icon v-if="forgiving" size="small">mdi-check-circle-outline</v-icon>
            <v-icon v-if="!forgiving" size="small">mdi-circle-outline</v-icon>
            <p><b>Forgiving</b> . . . . . {{ main?.traits.forgiving.value }} / {{ main?.traits.vengeful.value }} . . . . . <b>Vengeful</b></p>
            <v-icon v-if="vengeful" size="small">mdi-check-circle-outline</v-icon>
            <v-icon v-if="!vengeful" size="small">mdi-circle-outline</v-icon>
        </v-row>
      </v-card>
    </v-col>
  </v-card>
</template>
<script lang="ts" setup>
import { PDCharacter } from '@/scripts/PDCharacter'


const props = defineProps({
    main: PDCharacter
})

let chaste = props.main?.traits.chaste.check
let lustful = props.main?.traits.lustful.check
let energetic = props.main?.traits.energetic.check
let lazy = props.main?.traits.lazy.check
let forgiving = props.main?.traits.forgiving.check
let vengeful = props.main?.traits.vengeful.check
let generous = props.main?.traits.generous.check
let selfish = props.main?.traits.selfish.check
let honest = props.main?.traits.honest.check
let deceitful = props.main?.traits.deceitful.check
let just = props.main?.traits.just.check
let arbitrary = props.main?.traits.arbitrary.check
let merciful = props.main?.traits.merciful.check
let cruel = props.main?.traits.cruel.check
let modest = props.main?.traits.modest.check
let proud = props.main?.traits.proud.check
let pious = props.main?.traits.pious.check
let wordly = props.main?.traits.wordly.check
let prudent = props.main?.traits.prudent.check
let reckless = props.main?.traits.reckless.check
let temperate = props.main?.traits.temperate.check
let indulgent = props.main?.traits.indulgent.check
let trusting = props.main?.traits.trusting.check
let suspicious = props.main?.traits.suspicious.check
let valorous = props.main?.traits.valorous.check
let cowardly = props.main?.traits.cowardly.check
</script>
