<template>
  
  <div class="main">

    <div v-for="task in tasks">
        {{ task }}
    </div>
    
  </div>

</template>

<script>

export default {
  name: 'Main',
  data() {
    return {
      tasks: []
    }
  },
  mounted() {
    fetch('http://localhost:8080/api/tasks')
      .then(response => response.json())
      .then(data => this.tasks = data)
  }
}

</script>

<style scoped>

</style>
