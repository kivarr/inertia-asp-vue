<template>
  <div v-bind="$attrs">
    <label v-if="label" class="form-label" :for="id">{{ label }}:</label>
    <select :id="id" ref="input" :value="value" class="form-select" :class="{ error: error }" @input="$emit('update:value', $event.target.value)">
      <slot />
    </select>
    <div v-if="error" class="form-error">{{ error }}</div>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref, watch } from "vue";
export default defineComponent({
  inheritAttrs: false,
  props: {
    id: {
      type: String,
      default() {
        return `text-input-${Math.random()}`
      },
    },
    value: String,
    label: String,
    error: String,
  },
  setup(props) {
    const input = ref<null | Element>(null);
    
    // const focus = () => {
    //   if (input.value != null)
    //     input.value.focus();
    // }
    //
    // const select = () => {
    //   if (input.value != null)
    //     input.value.select();
    // }
    
    return {
      input,
      // focus,
      // select
    }
  }
});
</script>