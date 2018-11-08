<template>
    <div class="app">
        <b-navbar toggleable="md" type="dark" variant="dark">
            <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>

            <b-navbar-brand to="/">StudyMaster</b-navbar-brand>

            <b-collapse is-nav id="nav_collapse">
                <b-navbar-nav>
                    <b-nav-item to="/topics">Topics</b-nav-item>
                    <b-nav-item to="/exams">Exams</b-nav-item>
                </b-navbar-nav>

                <b-navbar-nav class="ml-auto mr-4">
                    <auth-nav-item />
                </b-navbar-nav>
            </b-collapse>
        </b-navbar>

        <transition name="fade" mode="out-in">
            <router-view />
        </transition>

        <auth-modal :show="showAuthModal" />
    </div>
</template>

<script>
    import AuthNavItem from "./app/AuthNavItem.vue";
    import AuthModal from "./app/AuthModal.vue";

    export default {
        name: "app",

        components: {
            AuthNavItem,
            AuthModal
        },

        computed: {
            showAuthModal() {
                return this.$store.state.showAuthModal;
            }
        }
    };
</script>


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
