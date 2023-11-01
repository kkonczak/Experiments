## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; StringConcatenationBenchmarkTest.StringConcatenationBenchmarkTest.PlusStringConcatenationTest()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.String[]
       mov       edx,0B
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,0D14C4091D8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,0D14C4091E0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,0D14C4091E8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+28]
       mov       rdx,0D14C4091F0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+30]
       mov       rdx,0D14C4091F8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+38]
       mov       rdx,0D14C409200
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+40]
       mov       rdx,0D14C409208
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+48]
       mov       rdx,0D14C409210
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+50]
       mov       rdx,0D14C409218
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+58]
       mov       rdx,0D14C409220
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+60]
       mov       rdx,0D14C409228
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA0AD8F690]; StringConcatenationBenchmarkTest.StringConcatenationBenchmarkTest.PlusStringConcatenation(System.String[])
; Total bytes of code 292
```
```assembly
; StringConcatenationBenchmarkTest.StringConcatenationBenchmarkTest.PlusStringConcatenation(System.String[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rcx,0D14C402028
       mov       rax,[rcx]
       mov       rsi,rdx
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L01
M01_L00:
       mov       ecx,edi
       mov       r8,[rsi+rcx*8+10]
       mov       rcx,rax
       mov       rdx,r8
       mov       r9,r8
       call      qword ptr [7FFA0AB91C90]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 68
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; StringConcatenationBenchmarkTest.StringConcatenationBenchmarkTest.StringBuilderStringConcatenationTest()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.String[]
       mov       edx,0B
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,76D24091D8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,76D24091E0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,76D24091E8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+28]
       mov       rdx,76D24091F0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+30]
       mov       rdx,76D24091F8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+38]
       mov       rdx,76D2409200
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+40]
       mov       rdx,76D2409208
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+48]
       mov       rdx,76D2409210
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+50]
       mov       rdx,76D2409218
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+58]
       mov       rdx,76D2409220
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+60]
       mov       rdx,76D2409228
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA0AD7F6A8]; StringConcatenationBenchmarkTest.StringConcatenationBenchmarkTest.StringBuilderStringConcatenation(System.String[])
; Total bytes of code 292
```
```assembly
; StringConcatenationBenchmarkTest.StringConcatenationBenchmarkTest.StringBuilderStringConcatenation(System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
M01_L00:
       mov       edx,ebx
       mov       r14,[rsi+rdx*8+10]
       test      r14,r14
       je        short M01_L01
       mov       r8d,[r14+8]
       lea       rdx,[r14+0C]
       mov       rcx,rdi
       call      qword ptr [7FFA0AD739C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       test      r14,r14
       je        short M01_L02
       mov       r8d,[r14+8]
       lea       rdx,[r14+0C]
       mov       rcx,rdi
       call      qword ptr [7FFA0AD739C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       test      r14,r14
       je        short M01_L03
       mov       r8d,[r14+8]
       lea       rdx,[r14+0C]
       mov       rcx,rdi
       call      qword ptr [7FFA0AD739C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L04:
       mov       rcx,rdi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFA0AD6C4C8]; System.Text.StringBuilder.ToString()
; Total bytes of code 177
```

