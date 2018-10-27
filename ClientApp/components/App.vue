<template>
<div class="app">
    <b-navbar toggleable="md" type="dark" variant="dark">
        <b-container>
            <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>

            <b-navbar-brand to="/">StudyMaster</b-navbar-brand>

            <b-collapse is-nav id="nav_collapse">
                <b-navbar-nav>
                    <b-nav-item to="/topics">Topics</b-nav-item>
                </b-navbar-nav>
            </b-collapse>

        </b-container>
    </b-navbar>

    <transition>
        <router-view />
    </transition>

</div>
</template>

<style lang="scss">
html,
body {
    height: 100vh;
}

div.app,
div.page {
    height: 100% !important;
}
</style>
