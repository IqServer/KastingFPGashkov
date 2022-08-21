namespace controllers;
using Microsoft.AspNetCore.Mvc;
using Services;

class MemberController : ControllerBase
{
    MemberService _memberService;
    public MemberController(MemberService memberService)
    {
        _memberService = memberService;
    }

    
}