<template>
<!-- <div class="d-flex flex-column fill-height justify-center align-center text-white"></div> -->
  <v-card class="charCard">
    <v-expansion-panels variant="accordion">
      <v-expansion-panel>
        <v-expansion-panel-title>Item</v-expansion-panel-title>
        <v-expansion-panel-text>Lorem ipsum.</v-expansion-panel-text>
      </v-expansion-panel>
      <v-expansion-panel>
        <v-expansion-panel-title>Item</v-expansion-panel-title>
        <v-expansion-panel-text>Lorem ipsum.</v-expansion-panel-text>
      </v-expansion-panel>
    </v-expansion-panels>
  </v-card>
</template>
<style>
.charCard {
  margin: 5px;
  padding: 5px !important;
  background-color: rgba(242, 211, 169) !important;
  border: 1px solid #4b281b !important;
  filter: drop-shadow(5px 8px 3px #3b3b3b);
}
</style>
