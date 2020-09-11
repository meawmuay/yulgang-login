# Yulgang Login
โปรแกรมนี้จัดทำขึ้นมาให้ใช้ฟรี เพื่อช่วยเหลือผู้เล่นโดยตัวโปรแกรมจะกรอกข้อมูลการเข้าสู่ระบบเกมให้ และตั้งชื่อหน้าต่างหน้าจอให้โดยอัตโนมัติ


✔️ โปรแกรมใช้งานฟรี\
✔️ สามารถ Copy โปรแกรมไปให้เพื่อนโดยไม่ติดรหัสของคุณไปด้วย\
✔️ ฐานข้อมูลถูกเข้ารหัสด้วยรหัสของคุณเอง\
✔️ ไม่มีการสำรองรหัสฐานข้อมูล และไม่สามารถกู้คืนได้ (หากคุณลืมรหัส)\
✔️ เปิดรหัสโค้ด 100% (Open Source)\
✔️ โปรแกรมไม่มีการใช้งานอินเตอร์เน็ต ไม่มีการเชื่อมต่ออินเตอร์เน็ต (เพื่อใช้แอบส่งข้อมูลรหัส)
<br/>
<br/>
![](https://i.imgur.com/BzPRHmB.png)
## เริ่มต้นใช้งาน

โปรแกรมนี้เขียนด้วยโปรแกรม Visual Studio 2017 และใช้ .NET Framework เวอร์ชั่น 4.6.1 เป็นอย่างต่ำ
### ดาวน์โหลด
[Yulgang Login Version 2.0.0.0](+ "Yulgang Login Latest Version")

### ติดตั้ง
ตัวโปรแกรมไม่มีความจำเป็นต้องติด แต่หากคุณยังไม่ได้ลง .NET Framework เวอร์ชั่น 4.6.1 หรือมากกว่า ดาวน์โหลดได้จากลิงค์ด้านล่าง

[Microsoft .NET Framework 4.6.1 (Web Installer)](https://www.microsoft.com/en-us/download/details.aspx?id=49981 "Microsoft .NET Framework 4.6.1 (Web Installer)")

รองรับระบบปฏิบัติการ
- Windows 7 SP1
- Windows 8
- Windows 8.1
- Windows 10
- Windows Server 2008 R2 SP1
- Windows Server 2012
- Windows Server 2012 R2

### หมายเหตุ
ทำไมถึงขึ้นตามรายการด้านล่างนี้
- Publisher : Unknown ในขณะที่เปิดโปรแกรม [(ตัวอย่าง)](https://i.imgur.com/peSlQDG.png "(ตัวอย่าง)")
- ตอนดาวน์โหลดเสร็จ บราวเซอร์แจ้งว่า "ไฟล์นี้ไม่ได้มีการดาวน์โหลดเป็นที่แพร่หลายและอาจเป็นอันตราย" หรือ "This file is not commonly downloaded and may be dangerous." [(ตัวอย่าง)](https://i.imgur.com/FkxEtZs.png "(ตัวอย่าง)")

เนื่องมาจาก ตัวโปรแกรมไม่ได้ Publish ด้วย Code Signing Certificate (จำเป็นต้องซื้อและยืนยันตัวตน) และตัวโปรแกรมต้องการสิทธิ์ Administrator เพื่อเข้าถึงฟังก์ชั่นตามด้านล่างนี้จาก Library user32.dll
- FindWindow
- SetWindowTextA
- GetForegroundWindow
- GetWindowText

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
