namespace repairequipment.models
{
    public class Client
    {
        /// <summary>
        /// Получает или задает уникальный идентификатор клиента.
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Получает или задает имя клиента.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Получает или задает адрес клиента.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Получает или задает электронную почту клиента.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Получает или задает номер телефона клиента.
        /// </summary>
        public string Phone { get; set; }
        
    }
}
