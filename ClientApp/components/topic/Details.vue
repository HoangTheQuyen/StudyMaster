<template>
<div class="details">
    <h1>{{ topic.name }}</h1>

    <img :src="topic.thumbnail" :alt="topic.name" />

    <p>{{ topic.lectureContent }}</p>
</div>
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