<template>
<b-container class="pt-4">
    <b-media>
        <img slot="aside" :src="a" :alt="topic.name" />
        <h2>{{ topic.name }}</h2>

    </b-media>
    <h3 class="mt-4">Topic details</h3>
    <p class="mt-4 mb-4">
        {{ topic.lectureContent }}
    </p>
</b-container>
</template>

<script>
export default {
    name: "topic-details",
    props: {
        topic: {
            type: Object,
            required: true
        }
    }
};
</script>

<style>
.details {
    padding: 20px;
}
</style>
