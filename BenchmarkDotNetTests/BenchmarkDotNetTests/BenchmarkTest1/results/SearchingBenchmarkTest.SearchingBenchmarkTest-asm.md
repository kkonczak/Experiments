## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForEachIndexOf()
       mov       rcx,0D879006728
       mov       rcx,[rcx]
       mov       edx,0EF3D0A1
       jmp       qword ptr [7FFA0A659588]; IndexOfLibrary.IndexOfLibrary.ForEachIndexOf(System.Collections.Generic.IEnumerable`1<Int32>, Int32)
; Total bytes of code 24
```
```assembly
; IndexOfLibrary.IndexOfLibrary.ForEachIndexOf(System.Collections.Generic.IEnumerable`1<Int32>, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],eax
       mov       [rbp-30],rsp
       mov       esi,edx
       xor       edi,edi
       mov       r11,7FFA0A0604A0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-20],rcx
       mov       r11,7FFA0A0604A8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp-20]
       mov       r11,7FFA0A0604B0
       call      qword ptr [r11]
       cmp       eax,esi
       je        short M01_L01
       inc       edi
       mov       rcx,[rbp-20]
       mov       r11,7FFA0A0604A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L00
       jmp       short M01_L02
M01_L01:
       mov       [rbp-14],edi
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp-20]
       mov       r11,7FFA0A0604B8
       call      qword ptr [r11]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsp
       call      M01_L05
       nop
       mov       eax,[rbp-14]
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L04:
       mov       eax,0FFFFFFFF
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,[rbp-20]
       test      rcx,rcx
       je        short M01_L06
       mov       r11,7FFA0A0604B8
       call      qword ptr [r11]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 216
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForIndexOfWithMemory()
       mov       rcx,0B700006728
       mov       rcx,[rcx]
       mov       edx,0EF3D0A1
       jmp       qword ptr [7FFA0A649600]; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithMemory(Int32[], Int32)
; Total bytes of code 24
```
```assembly
; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithMemory(Int32[], Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       esi,edx
       test      rcx,rcx
       jne       short M01_L00
       xor       edi,edi
       xor       ebx,ebx
       jmp       short M01_L01
M01_L00:
       mov       rdi,rcx
       mov       ebx,[rdi+8]
M01_L01:
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M01_L06
M01_L02:
       xor       r14d,r14d
       xor       r15d,r15d
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M01_L03
       lea       r14,[rcx+10]
       mov       r15d,[rcx+8]
       jmp       short M01_L04
M01_L03:
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14,[rsp+28]
       mov       r15d,[rsp+30]
M01_L04:
       mov       eax,ebx
       mov       edx,eax
       mov       ecx,r15d
       cmp       rdx,rcx
       ja        short M01_L08
       mov       r15d,eax
M01_L05:
       mov       rax,r14
       cmp       ebp,r15d
       jae       short M01_L09
       mov       edx,ebp
       cmp       [rax+rdx*4],esi
       je        short M01_L07
       inc       ebp
       cmp       ebp,ebx
       jl        short M01_L02
M01_L06:
       mov       eax,0FFFFFFFF
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       mov       eax,ebp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FFA0A43F498]
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 191
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForIndexOfWithCompare()
       mov       rcx,180406728
       mov       rcx,[rcx]
       mov       edx,0EF3D0A1
       jmp       qword ptr [7FFA0A6495B8]; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithCompare(Int32[], Int32)
; Total bytes of code 24
```
```assembly
; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithCompare(Int32[], Int32)
       xor       eax,eax
       mov       r8d,[rcx+8]
       test      r8d,r8d
       jle       short M01_L02
       nop       dword ptr [rax+rax]
M01_L00:
       mov       r9d,eax
       lea       r9,[rcx+r9*4+10]
       cmp       [r9],edx
       jl        short M01_L01
       cmp       [r9],edx
       jle       short M01_L03
M01_L01:
       inc       eax
       cmp       r8d,eax
       jg        short M01_L00
M01_L02:
       mov       eax,0FFFFFFFF
       ret
M01_L03:
       ret
; Total bytes of code 48
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForIndexOf()
       mov       rax,0B523006728
       mov       rax,[rax]
       xor       edx,edx
       mov       ecx,[rax+8]
       test      ecx,ecx
       jle       short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       mov       r8d,edx
       cmp       dword ptr [rax+r8*4+10],0EF3D0A1
       je        short M00_L02
       inc       edx
       cmp       ecx,edx
       jg        short M00_L00
M00_L01:
       mov       eax,0FFFFFFFF
       jmp       short M00_L03
M00_L02:
       mov       eax,edx
M00_L03:
       ret
; Total bytes of code 62
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForIndexOfWithSpanAndOneLengthCalling()
       mov       rcx,0B2B6006728
       mov       rcx,[rcx]
       mov       edx,0EF3D0A1
       jmp       qword ptr [7FFA0A6595E8]; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithSpanAndOneLengthCalling(Int32[], Int32)
; Total bytes of code 24
```
```assembly
; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithSpanAndOneLengthCalling(Int32[], Int32)
       test      rcx,rcx
       je        short M01_L04
       lea       r8,[rcx+10]
       mov       ecx,[rcx+8]
M01_L00:
       xor       eax,eax
       test      ecx,ecx
       jle       short M01_L02
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L01:
       mov       r9d,eax
       cmp       [r8+r9*4],edx
       je        short M01_L03
       inc       eax
       cmp       eax,ecx
       jl        short M01_L01
M01_L02:
       mov       eax,0FFFFFFFF
       ret
M01_L03:
       ret
M01_L04:
       xor       r8d,r8d
       xor       ecx,ecx
       jmp       short M01_L00
; Total bytes of code 61
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForIndexOfWithPointerAndDecrement()
       mov       rcx,0C562C06728
       mov       rcx,[rcx]
       mov       edx,0EF3D0A1
       jmp       qword ptr [7FFA0A649630]; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithPointerAndDecrement(Int32[], Int32)
; Total bytes of code 24
```
```assembly
; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithPointerAndDecrement(Int32[], Int32)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rax,[rsp+20]
       cmp       dword ptr [rax+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L02
       nop
M01_L01:
       mov       rax,[rsp+20]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L06
       mov       rax,[rsp+20]
       add       rax,10
M01_L02:
       mov       ecx,[rcx+8]
       dec       ecx
       js        short M01_L04
M01_L03:
       movsxd    r8,ecx
       cmp       [rax+r8*4],edx
       je        short M01_L05
       dec       ecx
       jns       short M01_L03
M01_L04:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       eax,0FFFFFFFF
       add       rsp,28
       ret
M01_L05:
       mov       eax,ecx
       add       rsp,28
       ret
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 107
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForIndexOfWithSpan()
       mov       rcx,0A731806728
       mov       rcx,[rcx]
       mov       edx,0EF3D0A1
       jmp       qword ptr [7FFA0A6495D0]; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithSpan(Int32[], Int32)
; Total bytes of code 24
```
```assembly
; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithSpan(Int32[], Int32)
       test      rcx,rcx
       je        short M01_L04
       lea       r8,[rcx+10]
       mov       ecx,[rcx+8]
M01_L00:
       xor       eax,eax
       test      ecx,ecx
       jle       short M01_L02
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L01:
       mov       r9d,eax
       cmp       [r8+r9*4],edx
       je        short M01_L03
       inc       eax
       cmp       eax,ecx
       jl        short M01_L01
M01_L02:
       mov       eax,0FFFFFFFF
       ret
M01_L03:
       ret
M01_L04:
       xor       r8d,r8d
       xor       ecx,ecx
       jmp       short M01_L00
; Total bytes of code 61
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForIndexOfWithPointerAndBinaryOperator()
       mov       rcx,10A1406728
       mov       rcx,[rcx]
       mov       edx,0EF3D0A1
       jmp       qword ptr [7FFA0A649648]; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithPointerAndBinaryOperator(Int32[], Int32)
; Total bytes of code 24
```
```assembly
; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithPointerAndBinaryOperator(Int32[], Int32)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rax,[rsp+20]
       cmp       dword ptr [rax+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L02
       nop       dword ptr [rax]
M01_L01:
       mov       rax,[rsp+20]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L05
       mov       rax,[rsp+20]
       add       rax,10
M01_L02:
       mov       ecx,[rcx+8]
       dec       ecx
M01_L03:
       movsxd    r8,ecx
       cmp       [rax+r8*4],edx
       je        short M01_L04
       dec       ecx
       jmp       short M01_L03
M01_L04:
       mov       eax,ecx
       add       rsp,28
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 90
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForIndexOfWithPointer()
       mov       rcx,8608006728
       mov       rcx,[rcx]
       mov       edx,0EF3D0A1
       jmp       qword ptr [7FFA0A629618]; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithPointer(Int32[], Int32)
; Total bytes of code 24
```
```assembly
; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithPointer(Int32[], Int32)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rax,[rsp+20]
       cmp       dword ptr [rax+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       jmp       short M01_L02
M01_L01:
       mov       rax,[rsp+20]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L06
       mov       rax,[rsp+20]
       add       rax,10
M01_L02:
       mov       ecx,[rcx+8]
       xor       r8d,r8d
       test      ecx,ecx
       jle       short M01_L04
M01_L03:
       movsxd    r9,r8d
       cmp       [rax+r9*4],edx
       je        short M01_L05
       inc       r8d
       cmp       r8d,ecx
       jl        short M01_L03
M01_L04:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       eax,0FFFFFFFF
       add       rsp,28
       ret
M01_L05:
       mov       eax,r8d
       add       rsp,28
       ret
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 114
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; SearchingBenchmarkTest.SearchingBenchmarkTest.TestForIndexOfWithSseAndOneLengthCalling()
       mov       rcx,0E1BA006728
       mov       rcx,[rcx]
       mov       edx,0EF3D0A1
       jmp       qword ptr [7FFA0A649660]; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithSseAndOneLengthCalling(Int32[], Int32)
; Total bytes of code 24
```
```assembly
; IndexOfLibrary.IndexOfLibrary.ForIndexOfWithSseAndOneLengthCalling(Int32[], Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       test      rcx,rcx
       jne       short M01_L00
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L01
       nop       dword ptr [rax]
M01_L00:
       lea       r8,[rcx+10]
       mov       r9d,[rcx+8]
M01_L01:
       mov       eax,[rcx+8]
       mov       r10d,eax
       mov       r11d,r10d
       sar       r11d,1F
       and       r11d,3
       add       r11d,r10d
       sar       r11d,2
       shl       r11d,2
       vmovd     xmm0,edx
       vpinsrd   xmm0,xmm0,edx,1
       vpinsrd   xmm0,xmm0,edx,2
       vpinsrd   xmm0,xmm0,edx,3
       xor       esi,esi
       test      r11d,r11d
       jle       short M01_L03
       mov       r9d,r9d
M01_L02:
       mov       edi,esi
       lea       rbx,[rdi+4]
       cmp       rbx,r9
       ja        near ptr M01_L12
       lea       rdi,[r8+rdi*4]
       vpcmpeqd  xmm1,xmm0,[rdi]
       vptest    xmm1,xmm1
       jne       short M01_L07
       add       esi,4
       cmp       esi,r11d
       jl        short M01_L02
M01_L03:
       cmp       esi,r10d
       jge       short M01_L05
       nop       dword ptr [rax]
M01_L04:
       cmp       esi,eax
       jae       short M01_L13
       mov       r9d,esi
       cmp       [rcx+r9*4+10],edx
       je        short M01_L06
       inc       esi
       cmp       esi,r10d
       jl        short M01_L04
M01_L05:
       mov       eax,0FFFFFFFF
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       eax,esi
       jmp       short M01_L11
M01_L07:
       vpextrd   eax,xmm1,3
       cmp       eax,0FFFFFFFF
       jne       short M01_L08
       lea       eax,[rsi+3]
       jmp       short M01_L11
M01_L08:
       vpextrd   eax,xmm1,2
       cmp       eax,0FFFFFFFF
       jne       short M01_L09
       lea       eax,[rsi+2]
       jmp       short M01_L11
M01_L09:
       vpextrd   eax,xmm1,1
       cmp       eax,0FFFFFFFF
       jne       short M01_L10
       lea       eax,[rsi+1]
       jmp       short M01_L11
M01_L10:
       mov       eax,esi
M01_L11:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L12:
       call      qword ptr [7FFA0A43F498]
       int       3
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 253
```

