<template>
  <v-app>
    <span class="bg"></span>
    <v-app-bar color="#4b281b" fixed dense>
      <h3 class="ma-3">Hello, Vulpyx!</h3>
      <v-spacer></v-spacer>
      <v-btn icon="mdi-menu"></v-btn>
    </v-app-bar>

    <v-main>
      <RouterView />
    </v-main>
  </v-app>
</template>
