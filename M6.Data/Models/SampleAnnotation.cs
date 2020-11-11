using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M6.Data.Models
{
    public class SampleAnnotation
    {
        #region ID        
        [Column("번호", TypeName = "ID"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = true, GroupName = "<Code|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public Int64 ID;

        //Foreign Table Refer
        [Column("번호", TypeName = "FK"), Required(AllowEmptyStrings = false, ErrorMessage = "")]     
        [Display(AutoGenerateFilter = true, GroupName = "<Code|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public Int64 FK;

        //Foreign Key  Refer
        [Column("번호", TypeName = "FKID"),Required(AllowEmptyStrings = true, ErrorMessage = "")]
        [Display(AutoGenerateFilter = true, GroupName = "<Code|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public Int64 FKID;

        [ForeignKey("StandardRefId")]
        public object Entity { get; set; }
        [InverseProperty("OnlineTeacher")]
        public ICollection<object> OnlineCourses { get; set; }
        [InverseProperty("ClassRoomTeacher")]
        public ICollection<object> ClassRoomCourses { get; set; }

        #endregion

        #region Code
        [Column("코드", TypeName = "CD"), Required(AllowEmptyStrings = false, ErrorMessage = "코드는 필수선택입니다.")]
        [Display(AutoGenerateFilter = true, GroupName = "<Code|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [EnumDataType(typeof(enumType), ErrorMessage = "")]
        public string Code;

        [Column("여부", TypeName = "BIT"), Required(AllowEmptyStrings = false, ErrorMessage = "필수선택입니다.")]
        [Display(AutoGenerateFilter = true, GroupName = "<Code|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        public bool? TF;

        #endregion

        #region 문자
        [Column("이름", TypeName = "TITLE"), Required(AllowEmptyStrings = false, ErrorMessage ="이름은 필수입니다."), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "<Name|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [MaxLength(200), StringLength(100)]
        public string Title;

        [Column("연락처", TypeName = "CONTACT"), DataType(DataType.PhoneNumber), Required(AllowEmptyStrings = false, ErrorMessage = "연락처는 필수입니다.")]
        [Display(AutoGenerateFilter = false, GroupName = "<연락처|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]        
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public string Tel;

        [Column("연락처", TypeName = "CONTACT"), DataType(DataType.EmailAddress), Required(AllowEmptyStrings = false, ErrorMessage = "이메일은 필수입니다."), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "<연락처|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = ""), ]
        public string Email;

        [Column("연락처", TypeName = "CONTACT"), DataType(DataType.PostalCode), Required(AllowEmptyStrings = true, ErrorMessage = "우편번호는 필수입니다."), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "<연락처|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = ""),]
        public string 우편번호;

        [Column("연락처", TypeName = "CONTACT"), Required(AllowEmptyStrings = true, ErrorMessage = "주소는 필수입니다."), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "<연락처|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = ""),]
        public string Address;

        [Column("간략설명", TypeName = "DESC1"), DataType(DataType.MultilineText), Required(AllowEmptyStrings = true, ErrorMessage = ""), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "{Tabs}/간략설명", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]        
        [MaxLength(1000), StringLength(500)]
        public string Desc1;

        [Column("간략설명", TypeName = "DESC2"), DataType(DataType.MultilineText), Required(AllowEmptyStrings = true, ErrorMessage = ""), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "{Tabs}/간략설명", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [MaxLength(2000), StringLength(1000)]
        public string Desc2;

        [Column("상세설명", TypeName = "DESC4"), DataType(DataType.MultilineText), Required(AllowEmptyStrings = true, ErrorMessage = ""), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "{Tabs}/상세설명", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [MaxLength(4000), StringLength(2000)]
        public string Desc4;

        [Column("상세설명", TypeName = "TXT"), DataType(DataType.MultilineText), Required(AllowEmptyStrings = true, ErrorMessage = ""), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "{Tabs}/상세설명", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        public string Text;

        [Column("상세설명(Html)", TypeName = "HTML"), DataType(DataType.MultilineText), Required(AllowEmptyStrings = true, ErrorMessage = ""), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "{Tabs}/상세설명", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        public string Html;

        [Column("일정", TypeName = "JSON"), DataType(DataType.MultilineText), Required(AllowEmptyStrings = true, ErrorMessage = ""), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "{Tabs}/일정", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        public string Json;

        [Column("아이디", TypeName = ""), Required(AllowEmptyStrings = false, ErrorMessage = "아이디는 필수입니다"), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "<로그인|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        public string 아이디;

        [Column("비밀번호", TypeName = "PW"), DataType(DataType.Password), Required(AllowEmptyStrings = false, ErrorMessage = "비밀번호는 필수입니다"), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "")]
        [Display(AutoGenerateFilter = false, GroupName = "<로그인|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        public string 비밀번호;
        #endregion

        #region 숫자

        [Column("통화코드", TypeName = "CD"), Required(AllowEmptyStrings = false, ErrorMessage = "코드는 필수선택입니다.")]
        [Display(AutoGenerateFilter = true, GroupName = "<원가|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [EnumDataType(typeof(publicEnum.enum상품_통화코드), ErrorMessage = "")]
        public string 통화코드;

        [Column("단가", TypeName = "COST"), DataType(DataType.Currency), Required(AllowEmptyStrings = false, ErrorMessage = "단가는 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<원가|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "#,#", ApplyFormatInEditMode = false, ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        public int Cost;

        [Column("요율", TypeName = "RATE"), DataType(DataType.Currency), Required(AllowEmptyStrings = false, ErrorMessage = "요울인 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<원가|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "p", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        public long Rate;

        [Column("원가", TypeName = "AMOUNT"), DataType(DataType.Currency), Required(AllowEmptyStrings = false, ErrorMessage = "원가는 필수입니다"), ReadOnly(true), Editable(false)]
        [Display(AutoGenerateFilter = false, GroupName = "<원가|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "#,#", ApplyFormatInEditMode = false, ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        public long Amount;

        [Column("금액", TypeName = "PRICE"), DataType(DataType.Currency), Required(AllowEmptyStrings = false, ErrorMessage = "금액은 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<가격|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "#,#", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        public long Price;

        [Column("수량", TypeName = "QUANTITY"), DataType(DataType.Currency), Required(AllowEmptyStrings = false, ErrorMessage = "수량은 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<가격|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "#", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        public long Quantity;

        [Column("금액", TypeName = "Total"), DataType(DataType.Currency), Required(AllowEmptyStrings = false, ErrorMessage = "금액은 필수입니다"), ReadOnly(true), Editable(false)]
        [Display(AutoGenerateFilter = false, GroupName = "<가격|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "#,#", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        public long Total;

        #endregion

        #region 날짜
        [Column("년월일시", TypeName = "년월일시"), DataType(DataType.DateTime), Required(AllowEmptyStrings = false, ErrorMessage = "날짜는 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<출발일|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "0")]
        [DisplayFormat(DataFormatString = "YYYY/MM/DD HH:MM", ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, NullDisplayText = "")]
        public DateTime 일시;

        [Column("년월일", TypeName = "년월일"), DataType(DataType.Date), Required(AllowEmptyStrings = false, ErrorMessage = "날짜는 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<Name|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [DisplayFormat(DataFormatString = "YYYY/MM/DD")]
        public DateTime 날짜;

        [Column("시간", TypeName = "시간"), DataType(DataType.Time), Required(AllowEmptyStrings = false, ErrorMessage = "시간은 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<Name|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        [DisplayFormat(DataFormatString = "HH:MM")]
        public DateTime 시간;
        #endregion

        #region 링크
        [Column("ImageURL", TypeName = "URL"), DataType(DataType.ImageUrl), Required(AllowEmptyStrings = false, ErrorMessage = "대표이미지는 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<File|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        public string ImageURL;

        [Column("URL", TypeName = "URL"), DataType(DataType.Url), Required(AllowEmptyStrings = false, ErrorMessage = "주소는 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<File|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        public string 사이트주소;

        [Column("PATH", TypeName = "PATH"), DataType(DataType.Upload), Required(AllowEmptyStrings = false, ErrorMessage = "파일은 필수입니다")]
        [Display(AutoGenerateFilter = false, GroupName = "<File|>", Order = 1, Name = "", ShortName = "", Description = "", Prompt = "")]
        public string 파일경로;
        #endregion

        #region 샘플
        [Display(GroupName = "<Name|>", Name = "Last name")]
        public string LastName { get; set; }
        [Display(GroupName = "<Name|>", Name = "First name", Order = 0)]
        public string FirstName { get; set; }
        //The four items below will go to a Contact tab within tabbed Tabs group. 
        [Display(GroupName = "{Tabs}/Contact", Order = 2), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(GroupName = "{Tabs}/Contact", Order = 4), DataType(DataType.EmailAddress)]
        public string E_mail { get; set; }
        //The two items below will go to the Address group within the Contact tab. 
        [Display(GroupName = "{Tabs}/Contact/Address", ShortName = "")]
        public string AddressLine1 { get; set; }
        [Display(GroupName = "{Tabs}/Contact/Address", ShortName = "")]
        public string AddressLine2 { get; set; }
        //The two items below will go to a horizontally oriented Personal group. 
        [Display(GroupName = "Personal-", Name = "Birth date")]
        public DateTime BirthDate { get; set; }
        [Display(GroupName = "Personal-", Order = 3)]
        public GenderEnum Gender { get; set; }
        //The four items below will go to the Job tab of the tabbed Tabs group 
        [Display(GroupName = "{Tabs}/Job", Order = 6)]
        public string Group { get; set; }
        [Display(GroupName = "{Tabs}/Job", Name = "Hire date")]
        public DateTime HireDate { get; set; }
        [Display(GroupName = "{Tabs}/Job"), DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(GroupName = "{Tabs}/Job", Order = 7)]
        public string vTitle { get; set; }
        public enum GenderEnum { Male, Female }

        #endregion
    }


    enum enumType
    {
        Comma = ',',
        Tab = '\t',
        Space = ' '
    }
}
