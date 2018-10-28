<template>
    <div class="filters mb-4">
        <h5 class="mt-4">Filters</h5>

        <b-btn variant="outline-secondary" @click.prevent="reset">
            <i class="fas fa-sync mr-2"></i> Reset
        </b-btn>
        <b-list-group class="mt-4">

            <filter-accordion>
                <span slot="header">Subject</span>

                <b-row slot="body">
                    <b-col cols="6">
                        <div :class="{ 'filter-item': true, 'active': subjects.length === 0 }" @click="clearSubjects">All</div>
                    </b-col>

                    <b-col cols="6" v-for="item in filters.subjects" :key="item">
                        <div :class="{ 'filter-item': true, 'active': subjects.indexOf(item) > -1 }" @click="filterSubject(item)">
                            {{ item }}
                        </div>
                    </b-col>
                </b-row>
            </filter-accordion>
        </b-list-group>
    </div>
</template>

<script>
    import FilterAccordion from "./FilterAccordion.vue";
    import vueSlider from "vue-slider-component";

    export default {
        name: "filters",

        props: {
            filters: {
                type: Object,
                required: true
            }
        },

        components: {
            FilterAccordion,
            vueSlider
        },

        computed: {
            subjects() {
                return this.$route.query.subjects || "";
            }
        },

        methods: {
            reset() {
                this.$router.push({
                    query: {}
                });
            },

            clearSubjects() {
                if (this.subjects.length) {
                    let query = Object.assign({}, this.$route.query);

                    delete query.subjects;

                    this.$router.push({
                        query: query
                    });
                }
            },

            filterSubject(subject) {
                let query = Object.assign({}, this.$route.query);

                let split = query.subjects ? query.subjects.split("|") : [];

                if (split.indexOf(subject) > -1) {
                    let index = split.indexOf(subject);
                    split.splice(index, 1);
                } else {
                    split.push(subject);
                }

                if (split.length) {
                    let joined = split.join("|");
                    query.subjects = joined;
                } else {
                    delete query.subjects;
                }

                this.$router.push({
                    query: query
                });
            }

        }
    };
</script>

<style lang="scss" scoped>
    .filter-item {
        margin: 10px 0;
        border: 1px solid #ccc;
        border-radius: 5px;
        padding: 10px;
        text-align: center;
        cursor: pointer;
        &.active

    {
        font-weight: bold;
        color: #17a2b8;
        border-color: #17a2b8;
    }

    }

    .slider {
        padding: 35px 0 10px 10px;
    }
</style>
