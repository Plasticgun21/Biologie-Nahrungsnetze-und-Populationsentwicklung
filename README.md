# Biologie Nahrungsnetz

 Team DxD              
 Luca Jeanneret Winsky, Niclas Erismann, Elias Spycher

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | Wir haben unseres Thema ausgewählt und ich Luca hat Herr Siegrist für Anforderungen gefragt.|
|       | 0.1.1   | Die Datenbank kann nun eingelesen werden und es wird alles mehr oder weniger ausgegeben.|
|       | 0.1.2   | Man kann nun über das neu erstellte Menu auf die 3 verschiedenen Programme zugreifen, man kann jetzt auch nicht vorhandene Tiere hinzufügen.|
|       | 0.1.    |                                                              |
|       | 0.1.    |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren


### 1.1 Ihr Projekt

Wir müssen drei Programme programieren eine Datenbank mit Informationen mit Nahrungsnetz von Lebewesen, ein Quiz zum Nahrungsnetzes und eine Simulation von Populationsverlauf von Räuber und Beute.

## 1.2 User Stories

### 1.2.1 User Stories für 1. Projekt (Nahrungsnetz)

| US-№ | Verbindlichkeit | Typ  |Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      muss       | Funktion | Ich möchte, dass eine Datenbank eingelesen wird, damit die Informationen vorhanden sind. |
| 2    |      muss       | Funktion | Ich möchte, dass man ein Lebewesen, über das man etwas erfahren will wählen kann, dass man das Programm benutzen kann.  | 
| 3    |      muss       | Funktion | Ich möchte, dass der Name des Lebwesens angezeigt wird und darunter Familie, Nahrung, Feinde etc. angezeigt werden.|
| 4    |      muss       | Funktion | Ich möchte, dass bei einem nicht vorhandenen Tier gefragt wird ob man es hinzufügen möchte, dass der Nutzer unvollständigkeit beheben kann.|
| 5    |      kann       | Funktion | Ich möchte, dass Falscheingaben mit try, catch behandelt werden, dass das Programm nicht abstürzt.|
| 6    |      kann       | Funktion | Ich möchte, dass bei Eingaben die nicht genau dem Tier entsprechen vorgeschlagen wird, was man sonnst suchen könnte.|
| 7    |      kann       | Funktion | Ich möchte, dass der Benutzer alle Tiere geordnet ausgeben kann, damit er einen Überblick hat.|
| 8    |      kann       | Funktion | Ich möchte, dass man die Sortierung anpassen kann nach verschiedenen Kriterien, dass der Nutzer Tiere besser findet.|
| 9    |      kann       | Funktion | Ich möchte anzeigen lassen welche Tiere die letzten Male gesucht worden, damit man Sachen wiederfindet.|
| 10   |      kann       | Funktion | Ich möchte, dass man Informationen, welche falsch erscheinen melden kann, damit man Falschinfos vermeiden kann.|
| 11   |      muss       | Funktion | Ich möchte, dass der Spieler über ein Menu die verschiedenen Programme starten kann, damit es für ihn einfacher ist.|



### 1.2.2 User Stories für 2. Projekt

| US-№ | Verbindlichkeit | Typ  |Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      muss       | Funktion | Ich möchte, dass der Nutzer das Programm mit Tastendruck starten kann, damit er spielen kann|
| 2    |      muss       | Funktion | Ich möchte, dass eine zufällige Frage aus der Datenbank ausgegeben wird, dass er eine Frage bekommt.|
| 3    |      muss       | Funktion | Ich möchte, dass der Nutzer zwischen richtig und falsch auswählen kann, dass er antworten kann.|
| 4    |      muss       | Funktion | Ich möchte, dass die Anwort mit der Lösung verglichen wird und ausgegeben wird ob es die richtige Antwort ist, damit der Nutzer weiss ob er richtig war.|
| 5    |      muss       | Funktion | Ich möchte, dass gefragt wird ob der Nutzer die nächste Frage beantworten will, damit er weiterspielen kann.|
| 6    |      kann       | Funktion | Ich möchte, dass dem Benutzer am schluss vom Quiz gratuliert wird und für eine weitere Runde gefragt wird.|
| 7    |      kann       | Funktion | Ich möchte, dass der Benutzer die Möglichkeit gegeben wird den Schwierigkeitsgrad im Menu einzustellen, dass es schwerer wird.|
| 8    |      kann       | Funktion | Ich möchte, dass der einfachere Modus einfachere Fragen erstellt, dass es fair ist.|
| 9    |      kann       | Funktion | Ich möchte, dass der schwere Modus kompliziertere Fragen stellt, dass man herausgefordert wird.|



### 1.2.3 User Stories für 3. Projekt

| US-№ | Verbindlichkeit | Typ  |Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      muss       | Funktion | Ich möchte, dass der Nutzer Zahlen zu für den Momentanen Bestand der Beute eingeben kann um, damit zu rechnen|
| 2    |      muss       | Funktion | Ich möchte als Nutzer, dass die Beute und die Räuber andere Farben haben , damit ich sie unterscheiden kann. |
| 3    |      muss       | Funktion | Ich möchte, als Nutzer, dass die x/y Zahlen beim Diagramm angezeigt werden, damit ich das ich es Visuel sehen kann.|
| 4    |      muss       | Funktion | Ich möchte, als Nutzer, mehrere Jahren haben, damit ich es länger sehen kann.|
| 5    |      muss       | Funktion | Ich möchte, als Nutzer, mit einem knopf von neu anfangen, damit ich neue angaben reintun kann.|
| 6    |      kann       | Rand | Ich möchte, als Nutzer, Lebewesen aus dem ersten Programm direckt nehmen, damit es cool ist.|     


### 1.3 Testfälle

### 1.3.1 Testfälle für 1. Projekt

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm läuft und ein Lebewesen wird vom Nutzer eingegeben. | "Eingabe vom Tier" | Zeigt das Nahrungsnetz des Lebewesens. |
| 1.2  | Das Programm läuft und ein Lebewesen wurde ausgewählt. | Enter | Zeigt Informationen des Lebewesens. |
| 1.3  | Das Programm läuft und das Programm fragt ob man noch ein anderes Lebewesen sehen will. | y | "Geben sie ein Lebewesen ein." |
| 1.4  | Das Programm läuft und ein falsches Lebewesen wurde eingegeben. | Enter | "Dieses Lebewesen ist nicht auf der Datenbank wollten sie dieses Tier auswählen." |



### 1.3.2 Testfälle für 2. Projekt

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 2.1  | Das Programm läuft und eine Frage wird angezeigt. | y | Die Antwort war falsch. |
| 2.2  | Das Programm läuft und fragt ob man noch eine Frage will. | y | "Hier ist ihre nächste Frage." |
| 2.3  | Das Programm läuft und eine Frage wird angezeigt. | y | Die Antwort war richtig. |
| 2.4  | Das Programm läuft und fragt ob man noch eine Frage will. | n | "Ihre Antworten werden jetzt zusammen gerechnet." |
| 2.5  | Das Programm läuft und die Antworten werden zusammen gerechnet. | Enter | "Sie haben 50% korekt." |
| 2.6  | Das Programm läuft und fragt ob man noch einmal will spielen. | n | "Danke fürs mitspielen :)


### 1.3.3 Testfälle für 3. Projekt

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 3.1  | Das Programm läuft und fragt um die Werte einzugeben. | 10/4 | Zeigt erstes Jahr. |
| 3.2  | Das Programm läuft und erstes Jahr ist angezeigt. | Enter | Zeigt zweites Jahr. |
| 3.3  | Das Programm läuft, das zweites Jahr wird angezeigt und fragt ob man ein drittes Jahr will. | y | Zeigt drittes Jahr. |
| 3.4  | Das Programm läuft, das dritte Jahr wird angezeigt und fragt ob man ein viertes Jahr will. | n | Geht zurück zum Menü. |
| 3.5  | Das Programm läuft und es fragt ob man neue Werte hinzufügen will. | n | Programm schliesst. |


### 1.4 Diagramme



# 2 Planen

### 2.1 Planen vom Nahrungsnetz

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |20.10.22| Niclas     | Die Datenbank einlesen.  | 240 min. |
| 2.B  |27.10.22| Niclas     | Eingabe von einem Tier. | 60 min. |
| 3.C  |27.10.22| Niclas     | Ausgabe vom Nahrungsnetz des gesuchten Tieres.   | 120 min. |
| 4.D  |03.11.22| Niclas     | Frage ob ein nicht gefundenes Tier eingetragen werden soll.   | 240 min. |
| 11.K |03.11.22| Elias      | Menu erstellen, wo man auswählen kann welches Programm gestartet wird. | 240 min. |
| 5.E  |10.11.22| Niclas     | Mit try und catch, Fehlereingaben abfangen | 60 min. |
| 6.F  |10.11.22| Niclas     | Es wird gespeichert, nach welchem Tier gesucht wurde | 120 min. |
| 7.G  |17.11.22| Niclas     | Man soll alle Tiere in einer Liste ausgeben  | 90 min. |
| 8.H  |17.11.22| Niclas     | Man soll die Liste nach Kriterien ordnen können.  | 120 min. |
| 9.I  |24.11.22| Niclas     | Es soll einen Verlauf geben für schon gesuchten Tieren. | 120 min. |
| 10.J |24.11.22| Niclas     | Falsche Informationen sollen gemeldet können werden. | 90 min. |


### 2.2 Planen vom Quiz

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |10.11.22| Luca     | Quiz Struktur programmieren  | 180 min. |
| 2.B  |17.11.22| Luca     | Anschluss zur Datentenbank | 60 min. |
| 3.C  |17.11.22| Luca     | RNG Fragen programmieren | 120 min. |
| 4.D  |24.11.22| Luca     | Richtig und Falsch als Antworten programmieren.  | 60 min. |
| 5.E  |24.11.22| Luca     | Lösungsvergleich programmieren. | 120 min. |
| 6.F  |01.12.22| Luca     | Spielfortsetzer/Pausemenü programmieren. | 90 min. |
| 7.G  |01.12.22| Luca     | Schlussgratulation und Neuspiel programmieren. | 60 min. |
| 8.H  |08.12.22| Luca     | Schwierigkeit programmieren. | 60 min. |
| 9/10.I  |08.12.22| Luca   | Schwierigkeit der Fragen programmiren. | 60 min. |



### 2.3 Planen vom Populationsdiagramm

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |10.11.22| Elias     | Eingabe von den Zahlen   | 240 min. |
| 2.B  |17.11.22| Elias     |  | 60 min. |
| 3.C  |17.11.22| Elias     |  | 120 min. |
| 4.D  |24.11.22| Elias     |   | 60 min. |
| 5.E  |24.11.22|      | | 120 min. |
| 6.F  |01.12.22|      |  | 90 min. |
| 7.G  |01.12.22|      |  | 60 min. |
| 8.H  |08.12.22|      |  | 60 min. |
| 9/10.I  |08.12.22|    |  | 60 min. |


Total: 

## 3 Entscheiden

Wir haben und dazu entscheiden alle 3 Programme in einem Programm zu schreiben, und mit einem Menu zu arbeiten, mit dem man die verschiedenen Dinge auswählen kann.

## 4 Realisieren

### Realisieren Nahrungsnetz

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  20.10.22     |     Niclas      |       240 min.        |                   |
| 2.B  |  27.10.22     |     Niclas      |       60 min.        |                   |
| 3.C  |  27.10.22     |     Niclas      |       120 min.        |                   |
| 4.D  |  03.11.22     |     Niclas      |       240 min.        |                   |
| 11.K  |  03.11.22     |    Elias       |       240 min.        |       ca. 220 min. mit Toturial schauen            |
| 5.E  |       |     Niclas      |     60 min.      |                   |
| 6.F  |       |     Niclas      |     120 min.      |                   |
| 7.G  |       |     Niclas      |     90 min.          |                   |
| 8.H  |       |     Niclas      |     120 min.          |                   |
| 9.I  |       |     Niclas      |     120 min.          |                   |
| 10.J  |       |    Niclas       |    90 min.           |                   |

### Realisieren Quiz

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |3.11.22|     Luca      |      180 min.         |       240 min.      |
| 2.B  |10.11.22|     Luca      |     60 min.          |       90 min.       |
| 3.C  |10.11.22 |     Luca      |    120 min.  |     120 min.      |
| 4.D  |       |     Luca      |               |                   |
| 5.E  |       |     Luca      |               |                   |
| 6.F  |       |     Luca      |               |                   |
| 7.G  |       |     Luca      |               |                   |
| 8.H  |       |     Luca      |               |                   |
| 9/10.I  |       |     Luca      |               |                   |
| ...  |       |     Luca      |               |                   |
| ...  |       |     Luca      |               |                   |



### Realisieren Populationsdiagramm

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
