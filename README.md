# Biologie Nahrungsnetz

 Team DxD              
 Luca Jeanneret Winsky, Niclas Erismann, Elias Spycher

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | Wir haben unseres Thema ausgewählt und ich Luca hat Herr Siegrist für Anforderungen gefragt.|
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren
das ist ein text

### 1.1 Ihr Projekt

Wir müssen drei Programme programieren eine Datenbank mit Informationen mit Nahrungsnetz von Lebewesen, ein Quiz zum Nahrungsnetzes und eine Simulation von Populationsverlauf von Räuber und Beute.

### 1.2.1 User Stories für 1. Projekt

| US-№ | Verbindlichkeit | Typ  |Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      muss       | Funktion | Ich möchte, dass eine Datenbank eingelesen wird, damit man die Informationen sehen kann. | 
| 2    |      muss       | Funktion | Ich möchte, dass man ein Lebewesen, über das man etwas erfahren will, einlesen kann, damit man schlauer wird.  | 
| 3    |      muss       | Funktion | Ich möchte, dass der Name des Lebwesens angezeigt wird und darunter Familie, Nahrung und feinde angezeigt werden.|
| 3    |      muss       | Funktion | Ich möchte, dass der Nutzer gefragt wird ob ein weiteres Tier eingelesen werden soll, damit man noch schlauer werden kann. |
| 4    |      kann       | Funktion | Ich möchte, dass Falscheingaben mit catch if behandelt werden, dass das Programm nicht abstürzt.|
| 5    |      kann       | Funktion | Ich möchte, dass bei Eingaben die nicht genau dem Tier entsprechen vorgeschlagen wird, was man sonnst suchen könnte.|
| 6    |      kann       | Funktion | Ich möchte, dass der Benutzer alle Tiere geordnet ausgeben kann, damit er einen Überblick hat.|
| 7    |      kann       | Funktion | Ich möchte, dass man die Sortierung anpassen kann nach verschiedenen Kriterien, dass der Nutzer Tiere besser findet.|
| 5    |      kann       | Funktion | Ich möchte anzeigen lassen welche Tiere die letzten Male gesucht worden, damit man Sachen wiederfindet.|
| 5    |      kann       | Funktion | Ich möchte, dass man Informationen, welche falsch erscheinen melden kann, damit man Falschinfos vermeiden kann.|
| 5    |      kann       | Funktion | Ich möchte.|


### 1.2.2 User Stories für 2. Projekt

| US-№ | Verbindlichkeit | Typ  |Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      muss       | Funktion | Ich möchte, dass der Nutzer das Programm mit Tastendruck starten kann, damit er spielen kann|
| 2    |      muss       | Funktion | Ich möchte, dass eine zufällige Frage aus der Datenbank ausgegeben wird, dass er eine Frage bekommt.|
| 3    |      muss       | Funktion | Ich möchte, dass der Nutzer zwischen richtig und falsch auswählen kann, dass er antworten kann.|
| 4    |      muss       | Funktion | Ich möchte, dass die Anwort mit der Lösung verglichen wird und ausgegeben wird ob es die richtige Antwort ist, damit der Nutzer weiss ob er richtig war.|
| 5    |      muss       | Funktion | Ich möchte, dass gefragt wird ob der Nutzer die nächste Frage beantworten will, damit er weiterspielen kann.|
| 6    |      muss       | Funktion | Ich möchte, dass dem Benutzer am schluss vom Quiz gratuliert wird und für eine weitere Runde gefragt wird.|
| 7    |      muss       | Funktion | .|


### 1.2.3 User Stories für 3. Projekt

| US-№ | Verbindlichkeit | Typ  |Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      muss       | Funktion | Ich möchte, dass der Nutzer Zahlen zu für den Momentanen Bestand der Beute eingeben kann um, damit zu rechnen|
| 2    |      muss       | Funktion | Ich möchte als Nutzer, dass die Beute und die Räuber andere Farben haben , damit ich sie unterscheiden kann. |
| 3    |      muss       | Funktion | Ich möchte, als Nutzer, dass die x/y Zahlen bein Diagramm angezeigt werden, damit ich das ich es Visuel sehen kann.|
| 4    |      muss       | Funktion | Ich möchte, als Nutzer, mehrere Jahren haben, damit ich es länger sehen kann.|
| 5    |      muss       | Funktion | Ich möchte, als Nutzer, mit einem knopf von neu anfangen, damit ich neue angaben reintun kann.|
| 6    |      kann       | Rand | Ich möchte, als Nutzer, Lebewesen aus dem ersten Programm direckt nehmen, damit es cool ist.|
| 7    |      


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm läuft und ein Lebewesen wird vom Nutzer ausgewählt. | Linksklick | Zeigt das Nahrungsnetz des Lebewesens. |
| 1.2  | Das Programm läuft und ein Lebewesen wird ausgewählt. | Linksklick | Zeigt Informationen des Lebewesens. |
| 2.1  | Das Programm läuft und eine Frage wird angezeigt. | y | Die Antwort war falsch. |
| 2.2  | Das Programm läuft und eine Frage wird angezeigt. | y | Die Antwort war richtig. |
| 2.3  | Das Programm läuft und die Antworten werden zusammen gerechnet. | Enter | Sie haben 50% korekt. |
| 3.1  | Das Programm läuft und startet die Simulation. | Enter | Zeigt erstes Jahr. |
| 3.2  | Das Programm läuft und erstes Jahr ist angezeigt. | Enter | Zeigt zweites Jahr. |



### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |29.9.22| alle          | Das Programm soll die Datenbank anzeigen mit Nahrungsnetz | 240 min. |
| 2.A  |30.9.22| alle          | Das Programm soll die Datenbank anzeigen mit Informationen | 60 min. |

Total: 

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

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

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
