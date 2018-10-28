<template>
    <b-container fluid class="page">
        <b-row>
            <b-col cols="3">
                
            </b-col>

            <b-col cols="9">
                <exam-list :exams="exams" />
            </b-col>
        </b-row>
    </b-container>
</template>

<script>
    import ExamList from "../components/exam/ExamList.vue";

    import axios from "axios";

    export default {
        name: "examlist",

        data() {
            return {
                exams: []
            };
        },

        beforeRouteEnter(to, from, next) {
            axios.get("/api/exams",{
                param: to.query
            }).then(response =>{
                next(vm => vm.setData(response.data));
            });
        },

        methods: {
            setData(exams) {
                this.exams = exams;
            }
        },

        components: {
            ExamList
        }
    };
</script>
