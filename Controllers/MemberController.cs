namespace controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using testnet;

[ApiController]
[Route("/api/[controller]/[action]")]
public class MemberController : ControllerBase
{
    MemberService _memberService;
    public MemberController(MemberService memberService)
    {
        _memberService = memberService;
    }

    [HttpGet]
    public void GenerateMember()
    {
        
        _memberService.GenerateMember();
    }
    [HttpGet("GetAllMembers")]
    public List<Models.Member> GetAllMembers()
    {
        return _memberService.GetMembers();
    }
    [HttpGet("GetMembersById")]
    public Member GetMemberById(int id)
    {
        return _memberService.GetMemberById(id);
    }

    [HttpPost("AddMember")]
    public void AddMember(Member newMember)
    {

        _memberService.Add(newMember);
    
        
    }
    
    [HttpDelete("DeleteMember")]
    public void DeleteMember(int id)
    {   
        _memberService.Delete(id);
    }

    [HttpPost("UpdateMember")]
    public void UpdateMember(Member member)
    {

        _memberService.Update(member);
    
        
    }
}