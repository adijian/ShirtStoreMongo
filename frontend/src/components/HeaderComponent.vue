<template>
  <div class="header">
    <div class="logo">
      Poloso
    </div>
      <nav class="navbar">
        <router-link to="/">_Home</router-link> |
        <router-link to="/store">_Store</router-link> |
        <router-link to="/about">_About</router-link>
      </nav>
    </div>
</template>
  
<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Playwrite+CU:wght@100..400&display=swap');
@import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&family=Playwrite+HR+Lijeva:wght@100..400&family=Playwrite+HR:wght@100..400&display=swap');

.header {
  display: flex;
  align-items: center;
  justify-content: center;
  border-bottom: 1px solid rgba(48, 48, 48, 0.16);
  margin-bottom: 50px;
}

.logo {
  border-right: 1.5px solid black;
  padding-right: 2vh;
  font-family: "Playwrite CU", cursive;
  font-optical-sizing: auto;
  font-weight: 800;
  font-style: normal;
  font-size: 30px;
  padding-left: 2vh;
}

.navbar {
  width: 180vh;
  font-family: "Bebas Neue", sans-serif;
  font-size: 30px;
  letter-spacing: 1vh;
  font-optical-sizing: auto;
  font-weight: 400;
  font-style: normal;
}
</style>
  