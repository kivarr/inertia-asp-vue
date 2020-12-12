<template>
  <button type="button" @click="show = true" ref="button">
    <slot />
    <teleport v-if="show" to="#dropdown">
      <div>
        <div style="position: fixed; top: 0; right: 0; left: 0; bottom: 0; z-index: 99998; background: black; opacity: .2" @click="show = false" />
        <div class="dp-buttons" ref="dropdown" style="position: absolute; z-index: 99999;" @click.stop="show = !autoClose">
          <slot name="dropdown" />
        </div>
      </div>
    </teleport>
  </button>
</template>

<script lang="ts">
import Popper from 'popper.js'
import { defineComponent, watch, ref, PropType, onMounted, nextTick } from 'vue'

const Component = defineComponent({
  props: {
    placement: {
      type: String as PropType<Popper.Placement>,
      default: 'bottom-end',
    },
    boundary: {
      type: String as PropType<"scrollParent" | "viewport">,
      default: 'scrollParent',
    },
    autoClose: {
      type: Boolean,
      default: true,
    },
  },
  setup(props) {
    const button = ref<null | Element>(null);
    const dropdown = ref<null | Element>(null);
    const show = ref<boolean>(false);
    const popper = ref<null | Popper>(null);

    onMounted(() => {
      document.addEventListener('keydown', (e) => {
        if (e.keyCode === 27) {
          show.value = false
        }
      })
    })
    
    watch(
        show,
        (show) => {
          if (show) {
            nextTick(() => {
              if (button.value && dropdown.value) {
                popper.value = new Popper(button.value, dropdown.value, {
                  placement: props.placement,
                  modifiers: {
                    preventOverflow: { boundariesElement: props.boundary },
                  },
                });
              }
            });
          }else if (popper.value) {
            setTimeout(() => popper.value?.destroy(), 100)
          }
        }
    )
    
    return {
      button,
      dropdown,
      show
    }
  }
});
export default Component;
</script>

<style lang="scss" scoped>
  .dp-buttons{
    button {
      width: 100%;
    }
  }
</style>