# CS_ARCH_PPC, CS_MODE_BIG_ENDIAN, CS_OPT_SYNTAX_NOREGNAME
0x7c,0x22,0x1a,0x14 = add 1, 2, 3
0x7c,0x22,0x1a,0x14 = add 1, 2, 3
0x7c,0x00,0x02,0x14 = add 0, 0, 0
0x7f,0xff,0xfa,0x14 = add 31, 31, 31
0x38,0x20,0x00,0x00 = li 1, 0
0x38,0x22,0x00,0x00 = addi 1, 2, 0
0x38,0x20,0x80,0x00 = li 1, 0x8000
0x38,0x20,0x7f,0xff = li 1, 0x7fff
0x60,0x41,0x00,0x00 = ori 1, 2, 0
0x60,0x41,0xff,0xff = ori 1, 2, 65535
0x3c,0x20,0x00,0x00 = lis 1, 0
0x3c,0x20,0xff,0xff = lis 1, 0xffff
0x80,0x20,0x00,0x00 = lwz 1, 0(0)
0x80,0x20,0x00,0x00 = lwz 1, 0(0)
0x80,0x3f,0x00,0x00 = lwz 1, 0(31)
0x80,0x3f,0x00,0x00 = lwz 1, 0(31)
0x80,0x22,0x80,0x00 = lwz 1, -32768(2)
0x80,0x22,0x7f,0xff = lwz 1, 32767(2)
0xe8,0x20,0x00,0x00 = ld 1, 0(0)
0xe8,0x20,0x00,0x00 = ld 1, 0(0)
0xe8,0x3f,0x00,0x00 = ld 1, 0(31)
0xe8,0x3f,0x00,0x00 = ld 1, 0(31)
0xe8,0x22,0x80,0x00 = ld 1, -32768(2)
0xe8,0x22,0x7f,0xfc = ld 1, 32764(2)
0xe8,0x22,0x00,0x04 = ld 1, 4(2)
0xe8,0x22,0xff,0xfc = ld 1, -4(2)
0x48,0x00,0x04,0x00 = b .+1024
0x48,0x00,0x04,0x02 = ba 1024
0x41,0x82,0x04,0x00 = beq 0, .+1024
0x41,0x82,0x04,0x02 = beqa 0, 1024
