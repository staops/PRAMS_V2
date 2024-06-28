namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmMenuRoleUpdateDto
    {
        public int MenuRoleId { get; set; }
        public int MenuElementId { get; set; }
        public required string RoleId { get; set; }
    }
}
