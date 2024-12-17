namespace repairequipment.models
{
    /// <summary>
    /// Класс для представления запроса на ремонт оборудования.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Уникальный идентификатор запроса.
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// Название запроса.
        /// </summary>
        public string Requestname { get; set; }

        /// <summary>
        /// Дата создания запроса.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Описание запроса.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Текущее состояние запроса (например, активен, выполнен и т.д.).
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Идентификатор клиента, связанного с запросом.
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Идентификатор устройства, требующего ремонта.
        /// </summary>
        public int DeviceId { get; set; }

        /// <summary>
        /// Идентификатор сотрудника, ответственного за выполнение запроса.
        /// </summary>
        public int EmloyeeId { get; set; }
    }
}
