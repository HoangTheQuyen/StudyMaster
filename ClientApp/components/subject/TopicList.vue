<template>
<div class="topics">
    <b-container>
        <h1 class="mt-4 mb-4">Topics</h1>
        
        <b-row>
            <b-col class="mb-4" sm="6" v-for="topic in topics" :key="topic.id">

                <b-media class="topic">
                    <img slot="aside" v-bind:src="a" :alt="topic.name" @click="view(topic)" />

                    <h2 class="mt-2" @click="view(topic)">{{ topic.name }}</h2>
                </b-media>

            </b-col>
        </b-row>
    </b-container>
</div>
</template>

<script>
export default {
    name: "topic-list",

    props: {
        topics: {
            type: Array,
            required: true
        }
    },

    methods: {
        view(topic) {
            this.$router.push(`/topics/${topic.slug}`);
        }
    }

};
</script>


<style lang="scss" scoped>
.topic {
    border: 3px solid #eee;

    img,
    h2 {
        cursor: pointer;
    }
}
</style>
