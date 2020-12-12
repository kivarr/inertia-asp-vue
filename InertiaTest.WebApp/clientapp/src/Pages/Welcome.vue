<template>
  <div id="nav" class="">
    
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType, inject } from 'vue'

interface Controller {
  id: number
}

const Component = defineComponent({
  props: {
    controller: {
      type: Object as PropType<Controller>,
      required: false
    }
  },

  setup(props) {
  }
})
export default Component
</script>

<style lang="scss">

#app {
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  padding: 30px;
  div {
    @apply font-bold;
  }
  a {
    color: #2c3e50;

    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
</style>
