<template>
  <v-app>
    <span class="bg"></span>
    <v-app-bar :elevation="3">
      <template v-slot>
        <v-app-bar-title>
          <RouterLink to="/">
            <v-icon icon="mdi-leaf" color="primary"></v-icon>
            Wordle
          </RouterLink>
        </v-app-bar-title>
        <v-spacer></v-spacer>
        <v-btn icon="mdi-trophy-outline"></v-btn>
      </template>
    </v-app-bar>

    <v-main>
      <RouterView />
    </v-main>
  </v-app>
</template>

<script setup lang="ts">
//
</script>
