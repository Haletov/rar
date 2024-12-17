namespace repairequipment.models
{
    /// <summary>
    /// Представляет сотрудника, работающего в службе ремонта.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Получает или задает уникальный идентификатор сотрудника.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Получает или задает имя сотрудника.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Получает или задает должность сотрудника.
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// Получает или задает номер телефона сотрудника.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Получает или задает адрес сотрудника.
        /// </summary>
        public string Address { get; set; }
    }
}
