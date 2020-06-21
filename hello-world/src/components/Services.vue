<template>
    <section class="page-section" id="services">
            <div class="container">
                
                <div class="text-center">
                    <h2 class="section-heading text-uppercase">Dịch Vụ</h2>
                    <h3 class="section-subheading text-muted">Các dịch vụ shop cung cấp</h3>
                </div>
                <div class="row text-center">
                    <div class="col-md-4" v-for="(item,key) in jsonArray" :key="key">
                        <span class="fa-stack fa-4x">
                            <i class="fas fa-circle fa-stack-2x text-primary"></i>
                            <i :class= "class2(item.icon)" class="fas fa-stack-1x fa-inverse"></i>
                        </span>
                        <h4 class="my-3">{{ item.title }}</h4>
                        <p class="text-muted">{{ item.description }}</p>
                    </div>
                </div>
            </div>
        </section>
</template>
<script>
export default {
    data: () =>({
        jsonArray : [{
            title : "Shave Body (Cạo lông toàn thân)",
            description : "Cạo lông máu hoặc các bé có vấn đềvề da như viêm da, nấm da..",
            icon : "fa-shopping-cart"
        },
        {
            title : "Special Care ( Chăm sóc đặt biệt)",
            description : "Combo bao gồm: Tắm bằng dầu gội mượt lông và thơm lâu, vệ sinh tuyến hậu môn, vệ sinh tai, cạo lông lòng bàn chân, cắt tỉa lông tạo kiểu, cắt và dũa móng ",
            icon : "fa-laptop"
        }
        ,{
            title : "Bassic care ( Chăm sóc cơ bản)",
            description : "Combo bao gồm: tắm bằng dầu gội mượt lông và thơm lâu, sấy bông và chải lông, vệ sinh tuyến hậu môn, vệ sinh tai, cắt móng và mài móng ",
            icon : "fa-lock"
        },{
            title : "Lưu Chuồng",
            description : "Chúng tôi đảm bảo cho thú cưng nhà bạn sống trong môi trường an toàn và sạch sẽ, chơi đùa cùng các bạn khác... ",
            icon : "fa-lock"
        }
        ]
    }),
    methods: {
        class2(salut) {
            return salut;
        }
    }
}
</script>
<style scoped>

</style>