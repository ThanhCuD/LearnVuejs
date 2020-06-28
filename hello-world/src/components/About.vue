<template>
    <section class="page-section" id="about">
            <div class="container">
                <div class="text-center">
                    <h2 class="section-heading text-uppercase">About</h2>
                    <h3 class="section-subheading text-muted">Lorem ipsum dolor sit amet consectetur.</h3>
                </div>
                <ul class="timeline">
                    <li :class="isInvertedClass(key)"  v-for="(item,key) in jsonData" :key="key">
                        <div class="timeline-image"><img class="rounded-circle img-fluid" :src="item.src" alt="" /></div>
                        <div class="timeline-panel">
                            <div class="timeline-heading">
                                <h4>{{item.heading}}</h4>
                                <h4 class="subheading">{{item.subheading}}</h4>
                            </div>
                            <div class="timeline-body"><p class="text-muted">{{item.body}}</p></div>
                        </div>
                    </li>
                    <li class="timeline-inverted">
                        <div class="timeline-image">
                            <h4>
                                Be Part
                                <br />
                                Of Our
                                <br />
                                Story!
                            </h4>
                        </div>
                    </li> 
                </ul>
            </div>
        </section>
</template>
<script>
export default {
    data: () =>({
        jsonData: [{
            heading: "2009-2011",
            subHeading: "Our Humble Beginnings",
            src: "assets/img/about/1.jpg",
            body: "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt ut voluptatum eius sapiente, totam reiciendis temporibus qui quibusdam, recusandae sit vero unde, sed, incidunt et ea quo dolore laudantium consectetur!"
        },{
            heading: "2009-2011",
            subHeading: "Our Humble Beginnings",
            src: "assets/img/about/1.jpg",
            body: "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt ut voluptatum eius sapiente, totam reiciendis temporibus qui quibusdam, recusandae sit vero unde, sed, incidunt et ea quo dolore laudantium consectetur!"
        }
        ]
    }),
    methods: {
        isInvertedClass(key){
            return key%2==1? "timeline-inverted":"";
        }
    }
}
</script>
<style scoped>

</style>