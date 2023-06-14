<template>
    <v-card>
        <v-card>
            <p><b>Player: </b> {{ main?.playerUN }}</p>
            <p>---------------</p>
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
    </v-card>
</template>
<script lang="ts" setup>
    import { PDCharacter } from '@/scripts/PDCharacter'

    const props = defineProps({
        main: PDCharacter
    })
</script>