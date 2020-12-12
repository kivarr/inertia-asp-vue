<template>
  <div v-bind="$attrs">
    <label v-if="label" class="form-label" :for="id">{{ label }}:</label>
    <input :id="id" ref="input" class="form-input" :class="{ error: error }" :type="type" :value="value" @input="$emit('update:value', $event.target.value)">
    <div v-if="error" class="form-error">{{ error }}</div>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";
export default defineComponent({
  inheritAttrs: false,
  props: {
    id: {
      type: String,
      default() {
        return `text-input-${Math.random()}`
      },
    },
    type: {
      type: String,
      default: 'text',
    },
    value: String,
    label: String,
    error: String,
  },
  setup(props) {
    
  }
});
</script>