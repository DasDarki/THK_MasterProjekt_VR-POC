Das Projekt besteht zu Großteilen aus dem Unity 2022 VR Sample Projekt. Mit diesem Projekt sollten folgende "Probleme" unter die Lupe genommen werden:
1. Bewegungsmechanik (Teleport mit Cooldown)
2.Powerups
  4.1. Teleport
  4.2. Kompass
  4.3. Einschränkung Sichtfeld
3. Szenenwechsel (Fade-In/Out)

**1. Bewegungsmechanik (Teleport mit Cooldown)**
Die Bewebungsmechanik ist bereits im Sample Projekt implementiert und bedarf lediglich einigen Gameplay-technischen Anpassungen (Cooldown).

**2. Powerups**
Teleport ist durch Punkt 1 bereits implementiert, nur soll hier kein Cooldown eingebaut werden.
Kompass ist durch ein einfacher Zylinder der getrackt wird und durch ein einfaches UI (blaue Balken am Bildschirmrand) sichtbar gemacht.
Einschränkung Sichtfeld ist bereits durch sogenannte Tunneling Vignette im Sample Projekt umgesetzt (wenn man durch Joysticks sich umdreht).

**3. Szenenwechsel (Fade-In/Out)**
Ein einfacher "Szenenwechsel" ist durch Druck auf "Fade Check"-Button im 3D Raum verortetem UI eingebaut. Wobei hier lediglich Fade-In/Out gezeigt wird, da zurzeit nicht mehrere Szenen existieren im Projekt und dies auch nur eine Zeile-Code darstellen würde.
