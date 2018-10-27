<template>
<div class="topics">
    <h1>Topics</h1>

    <div class="list">
        <div class="item" v-for="topic in topics" :key="topic.slug">

            <h3 @click="select(topic)">{{ topic.name }}</h3>

            <img :src="topic.thumbnail" :alt="topic.name" @click="select(topic)" />

            <p @click="select(topic)">
                    {{ topic.lectureContent }}
            </p>

            <hr />

        </div>
    </div>

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
        select(topic) {
            this.$router.push(`/topics/${topic.slug}`);
        }
    }

};
</script>

<style>
* {
    box-sizing: border-box !important;
}

.topics {
    padding: 20px;
    max-width: 1200px;
    margin: 0 auto;
}

.list,
.details {
    width: 50%;
    float: left;
}

.list .item {
    width: 50%;
    float: left;
    padding: 20px 10px 20px 0;
}

.list img,
.list h3,
.list p {
    cursor: pointer;
}

.list img {
    width: 100px;
}
</style>
