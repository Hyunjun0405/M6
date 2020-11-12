using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace M6.Data
{
    [MetadataType(typeof(publicEnum))]
    [Table("상품", Schema ="Product")]
    public partial class Product
    {
        
        [Column("상품번호", TypeName = "ID"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = true, GroupName = "<Key|>",  Description = "", Prompt = "")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public Int64? ID { get; set; } // bigint

        [Column("상품종류", TypeName = "CD"), Required(AllowEmptyStrings = false, ErrorMessage = "코드는 필수선택입니다.")]
        [Display( GroupName = "<Key|>", Description = "", Prompt = "")]
        [EnumDataType(typeof(publicEnum.enum상품_상품종류), ErrorMessage = "")]
        public int? ProductType { get; set; } // int
        
        [Column("상품명", TypeName = "TITLE"), Required(AllowEmptyStrings = false, ErrorMessage = "이름은 필수입니다."), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(GroupName = "",  Description = "", Prompt = "")]
        [MaxLength(200), StringLength(100)]
        public string Name { get; set; } // varchar(200)

        [Column("일수", TypeName = "QUANTITY"), DataType(DataType.Currency), Required(AllowEmptyStrings = true, ErrorMessage = "수령은 필수입니다"), Editable(false)]
        [Display(GroupName = "일정-", Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "#", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        public short? Days { get; set; } // smallint

        [Column("숙박일수", TypeName = "QUANTITY"), DataType(DataType.Currency), Required(AllowEmptyStrings = true, ErrorMessage = "수령은 필수입니다"), Editable(false)]
        [Display(GroupName = "일정-",  Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "#", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        public short? Stays { get; set; } // smallint

        [Column("현지출도착", TypeName = "QUANTITY"), Required(AllowEmptyStrings = true, ErrorMessage = "수령은 필수입니다"), Editable(false)]
        [Display(GroupName = "일정-",  Description = "", Prompt = "0")]
        public string DepRtn { get; set; } // varchar(100)

        [Column("대표이미지경로", TypeName = "URL"), DataType(DataType.ImageUrl), Required(AllowEmptyStrings = false, ErrorMessage = "대표이미지는 필수입니다")]
        [Display(GroupName = "",  Description = "", Prompt = "")]
        
        public string ImageUrl { get; set; } // varchar(200)

        [Column("간략설명", TypeName = "DESC1"), DataType(DataType.MultilineText), Required(AllowEmptyStrings = true, ErrorMessage = ""), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(GroupName = "", Description = "", Prompt = "")]
        [MaxLength(1000), StringLength(500)]
        public string ShortDesc { get; set; } // varchar(1000)

        public string Tags { get; set; } // varchar(max)

        [Column("일정", TypeName = "JSON"), DataType(DataType.MultilineText), Required(AllowEmptyStrings = true, ErrorMessage = ""), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(GroupName = "{Tabs}/일정",Description = "", Prompt = "")]
        public string Itinerary { get; set; } // varchar(max)

        [Column("설명", TypeName = "TXT"), DataType(DataType.MultilineText), Required(AllowEmptyStrings = true, ErrorMessage = ""), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(GroupName = "{Tabs}/상세설명", Description = "", Prompt = "")]
        public string LongDesc { get; set; } // varchar(max)



        [Column("행사날짜기준", TypeName = "CD"), Required(AllowEmptyStrings = false, ErrorMessage = "코드는 필수선택입니다.")]
        [Display( GroupName = "Rule-", Description = "", Prompt = "")]
        [EnumDataType(typeof(publicEnum.enum상품_행사날짜기준), ErrorMessage = "")]
        public int? SessionDateType { get; set; } // int

        [Column("좌석확정기준", TypeName = "CD"), Required(AllowEmptyStrings = false, ErrorMessage = "코드는 필수선택입니다.")]
        [Display( GroupName = "Rule-",   Description = "", Prompt = "")]
        [EnumDataType(typeof(publicEnum.enum상품_좌석확정기준), ErrorMessage = "")]
        public int? ConfirmType { get; set; } // int

        [Column("대기예약허용", TypeName = "BIT"), Required(AllowEmptyStrings = false, ErrorMessage = "필수선택입니다.")]
        [Display( GroupName = "Rule-",   Description = "", Prompt = "")]
        public bool? IsWait { get; set; } // bit        

        [Column("완납시한기준", TypeName = "CD"), Required(AllowEmptyStrings = false, ErrorMessage = "코드는 필수선택입니다.")]
        [Display( GroupName = "Rule-",  Description = "", Prompt = "")]
        [EnumDataType(typeof(publicEnum.enum상품_완납시한기준), ErrorMessage = "")]
        public int? PaytDateType { get; set; } // int

        [Column("완납시한", TypeName = "QUANTITY"), DataType(DataType.Duration), Required(AllowEmptyStrings = false, ErrorMessage = "수량은 필수입니다")]
        [Display(GroupName = "Rule-", Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "#", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        public short? PayLimitDays { get; set; } // smallint

        [Column("담당부서", TypeName = "FKID"), Required(AllowEmptyStrings = true, ErrorMessage = "")]
        [Display( GroupName = "Charge Person->",  Description = "", Prompt = "")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public Int64? DeptID { get; set; } // bigint

        [Column("담당자", TypeName = "FKID"), Required(AllowEmptyStrings = true, ErrorMessage = "")]
        [Display( GroupName = "Charge Person->",  Description = "", Prompt = "")]        
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public Int64? EmployeeID { get; set; } // bigint

        [Column("지역번호", TypeName = "FKID"), Required(AllowEmptyStrings = true, ErrorMessage = "")]
        [Display( GroupName = "Display Setting-",  Description = "", Prompt = "")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public Int64? AreaID { get; set; } // bigint

        [Column("카테고리번호", TypeName = "FKID"), Required(AllowEmptyStrings = true, ErrorMessage = "")]
        [Display( GroupName = "Display Setting-",  Description = "", Prompt = "")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public Int64? CategoryID { get; set; } // bigint

        [Column("카달로그번호", TypeName = "FKID"), Required(AllowEmptyStrings = true, ErrorMessage = "")]
        [Display( GroupName = "Display Setting-",  Description = "", Prompt = "")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public Int64? CatalogID { get; set; } // bigint
    }

}
