<template>
<div class="topics">
    <h1>Topics</h1>

    <div class="list">
        <div class="item" v-for="topic in topics" :key="topic.slug">
            <h3 @click="select(topic)">{{ topic.name }}</h3>

            <img :src="topic.thumbnail" :alt="topic.name" @click="select(topic)" />

            <hr />
        </div>
    </div>

    <topic-details class="details" v-if="selectedTopic" :topic="selectedTopic" />

</div>
</template>

<script>

import TopicDetails from './Details.vue'

export default {
    name: "topic-list",
    components: {
        TopicDetails
    },
    data() {
        return {
            topics: [{
                    name: "Chủ đề hàm số",
                    slug: "Chu-De-Ham-So",
                    thumbnail: "http://placehold.it/200x300",
                    lectureContent: `Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis
                                tempora ad cum laudantium, omnis fugit amet iure animi corporis labore repellat magnam
                                perspiciatis explicabo maiores fuga provident a obcaecati tenetur nostrum, quidem quod
                                dignissimos, voluptatem quasi? Nisi quaerat, fugit voluptas ducimus facilis impedit
                                quod dicta, laborum sint iure nihil veniam aspernatur delectus officia culpa, at
                                cupiditate? Totam minima ut deleniti laboriosam dolores cumque in, nesciunt optio! Quod
                                recusandae voluptate facere pariatur soluta vel corrupti tenetur aut maiores, cumque
                                mollitia fugiat laudantium error odit voluptas nobis laboriosam quo, rem deleniti? Iste
                                quidem amet perferendis sed iusto tempora modi illo tempore quibusdam laborum? Dicta
                                aliquam libero, facere, maxime corporis qui officiis explicabo aspernatur non
                                consequatur mollitia iure magnam odit enim. Eligendi suscipit, optio officiis repellat
                                eos quis iure? Omnis, error aliquid quibusdam iste amet nihil nisi cumque magni sequi
                                enim illo autem nesciunt optio accusantium animi commodi tenetur neque eum vitae est.`
                }
            ],
            selectedTopic: null
        }
    },
    methods: {
        select(topic) {
            this.selectedTopic = topic;
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
