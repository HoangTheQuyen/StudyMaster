﻿<template>
    <div class="topics">
        <b-row class="mt-4">
            <b-col class="mb-4" sm="6" v-for="topic in topics" :key="topic.id">
                <b-media class="topic">
                    <img slot="aside" :src="topic.thumbnail" :alt="topic.name" @click="view(topic)" />

                    <h2 class="mt-2" @click="view(topic)">{{ topic.name }} </h2>
                    <div>
                        <br />
                        <br />
                        <b-button variant="success" @click="view(topic)">Xem Bài Giảng</b-button>
                        <b-button variant="primary" @click="examiation(topic)">Thi Online</b-button>
                    </div>
                </b-media>
            </b-col>
        </b-row>
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
        },
        examiation(topic){
            this.$router.push(`/exams/${topic.examSlug}`);
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
