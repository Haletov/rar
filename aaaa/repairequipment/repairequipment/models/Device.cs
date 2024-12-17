namespace repairequipment.models
{
    /// <summary>
    /// Представляет устройство, подлежащее ремонту.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Получает или задает уникальный идентификатор устройства.
        /// </summary>
        public int DeviceId { get; set; }

        /// <summary>
        /// Получает или задает название устройства.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Получает или задает тип устройства.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Получает или задает описание устройства.
        /// </summary>
        public string Description { get; set; }
    }
}

