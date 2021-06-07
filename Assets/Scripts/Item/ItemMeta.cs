using UnityEngine;

namespace Game.Item {
    /**
     * 物品元数据
     *
     * 指物品的固定状态，不可变
     *
     * 例如ID、图片名、默认名字、最大堆叠数量、最大耐久，是否可使用
     *
     * 由表格序列化添加
     */
    public class ItemMeta {
        
        private string id;
        
        public bool IsUse => isUse;

        private string spriteName;

        private string defaultName;

        private int maxAmount;

        private int maxDurability;

        private bool isUse;

        public ItemMeta(string id, string spriteName, string defaultName, int maxAmount, int maxDurability, bool isUse) {
            this.id = id;
            this.spriteName = spriteName;
            this.defaultName = defaultName;
            this.maxAmount = maxAmount;
            this.maxDurability = maxDurability;
            this.isUse = isUse;
        }
        
        public string GetId() => id;
        
        public string GetSpriteName() => spriteName;
        
        public string GetDefaultName() => defaultName;
        
        public int GetMaxAmount() => maxAmount;
        
        public int GetMaxDurability() => maxDurability;

    }
}