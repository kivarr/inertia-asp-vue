<template>
  <button :disabled="loading" class="flex items-center">
    <div v-if="loading" class="btn-spinner mr-2" />
    <slot />
  </button>
</template>

<script lang="ts">
import {defineComponent, ref} from "vue";
export default defineComponent({
  props: {
    loading: Boolean,
  },
  setup(props) {
    return {}
  }
})
</script>

<style lang="scss">
.btn-indigo {
  @apply px-6 py-3 rounded bg-indigo-600 text-white text-sm font-bold whitespace-no-wrap;

  &:hover, &:focus { 
    @apply bg-orange-500;
  }
}

.btn-spinner,
.btn-spinner:after {
  border-radius: 50%;
  width: 1.5em;
  height: 1.5em;
}

.btn-spinner {
  font-size: 10px;
  position: relative;
  text-indent: -9999em;
  border-top: .2em solid white;
  border-right: .2em solid white;
  border-bottom: .2em solid white;
  border-left: .2em solid transparent;
  transform: translateZ(0);
  animation: spinning 1s infinite linear;
}

@keyframes spinning {
  0% { transform: rotate(0deg) }
  100% { transform: rotate(360deg) }
}
</style>