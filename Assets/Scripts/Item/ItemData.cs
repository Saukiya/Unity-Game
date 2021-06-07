using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Game.Item {
    
    /**
     * 物品数据
     *
     * 支持序列化
     * 
     * 指向物品元数据
     * 提供：
     *
     * 元数据
     *
     * 名字
     *
     * 描述
     *
     * 属性
     * 
     * 数量
     * 
     * 耐久
     *
     * HashMap?
     * 
     * 
     */
    
    public class ItemData {
        
        private ItemMeta itemMeta;

        private string name;

        private string description;

        private int amount;

        private int durability;

        public ItemData([NotNull] ItemMeta meta) {
            itemMeta = meta;
        }

        public string GetName() {
            if (name == null) {
                //TODO 返回翻译名
                return itemMeta.GetDefaultName();
            }

            return name;
        }

        public void SetName(string value) {
            name = value;
        }

        public List<string> GetDescription() {
            return description == null ? new List<string>() : new List<string>(description.Split('\n'));
        }

        public void SetDescription(List<string> list) {
            description = list == null ? null : string.Join("\n", list);
        }

        public int GetAmount() => amount;

        public void SetAmount(int value) {
            amount = Math.Min(value, itemMeta.GetMaxAmount());
        }

        public int GetDurability() => durability;

        public void SetDurability(int value) {
            durability = Math.Min(value, itemMeta.GetMaxDurability());
        }
    }
}