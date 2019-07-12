using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class DocumentRecord:EntityBase
    {
        [Required]
        public int RecordId { get; set; } // EmployeeId,LeaveId,TransferPromotionId
        [Required]
        public int AttachmentFor { get; set; }//0-Appointment, 1-TransferorPromotion, 2-Leave , 3-Registration 
        public string Name { get; set; }
        [Required]
        public byte[] Attachment { get; set; }

    }
}
