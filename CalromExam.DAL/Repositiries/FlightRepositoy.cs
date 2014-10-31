using CalromExam.BL;
using System.Collections.Generic;

namespace CalromExam.DAL.Repositiries
{
    public class MembershipRepository 
    {
        public List<MembershipEntity> MembershipEntities
        {
            get
            {
                List<MembershipEntity> membershipEnties = new List<MembershipEntity>();
                CalromExamEntities calromExamEntities = new CalromExamEntities();
                AutoMapper.Mapper.CreateMap<MembershipData, MembershipEntity>();

                foreach (MembershipData oneMembershipData in calromExamEntities.MembershipData)
                {
                    membershipEnties.Add(AutoMapper.Mapper.Map<MembershipEntity>(oneMembershipData));
                }

                return membershipEnties;
            }
        }
    }
}
