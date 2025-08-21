# Yulgang Login
โปรแกรมนี้จัดทำขึ้นมาให้ใช้ฟรี เพื่อช่วยเหลือผู้เล่นโดยตัวโปรแกรมจะกรอกข้อมูลการเข้าสู่ระบบเกมให้ และตั้งชื่อหน้าต่างหน้าจอให้โดยอัตโนมัติ


✅ โปรแกรมใช้งานฟรี\
✅ ช่วยกรอก Username และ Password ให้โดยไม่ต้องพิมพ์เอง\
✅ เปลี่ยนชื่อหน้าต่างอัตโนมัติ สามารถยกเลิกได้\
✅ มีระบบนำเข้า ส่งออก และล้างฐานข้อมูล\
✅ สามารถ Copy โปรแกรมไปให้เพื่อนโดยไม่ติดรหัสของคุณไปด้วย\
✅ ฐานข้อมูลถูกเข้ารหัสด้วยรหัสของคุณเอง\
✅ ไม่มีการสำรองรหัสฐานข้อมูล และไม่สามารถกู้คืนได้ (หากคุณลืมรหัส)\
✅ เปิดรหัสโค้ด 100% (Open Source)\
✅ โปรแกรมไม่มีการใช้งานอินเตอร์เน็ต ไม่มีการเชื่อมต่ออินเตอร์เน็ต (เพื่อใช้แอบส่งข้อมูลรหัส)
<br/>
<br/>
![](https://i.imgur.com/Q8Z2Zci.png)
## เริ่มต้นใช้งาน

โปรแกรมนี้เขียนด้วยโปรแกรม Visual Studio 2017 และใช้ .NET Framework เวอร์ชั่น 4.6.1 เป็นอย่างต่ำ
### ดาวน์โหลด
[Yulgang Login Version 2.1.1.0](https://github.com/meawmuay/yulgang-login/releases/download/v2.1.1.0/Yulgang.Login.2.1.1.0.rar "Yulgang Login Latest Version")

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

### วิธีใช้งาน
1. เปิดไฟล์ YulgangLogin.exe เพื่อเข้าใช้งาน
2. เมื่อใช้งานครั้งแรก ตัวโปรแกรมจะให้เราตั้งค่ารหัสผ่านสำหรับป้องกันข้อมูลก่อน\
![](https://i.imgur.com/1NS5wyp.png)

3. หลังจากนั้นให้เปิดโปรแกรมอีกครั้ง แล้วกรอกรหัสผ่านที่ตั้งไว้\
![](https://i.imgur.com/cEFaU6P.png)

4. โปรแกรมจะเปิดหน้าต่างสำหรับใช้งาน โดยคุณสามรถเพิ่มข้อมูลสำหรับล็อกอินได้เลย\
![](https://i.imgur.com/Q8Z2Zci.png)

5. คุณสามารถเลือกโหมดเป็นแบบพิมพ์หรือคัดลอกได้\
![](https://i.imgur.com/V2Z1jxe.png)

6. วิธีการใช้งานคือ เปิดตัวเกมขึ้นมา เลือกโหมดของไอดี เช่นไอดี Playpark
7. แล้วมาที่โปรแกรม เลือกรายการด้านขวา แล้วคลิกที่ LOGIN
8. หลังจากไปคลิกที่จอเกมอีกครั้ง ระบบจะกรอกไอดีและรหัสผ่านให้แล้วกด Enter ให้ด้วยหากคุณเปิดใช้ออฟชั่นนี้
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
