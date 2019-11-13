function ProductEdit() { }

ProductEdit.prototype = new GiftCardBase();

//新建商品信息
ProductEdit.prototype.openInfoWindow = function () {
    var self = this;
    self.addTab("新增商品", "/Product/Product/Edit");
}

//初始化数据
var productEdit = new ProductEdit();



