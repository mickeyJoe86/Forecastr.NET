<template>
  <div>    
    <div class="main-content">
      <h2>{{msg}}</h2>
      <h3>Stay tuned</h3>
    </div>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  data () {
    return {
      msg: 'Forecastr rebuild with .NET API and Vue.js front end coming soon...'
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1, h2 {
  font-weight: normal;
}
</style>
