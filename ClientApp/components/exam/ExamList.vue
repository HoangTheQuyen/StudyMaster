<template>
    <div class="exams">
        <b-row class="mt-4">
            <b-col class="mb-4" sm="6" v-for="exam in exams" :key="exam.id">
                <b-media class="topic">
                    <img slot="aside" :src="exam.thumbnail" :alt="exam.description" @click="view(exam)" />

                    <h2 class="mt-2" @click="view(exam)">{{ exam.description }} </h2>

                    <h3 class="mt-2">Loại bài thi: {{exam.type}}</h3>

                    <div class="mb-4">
                        <br />
                        <b-button variant="primary" @click="view(exam)">Thi Online</b-button>
                    </div>
                </b-media>
            </b-col>
        </b-row>
    </div>
</template>

<script>
export default {
    name: "exam-list",

    props: {
        exams: {
            type: Array,
            required: true
        }
    },

    methods: {
        view(exam) {
            this.$router.push(`/exams/${exam.slug}`);
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
