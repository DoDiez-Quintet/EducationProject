using TransportLogistics.Domain.Models.Order;

namespace TransportLogistics.Domain.Models.Reports
{
    /// <summary>
    /// ����� ������ �� ������
    /// </summary>
    class Report
    {
        /// <summary>
        /// ������������� ������
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// ���� ������
        /// </summary>
        public DateTime DateStart { get; set; }

        /// <summary>
        /// ���� ���������
        /// </summary>
        public DateTime DateEnd { get; set; }
        
        /// <summary>
        /// ������ � ������
        /// </summary>
        public List<Orders> Orders { get; set; }
    }
}
