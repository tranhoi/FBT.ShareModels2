﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.WMS;

[Table("WarehousePutAways")]
public class WarehousePutAway : GenericEntity
{
    [Key] public Guid Id { get; set; }

    public string PutAwayNo { get; set; }
    public string ReceiptNo { get; set; }

    public string? Description { get; set; }

    public int TenantId { get; set; }

    public DateOnly? TransDate { get; set; }

    public DateOnly? DocumentDate { get; set; }

    public string? DocumentNo { get; set; }

    public string Location { get; set; }

    public DateOnly? PostedDate { get; set; }

    public string? PostedBy { get; set; }
    public EnumPutAwayStatus Status { get; set; } = EnumPutAwayStatus.PutAway;

}