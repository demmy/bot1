using System.Data.Entity.Migrations;

namespace DAL.Migrations
{
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidate",
                c => new
                {
                    Id = c.Int(false, true),
                    FirstName = c.String(false),
                    MiddleName = c.String(false),
                    LastName = c.String(false),
                    IsMale = c.Boolean(false),
                    BirthDate = c.DateTime(false),
                    Email = c.String(false),
                    Skype = c.String(),
                    PositionDesired = c.String(false),
                    SalaryDesired = c.Int(false),
                    TypeOfEmployment = c.Int(false),
                    StartExperience = c.DateTime(false),
                    Practice = c.String(),
                    Description = c.String(),
                    LocationId = c.Int(false),
                    IndustryId = c.Int(),
                    RelocationAgreement = c.Boolean(false),
                    Education = c.String(),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    Photo_Id = c.Int(),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Industry", t => t.IndustryId)
                .ForeignKey("dbo.Location", t => t.LocationId)
                .ForeignKey("dbo.Photo", t => t.Photo_Id)
                .Index(t => t.LocationId)
                .Index(t => t.IndustryId)
                .Index(t => t.Photo_Id);

            CreateTable(
                "dbo.Comment",
                c => new
                {
                    Id = c.Int(false, true),
                    Message = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.File",
                c => new
                {
                    Id = c.Int(false, true),
                    FilePath = c.String(false),
                    Description = c.String(),
                    Size = c.Long(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    Candidate_Id = c.Int(),
                    Vacancy_Id = c.Int(),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidate", t => t.Candidate_Id)
                .ForeignKey("dbo.Vacancy", t => t.Vacancy_Id)
                .Index(t => t.Candidate_Id)
                .Index(t => t.Vacancy_Id);

            CreateTable(
                "dbo.Industry",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.LanguageSkill",
                c => new
                {
                    Id = c.Int(false, true),
                    LanguageLevel = c.Int(false),
                    LanguageId = c.Int(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Language", t => t.LanguageId)
                .Index(t => t.LanguageId);

            CreateTable(
                "dbo.Language",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Location",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    CountryId = c.Int(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Country", t => t.CountryId)
                .Index(t => t.CountryId);

            CreateTable(
                "dbo.Country",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.PhoneNumber",
                c => new
                {
                    Id = c.Int(false, true),
                    Number = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Photo",
                c => new
                {
                    Id = c.Int(false, true),
                    ImagePath = c.String(false),
                    Description = c.String(),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Skill",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.CandidateSocial",
                c => new
                {
                    Id = c.Int(false, true),
                    Path = c.String(false),
                    SocialNetworkId = c.Int(false),
                    CandidateId = c.Int(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidate", t => t.CandidateId)
                .ForeignKey("dbo.SocialNetwork", t => t.SocialNetworkId)
                .Index(t => t.SocialNetworkId)
                .Index(t => t.CandidateId);

            CreateTable(
                "dbo.SocialNetwork",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    ImagePath = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.CandidateSource",
                c => new
                {
                    Id = c.Int(false, true),
                    Source = c.Int(false),
                    Path = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    Candidate_Id = c.Int(),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidate", t => t.Candidate_Id)
                .Index(t => t.Candidate_Id);

            CreateTable(
                "dbo.Tag",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.VacancyStageInfo",
                c => new
                {
                    Id = c.Int(false, true),
                    CandidateId = c.Int(false),
                    VacancyId = c.Int(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    Comment_Id = c.Int(),
                    VacancyStage_Id = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comment", t => t.Comment_Id)
                .ForeignKey("dbo.Vacancy", t => t.VacancyId)
                .ForeignKey("dbo.VacancyStage", t => t.VacancyStage_Id)
                .ForeignKey("dbo.Candidate", t => t.CandidateId)
                .Index(t => t.CandidateId)
                .Index(t => t.VacancyId)
                .Index(t => t.Comment_Id)
                .Index(t => t.VacancyStage_Id);

            CreateTable(
                "dbo.Vacancy",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(),
                    Description = c.String(),
                    SalaryMin = c.Int(false),
                    SalaryMax = c.Int(false),
                    TypeOfEmployment = c.Int(),
                    StartDate = c.DateTime(false),
                    EndDate = c.DateTime(),
                    DeadlineDate = c.DateTime(),
                    ParentVacancyId = c.Int(),
                    IndustryId = c.Int(),
                    DepartmentId = c.Int(false),
                    ResponsibleId = c.Int(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    LanguageSkill_Id = c.Int(),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.DepartmentId)
                .ForeignKey("dbo.Industry", t => t.IndustryId)
                .ForeignKey("dbo.LanguageSkill", t => t.LanguageSkill_Id)
                .ForeignKey("dbo.Vacancy", t => t.ParentVacancyId)
                .ForeignKey("dbo.User", t => t.ResponsibleId)
                .Index(t => t.ParentVacancyId)
                .Index(t => t.IndustryId)
                .Index(t => t.DepartmentId)
                .Index(t => t.ResponsibleId)
                .Index(t => t.LanguageSkill_Id);

            CreateTable(
                "dbo.Department",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    DepartmentGroupId = c.Int(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentGroup", t => t.DepartmentGroupId)
                .Index(t => t.DepartmentGroupId);

            CreateTable(
                "dbo.DepartmentGroup",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Level",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.User",
                c => new
                {
                    Id = c.Int(false, true),
                    FirstName = c.String(false),
                    MiddleName = c.String(false),
                    LastName = c.String(false),
                    isMale = c.Boolean(false),
                    BirthDate = c.DateTime(),
                    Email = c.String(false),
                    Skype = c.String(),
                    Login = c.String(false),
                    Password = c.String(false),
                    RoleId = c.Int(false),
                    LocationId = c.Int(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    Photo_Id = c.Int(),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.LocationId)
                .ForeignKey("dbo.Photo", t => t.Photo_Id)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.RoleId)
                .Index(t => t.LocationId)
                .Index(t => t.Photo_Id);

            CreateTable(
                "dbo.Role",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Permission",
                c => new
                {
                    Id = c.Int(false, true),
                    Description = c.String(false),
                    AccessRights = c.Int(false),
                    Group = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.VacancyStage",
                c => new
                {
                    Id = c.Int(false, true),
                    Order = c.Int(false),
                    IsCommentRequired = c.Boolean(false),
                    StageId = c.Int(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stage", t => t.StageId)
                .Index(t => t.StageId);

            CreateTable(
                "dbo.Stage",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.EventType",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(false),
                    ImagePath = c.String(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Event",
                c => new
                {
                    Id = c.Int(false, true),
                    EventDate = c.DateTime(false),
                    Description = c.String(false),
                    EventTypeId = c.Int(false),
                    ResponsibleId = c.Int(false),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    Candidate_Id = c.Int(),
                    Vacancy_Id = c.Int(),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidate", t => t.Candidate_Id)
                .ForeignKey("dbo.EventType", t => t.EventTypeId)
                .ForeignKey("dbo.User", t => t.ResponsibleId)
                .ForeignKey("dbo.Vacancy", t => t.Vacancy_Id)
                .Index(t => t.EventTypeId)
                .Index(t => t.ResponsibleId)
                .Index(t => t.Candidate_Id)
                .Index(t => t.Vacancy_Id);

            CreateTable(
                "dbo.Error",
                c => new
                {
                    Id = c.Int(false, true),
                    Message = c.String(),
                    StackTrace = c.String(),
                    LastModified = c.DateTime(),
                    CreatedOn = c.DateTime(),
                    State = c.Int(false),
                    IsDeleted = c.Boolean(false)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.CandidateComment",
                c => new
                {
                    Candidate_Id = c.Int(false),
                    Comment_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Candidate_Id, t.Comment_Id})
                .ForeignKey("dbo.Candidate", t => t.Candidate_Id)
                .ForeignKey("dbo.Comment", t => t.Comment_Id)
                .Index(t => t.Candidate_Id)
                .Index(t => t.Comment_Id);

            CreateTable(
                "dbo.CandidateLanguageSkill",
                c => new
                {
                    Candidate_Id = c.Int(false),
                    LanguageSkill_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Candidate_Id, t.LanguageSkill_Id})
                .ForeignKey("dbo.Candidate", t => t.Candidate_Id)
                .ForeignKey("dbo.LanguageSkill", t => t.LanguageSkill_Id)
                .Index(t => t.Candidate_Id)
                .Index(t => t.LanguageSkill_Id);

            CreateTable(
                "dbo.CandidatePhoneNumber",
                c => new
                {
                    Candidate_Id = c.Int(false),
                    PhoneNumber_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Candidate_Id, t.PhoneNumber_Id})
                .ForeignKey("dbo.Candidate", t => t.Candidate_Id)
                .ForeignKey("dbo.PhoneNumber", t => t.PhoneNumber_Id)
                .Index(t => t.Candidate_Id)
                .Index(t => t.PhoneNumber_Id);

            CreateTable(
                "dbo.CandidateSkill",
                c => new
                {
                    Candidate_Id = c.Int(false),
                    Skill_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Candidate_Id, t.Skill_Id})
                .ForeignKey("dbo.Candidate", t => t.Candidate_Id)
                .ForeignKey("dbo.Skill", t => t.Skill_Id)
                .Index(t => t.Candidate_Id)
                .Index(t => t.Skill_Id);

            CreateTable(
                "dbo.CandidateTag",
                c => new
                {
                    Candidate_Id = c.Int(false),
                    Tag_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Candidate_Id, t.Tag_Id})
                .ForeignKey("dbo.Candidate", t => t.Candidate_Id)
                .ForeignKey("dbo.Tag", t => t.Tag_Id)
                .Index(t => t.Candidate_Id)
                .Index(t => t.Tag_Id);

            CreateTable(
                "dbo.VacancyComment",
                c => new
                {
                    Vacancy_Id = c.Int(false),
                    Comment_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Vacancy_Id, t.Comment_Id})
                .ForeignKey("dbo.Vacancy", t => t.Vacancy_Id)
                .ForeignKey("dbo.Comment", t => t.Comment_Id)
                .Index(t => t.Vacancy_Id)
                .Index(t => t.Comment_Id);

            CreateTable(
                "dbo.VacancyLevel",
                c => new
                {
                    Vacancy_Id = c.Int(false),
                    Level_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Vacancy_Id, t.Level_Id})
                .ForeignKey("dbo.Vacancy", t => t.Vacancy_Id)
                .ForeignKey("dbo.Level", t => t.Level_Id)
                .Index(t => t.Vacancy_Id)
                .Index(t => t.Level_Id);

            CreateTable(
                "dbo.VacancyLocation",
                c => new
                {
                    Vacancy_Id = c.Int(false),
                    Location_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Vacancy_Id, t.Location_Id})
                .ForeignKey("dbo.Vacancy", t => t.Vacancy_Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .Index(t => t.Vacancy_Id)
                .Index(t => t.Location_Id);

            CreateTable(
                "dbo.VacancySkill",
                c => new
                {
                    Vacancy_Id = c.Int(false),
                    Skill_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Vacancy_Id, t.Skill_Id})
                .ForeignKey("dbo.Vacancy", t => t.Vacancy_Id)
                .ForeignKey("dbo.Skill", t => t.Skill_Id)
                .Index(t => t.Vacancy_Id)
                .Index(t => t.Skill_Id);

            CreateTable(
                "dbo.UserPhoneNumber",
                c => new
                {
                    User_Id = c.Int(false),
                    PhoneNumber_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.User_Id, t.PhoneNumber_Id})
                .ForeignKey("dbo.User", t => t.User_Id)
                .ForeignKey("dbo.PhoneNumber", t => t.PhoneNumber_Id)
                .Index(t => t.User_Id)
                .Index(t => t.PhoneNumber_Id);

            CreateTable(
                "dbo.PermissionRole",
                c => new
                {
                    Permission_Id = c.Int(false),
                    Role_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Permission_Id, t.Role_Id})
                .ForeignKey("dbo.Permission", t => t.Permission_Id)
                .ForeignKey("dbo.Role", t => t.Role_Id)
                .Index(t => t.Permission_Id)
                .Index(t => t.Role_Id);

            CreateTable(
                "dbo.VacancyTag",
                c => new
                {
                    Vacancy_Id = c.Int(false),
                    Tag_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Vacancy_Id, t.Tag_Id})
                .ForeignKey("dbo.Vacancy", t => t.Vacancy_Id)
                .ForeignKey("dbo.Tag", t => t.Tag_Id)
                .Index(t => t.Vacancy_Id)
                .Index(t => t.Tag_Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Event", "Vacancy_Id", "dbo.Vacancy");
            DropForeignKey("dbo.Event", "ResponsibleId", "dbo.User");
            DropForeignKey("dbo.Event", "EventTypeId", "dbo.EventType");
            DropForeignKey("dbo.Event", "Candidate_Id", "dbo.Candidate");
            DropForeignKey("dbo.VacancyStageInfo", "CandidateId", "dbo.Candidate");
            DropForeignKey("dbo.VacancyStageInfo", "VacancyStage_Id", "dbo.VacancyStage");
            DropForeignKey("dbo.VacancyStage", "StageId", "dbo.Stage");
            DropForeignKey("dbo.VacancyTag", "Tag_Id", "dbo.Tag");
            DropForeignKey("dbo.VacancyTag", "Vacancy_Id", "dbo.Vacancy");
            DropForeignKey("dbo.Vacancy", "ResponsibleId", "dbo.User");
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropForeignKey("dbo.PermissionRole", "Role_Id", "dbo.Role");
            DropForeignKey("dbo.PermissionRole", "Permission_Id", "dbo.Permission");
            DropForeignKey("dbo.User", "Photo_Id", "dbo.Photo");
            DropForeignKey("dbo.UserPhoneNumber", "PhoneNumber_Id", "dbo.PhoneNumber");
            DropForeignKey("dbo.UserPhoneNumber", "User_Id", "dbo.User");
            DropForeignKey("dbo.User", "LocationId", "dbo.Location");
            DropForeignKey("dbo.VacancySkill", "Skill_Id", "dbo.Skill");
            DropForeignKey("dbo.VacancySkill", "Vacancy_Id", "dbo.Vacancy");
            DropForeignKey("dbo.Vacancy", "ParentVacancyId", "dbo.Vacancy");
            DropForeignKey("dbo.VacancyLocation", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.VacancyLocation", "Vacancy_Id", "dbo.Vacancy");
            DropForeignKey("dbo.VacancyLevel", "Level_Id", "dbo.Level");
            DropForeignKey("dbo.VacancyLevel", "Vacancy_Id", "dbo.Vacancy");
            DropForeignKey("dbo.Vacancy", "LanguageSkill_Id", "dbo.LanguageSkill");
            DropForeignKey("dbo.Vacancy", "IndustryId", "dbo.Industry");
            DropForeignKey("dbo.File", "Vacancy_Id", "dbo.Vacancy");
            DropForeignKey("dbo.Vacancy", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.Department", "DepartmentGroupId", "dbo.DepartmentGroup");
            DropForeignKey("dbo.VacancyComment", "Comment_Id", "dbo.Comment");
            DropForeignKey("dbo.VacancyComment", "Vacancy_Id", "dbo.Vacancy");
            DropForeignKey("dbo.VacancyStageInfo", "VacancyId", "dbo.Vacancy");
            DropForeignKey("dbo.VacancyStageInfo", "Comment_Id", "dbo.Comment");
            DropForeignKey("dbo.CandidateTag", "Tag_Id", "dbo.Tag");
            DropForeignKey("dbo.CandidateTag", "Candidate_Id", "dbo.Candidate");
            DropForeignKey("dbo.CandidateSource", "Candidate_Id", "dbo.Candidate");
            DropForeignKey("dbo.CandidateSocial", "SocialNetworkId", "dbo.SocialNetwork");
            DropForeignKey("dbo.CandidateSocial", "CandidateId", "dbo.Candidate");
            DropForeignKey("dbo.CandidateSkill", "Skill_Id", "dbo.Skill");
            DropForeignKey("dbo.CandidateSkill", "Candidate_Id", "dbo.Candidate");
            DropForeignKey("dbo.Candidate", "Photo_Id", "dbo.Photo");
            DropForeignKey("dbo.CandidatePhoneNumber", "PhoneNumber_Id", "dbo.PhoneNumber");
            DropForeignKey("dbo.CandidatePhoneNumber", "Candidate_Id", "dbo.Candidate");
            DropForeignKey("dbo.Candidate", "LocationId", "dbo.Location");
            DropForeignKey("dbo.Location", "CountryId", "dbo.Country");
            DropForeignKey("dbo.CandidateLanguageSkill", "LanguageSkill_Id", "dbo.LanguageSkill");
            DropForeignKey("dbo.CandidateLanguageSkill", "Candidate_Id", "dbo.Candidate");
            DropForeignKey("dbo.LanguageSkill", "LanguageId", "dbo.Language");
            DropForeignKey("dbo.Candidate", "IndustryId", "dbo.Industry");
            DropForeignKey("dbo.File", "Candidate_Id", "dbo.Candidate");
            DropForeignKey("dbo.CandidateComment", "Comment_Id", "dbo.Comment");
            DropForeignKey("dbo.CandidateComment", "Candidate_Id", "dbo.Candidate");
            DropIndex("dbo.VacancyTag", new[] {"Tag_Id"});
            DropIndex("dbo.VacancyTag", new[] {"Vacancy_Id"});
            DropIndex("dbo.PermissionRole", new[] {"Role_Id"});
            DropIndex("dbo.PermissionRole", new[] {"Permission_Id"});
            DropIndex("dbo.UserPhoneNumber", new[] {"PhoneNumber_Id"});
            DropIndex("dbo.UserPhoneNumber", new[] {"User_Id"});
            DropIndex("dbo.VacancySkill", new[] {"Skill_Id"});
            DropIndex("dbo.VacancySkill", new[] {"Vacancy_Id"});
            DropIndex("dbo.VacancyLocation", new[] {"Location_Id"});
            DropIndex("dbo.VacancyLocation", new[] {"Vacancy_Id"});
            DropIndex("dbo.VacancyLevel", new[] {"Level_Id"});
            DropIndex("dbo.VacancyLevel", new[] {"Vacancy_Id"});
            DropIndex("dbo.VacancyComment", new[] {"Comment_Id"});
            DropIndex("dbo.VacancyComment", new[] {"Vacancy_Id"});
            DropIndex("dbo.CandidateTag", new[] {"Tag_Id"});
            DropIndex("dbo.CandidateTag", new[] {"Candidate_Id"});
            DropIndex("dbo.CandidateSkill", new[] {"Skill_Id"});
            DropIndex("dbo.CandidateSkill", new[] {"Candidate_Id"});
            DropIndex("dbo.CandidatePhoneNumber", new[] {"PhoneNumber_Id"});
            DropIndex("dbo.CandidatePhoneNumber", new[] {"Candidate_Id"});
            DropIndex("dbo.CandidateLanguageSkill", new[] {"LanguageSkill_Id"});
            DropIndex("dbo.CandidateLanguageSkill", new[] {"Candidate_Id"});
            DropIndex("dbo.CandidateComment", new[] {"Comment_Id"});
            DropIndex("dbo.CandidateComment", new[] {"Candidate_Id"});
            DropIndex("dbo.Event", new[] {"Vacancy_Id"});
            DropIndex("dbo.Event", new[] {"Candidate_Id"});
            DropIndex("dbo.Event", new[] {"ResponsibleId"});
            DropIndex("dbo.Event", new[] {"EventTypeId"});
            DropIndex("dbo.VacancyStage", new[] {"StageId"});
            DropIndex("dbo.User", new[] {"Photo_Id"});
            DropIndex("dbo.User", new[] {"LocationId"});
            DropIndex("dbo.User", new[] {"RoleId"});
            DropIndex("dbo.Department", new[] {"DepartmentGroupId"});
            DropIndex("dbo.Vacancy", new[] {"LanguageSkill_Id"});
            DropIndex("dbo.Vacancy", new[] {"ResponsibleId"});
            DropIndex("dbo.Vacancy", new[] {"DepartmentId"});
            DropIndex("dbo.Vacancy", new[] {"IndustryId"});
            DropIndex("dbo.Vacancy", new[] {"ParentVacancyId"});
            DropIndex("dbo.VacancyStageInfo", new[] {"VacancyStage_Id"});
            DropIndex("dbo.VacancyStageInfo", new[] {"Comment_Id"});
            DropIndex("dbo.VacancyStageInfo", new[] {"VacancyId"});
            DropIndex("dbo.VacancyStageInfo", new[] {"CandidateId"});
            DropIndex("dbo.CandidateSource", new[] {"Candidate_Id"});
            DropIndex("dbo.CandidateSocial", new[] {"CandidateId"});
            DropIndex("dbo.CandidateSocial", new[] {"SocialNetworkId"});
            DropIndex("dbo.Location", new[] {"CountryId"});
            DropIndex("dbo.LanguageSkill", new[] {"LanguageId"});
            DropIndex("dbo.File", new[] {"Vacancy_Id"});
            DropIndex("dbo.File", new[] {"Candidate_Id"});
            DropIndex("dbo.Candidate", new[] {"Photo_Id"});
            DropIndex("dbo.Candidate", new[] {"IndustryId"});
            DropIndex("dbo.Candidate", new[] {"LocationId"});
            DropTable("dbo.VacancyTag");
            DropTable("dbo.PermissionRole");
            DropTable("dbo.UserPhoneNumber");
            DropTable("dbo.VacancySkill");
            DropTable("dbo.VacancyLocation");
            DropTable("dbo.VacancyLevel");
            DropTable("dbo.VacancyComment");
            DropTable("dbo.CandidateTag");
            DropTable("dbo.CandidateSkill");
            DropTable("dbo.CandidatePhoneNumber");
            DropTable("dbo.CandidateLanguageSkill");
            DropTable("dbo.CandidateComment");
            DropTable("dbo.Error");
            DropTable("dbo.Event");
            DropTable("dbo.EventType");
            DropTable("dbo.Stage");
            DropTable("dbo.VacancyStage");
            DropTable("dbo.Permission");
            DropTable("dbo.Role");
            DropTable("dbo.User");
            DropTable("dbo.Level");
            DropTable("dbo.DepartmentGroup");
            DropTable("dbo.Department");
            DropTable("dbo.Vacancy");
            DropTable("dbo.VacancyStageInfo");
            DropTable("dbo.Tag");
            DropTable("dbo.CandidateSource");
            DropTable("dbo.SocialNetwork");
            DropTable("dbo.CandidateSocial");
            DropTable("dbo.Skill");
            DropTable("dbo.Photo");
            DropTable("dbo.PhoneNumber");
            DropTable("dbo.Country");
            DropTable("dbo.Location");
            DropTable("dbo.Language");
            DropTable("dbo.LanguageSkill");
            DropTable("dbo.Industry");
            DropTable("dbo.File");
            DropTable("dbo.Comment");
            DropTable("dbo.Candidate");
        }
    }
}