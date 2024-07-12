<template>
  <div class="tshirts">
    <div v-for="shirt in shirtsList" :key="shirt" class="tshirt-item">
      <img :src="require(`@/assets/${shirt.Name}.png`)"/>
      <p><strong>{{ shirt.Name }}</strong></p>
      <p>Price: ${{ shirt.Price }}</p>
    </div>
  </div>
</template>

<script>
import { getFunctionTemplate } from "../plugins/axios"

export default {
  data() {
    return {
      shirtsList: [{ "Name": "Trees", "Price": 14.99}]
    }
  },
  async beforeMount() {
    let shirtsListFetch = await getFunctionTemplate("/api/Ui", "Failed to render images from DB")
    if (shirtsListFetch) {
      this.shirtsList = shirtsListFetch
    }
  }
}
</script>

<style scoped>
img {
  width: 50vh;
  height: 50vh;
}

.tshirts {
  display: flex;
  flex-wrap: wrap;
}

.tshirt-item {
  flex: 1;
  width: calc(100% - 5vh);
  height: calc(100% - 5vh);
  margin-left: 5vh;
}
</style>
