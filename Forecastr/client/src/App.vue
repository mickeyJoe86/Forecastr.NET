<template>
  <body>    
    <div id="app">
      <navigation-component></navigation-component>  
      <router-view/>
    </div>
  </body>
</template>

<script>
import 'vue-material/dist/vue-material.css'
import NavigationComponent from './components/Header'

export default {
  name: 'app',
    components: {
    NavigationComponent    
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
