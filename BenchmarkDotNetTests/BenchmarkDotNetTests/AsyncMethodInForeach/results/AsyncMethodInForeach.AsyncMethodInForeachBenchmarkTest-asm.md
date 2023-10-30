## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; AsyncMethodInForeach.AsyncMethodInForeachBenchmarkTest.ForeachSumAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFA13879120]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[AsyncMethodInForeach.AsyncMethodInForeachBenchmarkTest+<ForeachSumAsync>d__1, AsyncMethodInForeach]](<ForeachSumAsync>d__1 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFA13877ED0]
       jmp       short M00_L00
; Total bytes of code 86
```
```assembly
; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.Int32, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       eax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFA1387B1F8]
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[AsyncMethodInForeach.AsyncMethodInForeachBenchmarkTest+<ForeachSumAsync>d__1, AsyncMethodInForeach]](<ForeachSumAsync>d__1 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFA13394C08
       mov       edx,2D1
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFA13879018]; AsyncMethodInForeach.AsyncMethodInForeachBenchmarkTest+<ForeachSumAsync>d__1.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFA13879318]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFA134C7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFA13879318]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```

## .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX
```assembly
; AsyncMethodInForeach.AsyncMethodInForeachBenchmarkTest.ForeachSum()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       xor       esi,esi
       mov       rcx,offset MT_System.Linq.Enumerable+RangeIterator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+8],eax
       xor       ecx,ecx
       mov       [rdi+14],ecx
       mov       dword ptr [rdi+18],2710
       mov       rcx,rdi
       mov       r11,7FFA132A0498
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rcx,rdi
       mov       r11,7FFA132A04A0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,rdi
       mov       r11,7FFA132A04A8
       call      qword ptr [r11]
       add       esi,eax
       lea       ecx,[rax+rax*4]
       add       ecx,ecx
       lea       ecx,[rcx+rcx*4]
       lea       esi,[rsi+rcx*2]
       mov       rcx,rdi
       mov       r11,7FFA132A04A0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,rdi
       mov       r11,7FFA132A04B0
       call      qword ptr [r11]
       mov       eax,esi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp-18],0
       je        short M00_L02
       mov       rcx,[rbp-18]
       mov       r11,7FFA132A04B0
       call      qword ptr [r11]
M00_L02:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 227
```

